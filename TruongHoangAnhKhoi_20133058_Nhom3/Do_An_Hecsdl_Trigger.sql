use QLSuaChuaXe3
go
---------------------View---------------------------
GO
CREATE VIEW HOPDONG_REPORT AS
SELECT HOPDONG.SoHD,NgayHD,KH_NguoiID,SoXE, TriGiaHD, NgayGiaoDuKien, NgayNghiemThu,MaCV, TriGiaCV, MaNV
FROM HOPDONG, CHITIET_HD
where HOPDONG.SoHD = CHITIET_HD.SoHD

GO
CREATE VIEW VIEW_CVIEC AS
SELECT MaCViec, NoiDungCV,TienCong,TenVL
FROM CONGVIEC,VATLIEU
WHERE CONGVIEC.VatLieu=VATLIEU.MaVL

CREATE VIEW VIEW_NV AS
SELECT dbo.NHANVIEN.NV_NguoiID, dbo.TT_NGUOI.Hoten, dbo.TT_NGUOI.DiaChi, dbo.TT_NGUOI.DienThoai, dbo.TT_NGUOI.NgaySinh, 
	   dbo.TT_NGUOI.CCCD, dbo.TT_NGUOI.GioiTinh, dbo.CHUCVU.TenCV, dbo.NHANVIEN.Luong
FROM dbo.NHANVIEN INNER JOIN dbo.TT_NGUOI ON dbo.NHANVIEN.NV_NguoiID = dbo.TT_NGUOI.NguoiID 
				  INNER JOIN dbo.CHUCVU ON dbo.NHANVIEN.MaCV = dbo.CHUCVU.MaCV
GO

CREATE VIEW VIEW_KH AS
SELECT dbo.KHACHHANG.KH_NguoiID, dbo.TT_NGUOI.Hoten, dbo.TT_NGUOI.DiaChi, dbo.TT_NGUOI.DienThoai, 
	   dbo.TT_NGUOI.NgaySinh, dbo.TT_NGUOI.CCCD, dbo.TT_NGUOI.GioiTinh
FROM dbo.KHACHHANG INNER JOIN dbo.TT_NGUOI ON dbo.KHACHHANG.KH_NguoiID = dbo.TT_NGUOI.NguoiID

GO
--------------------TRIGGER------------------------
-----Khi nhập kho thì cập nhật số lượng của vật liệu
CREATE TRIGGER TRG_UPDATE_VL ON NHAPKHO
AFTER INSERT AS
BEGIN
	DECLARE @MaVL CHAR(6),@SL INT SELECT @MaVL=MaVL,@SL=SoLuong FROM INSERTED
	UPDATE VATLIEU
	SET SoLuong = SoLuong + @SL
	WHERE MaVL=@MaVL
END

GO
CREATE TRIGGER TRG_UPDATE_VL_2 ON CHITIET_HD
AFTER INSERT AS
BEGIN
	DECLARE @MaCV CHAR(6),@MaVL CHAR(6) SELECT @MaCV=MaCV FROM INSERTED
										SELECT @MAVL=VatLieu FROM CONGVIEC WHERE MaCViec=@MaCV
	UPDATE VATLIEU
	SET SoLuong=SoLuong-1
	WHERE MaVL=@MaVL
END

GO

CREATE TRIGGER TRG_UPDATE_VL_4 ON CHITIET_HD
AFTER DELETE AS
BEGIN
	DECLARE @SoHD CHAR(6),@MaCV CHAR(6),@MaVL CHAR(6),@NgayNghiemThu DATE 
	SELECT @SoHD=SoHD FROM DELETED
	SELECT @NgayNghiemThu=NgayNghiemThu FROM HOPDONG_BACKUP WHERE SoHD=@SoHD
	SELECT @MaCV=MaCV FROM DELETED
	SELECT @MaVL=VatLieu FROM CONGVIEC WHERE MaCViec=@MaCV
	IF(@NgayNghiemThu is NULL)
	BEGIN
		UPDATE VATLIEU
		SET SoLuong=SoLuong+1
		WHERE MaVL=@MaVL
	END
END
GO
----Tính giá trị của hợp đồng dựa trên các chi tiết hợp đồng
--Tăng giá trị khi thêm một chi tiết

CREATE TRIGGER TRG_UPDATE_HDONG ON CHITIET_HD
AFTER INSERT, UPDATE AS
BEGIN
	DECLARE @SoHD CHAR(6),@TriGiaCV int SELECT @SoHD=SoHD,@TriGiaCV=TriGiaCV FROM INSERTED
	SELECT @TriGiaCV=SUM(TriGiaCV) FROM CHITIET_HD WHERE SoHD=@SoHD
	UPDATE HOPDONG
	SET TriGiaHD = @TriGiaCV
	WHERE SoHD = @SoHD
END
GO
--Giảm giá trị khi xóa một chi tiết

CREATE TRIGGER TRG_UPDATE_HDONG_1 ON CHITIET_HD
AFTER DELETE AS
BEGIN
	DECLARE @SoHD CHAR(6),@TriGiaCV int SELECT @SoHD=SoHD,@TriGiaCV=TriGiaCV FROM DELETED
	UPDATE HOPDONG
	SET TriGiaHD = TriGiaHD - @TriGiaCV
	WHERE SoHD = @SoHD
END

GO
----Các điều kiện khi thêm hóa đơn
CREATE TRIGGER TRG_INSERT_HOADON ON HOADON
AFTER INSERT AS
DECLARE @SoHD CHAR(6),@TongTien INT,@TriGiaHD INT 
SELECT @SoHD=MaHopDong FROM INSERTED
SELECT @TongTien=sum(SoTienThu) FROM HOADON WHERE MaHopDong=@SoHD
SELECT @TriGiaHD=TriGiaHD FROM HOPDONG WHERE SoHD=@SoHD
IF(@TongTien=@TriGiaHD)----khi giá trị các hóa đơn bằng giá trị hợp đồng thì cập nhật NgayNghiemThu
BEGIN
	UPDATE HOPDONG
	SET NgayNghiemThu=GETDATE()
	WHERE SoHD=@SoHD;
	INSERT INTO HOPDONG_BACKUP
	SELECT *
	FROM HOPDONG
	WHERE HOPDONG.SoHD=@SoHD;

	INSERT INTO CHITIET_HD_BACKUP
	SELECT *
	FROM CHITIET_HD
	WHERE CHITIET_HD.SoHD=@SoHD;

	DELETE HOPDONG WHERE SoHD=@SoHD
END
ELSE IF(@TongTien<@TriGiaHD)----khi giá trị các hóa đơn bé hơn thì thêm vào hiện thông báo
BEGIN
	PRINT('Thêm Thành Công');
END
ELSE----khi giá trị các hóa đơn lớn hơn thì xóa thao tác thêm
BEGIN
	RollBack;
END

GO






