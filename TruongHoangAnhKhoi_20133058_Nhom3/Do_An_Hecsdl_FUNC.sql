USE QLSuaChuaXe3
Declare @procName varchar(500) 
Declare cur Cursor For Select [name] From sys.objects where type = 'p' 
Open cur 
Fetch Next From cur Into @procName 
While @@fetch_status = 0 
Begin 
 Exec('drop procedure ' + @procName) 
 Fetch Next From cur Into @procName 
End
Close cur 
Deallocate cur 
GO
---Thêm, xóa, sửa, xuất bảng NHÂN VIÊN
-----Xuât thông tin
CREATE FUNCTION XUAT_NV() RETURNS table
as
RETURN (SELECT * FROM VIEW_NV)
GO
-----thêm
CREATE proc THEM_NV
@nguoiid CHAR(6),
@hoten nvarchar(30),
@diachi nvarchar(30),
@dienthoai CHAR(11),
@ngaysinh date,
@cccd CHAR(11),
@gioitinnh bit,
@macv CHAR(6),
@luong int
AS
IF EXISTS(SELECT 1 FROM KHACHHANG WHERE KH_NguoiID=@nguoiid)
		BEGIN
			PRINT(N'Mã số này đã tồn tại')
		END
	ELSE 
		BEGIN
			INSERT INTO dbo.TT_NGUOI(NguoiID,Hoten,DiaChi,DienThoai,NgaySinh,CCCD,GioiTinh)
			VALUES(@nguoiid, @hoten, @diachi, @dienthoai,@ngaysinh,@cccd,@gioitinnh     )
			INSERT INTO dbo.NHANVIEN(NV_NguoiID,MaCV,Luong)
			VALUES(@nguoiid,@macv,@luong)
			PRINT(N'Thêm thành công')
		END
GO
-----sửa
CREATE PROC SUA_NV
@nguoiid CHAR(6),
@hoten nvarchar(30),
@diachi nvarchar(30),
@dienthoai CHAR(11),
@ngaysinh date,
@cccd CHAR(11),
@gioitinh bit,
@macv CHAR(6),
@luong INT
AS
IF EXISTS(SELECT 1 FROM KHACHHANG WHERE KH_NguoiID=@nguoiid)
	BEGIN
		UPDATE dbo.TT_NGUOI
		SET Hoten=@hoten,DiaChi=@diachi,DienThoai=@dienthoai,NgaySinh=@ngaysinh,CCCD=@cccd,GioiTinh=@gioitinh 
		WHERE NguoiID = @nguoiid;
		UPDATE dbo.NHANVIEN
		SET Luong=@luong
		WHERE NV_NguoiID=@nguoiid;
		PRINT(N'Sửa thành công')
	END
ELSE
	BEGIN
		PRINT(N'Mã số nhân viên này không tồn tại')
	END
GO
-----XÓA
CREATE PROC XOA_NV
@nguoiid CHAR(6)
as
IF EXISTS(SELECT 1 FROM KHACHHANG WHERE KH_NguoiID=@nguoiid)
	BEGIN
		DELETE FROM dbo.TT_NGUOI WHERE @nguoiid = NguoiID;
		PRINT(N'Xóa thành công')
	END
ELSE
	BEGIN
		PRINT(N'Mã số nhân viên này không tồn tại')
	END
GO
---Thêm, xóa, sửa, xuất bảng KHÁCH HÀNG
-----XUẤT
CREATE FUNCTION XUAT_KH() RETURNS table
as
RETURN (SELECT * FROM VIEW_KH)

GO
-----THÊM
CREATE PROC THEM_KH 
@nguoiid CHAR(6),
@hoten nvarchar(30),
@diachi nvarchar(30),
@dienthoai CHAR(11),
@ngaysinh date,
@cccd CHAR(11),
@gioitinh bit
AS
BEGIN
	--DECLARE @id CHAR(6) SELECT @id = 
	IF EXISTS(SELECT 1 FROM KHACHHANG WHERE KH_NguoiID=@nguoiid)
		BEGIN
			PRINT(N'Mã số này đã tồn tại')
		END
	ELSE 
		BEGIN
			INSERT INTO TT_NGUOI VALUES (@nguoiid,@hoten,@diachi,@dienthoai,@ngaysinh,@cccd,@gioitinh)
			INSERT INTO KHACHHANG VALUES(@nguoiid)
		END
END
GO
----- SỬA
CREATE PROC SUA_KH
@nguoiid CHAR(6),
@hoten nvarchar(30),
@diachi nvarchar(30),
@dienthoai CHAR(11),
@ngaysinh date,
@cccd CHAR(11),
@gioitinh bit
AS
BEGIN
	IF EXISTS(SELECT 1 FROM KHACHHANG WHERE KH_NguoiID=@nguoiid)
		BEGIN
			UPDATE TT_NGUOI
			SET HoTen=@hoten,DiaChi=@DiaChi,DienThoai=@dienthoai,NgaySinh=@ngaysinh,CCCD=@cccd,GioiTinh=@gioitinh
			WHERE NguoiID=@nguoiid
		END
	ELSE
		BEGIN
			PRINT(N'Mã số này không tồn tại ')
		END
END

GO
----- Xóa
CREATE PROC XOA_KH
@nguoiid CHAR(6)
AS
IF EXISTS(SELECT 1 FROM KHACHHANG WHERE KH_NguoiID=@nguoiid)
	BEGIN
		DELETE 
		FROM TT_Nguoi
		WHERE NguoiID=@nguoiid
	END
ELSE
	BEGIN
		PRINT(N'Mã số này không tồn tại ')
	END
GO
---Thêm, xóa, sửa, xuất bảng VẬT LIỆU
CREATE FUNCTION XUAT_VL() RETURNS table
as
RETURN (SELECT * FROM VATLIEU)

GO
-----THÊM
CREATE PROC THEM_VL 
@mavl CHAR(6),
@tenvl nvarchar(20),
@soluong int 
AS
BEGIN
IF EXISTS(SELECT 1 FROM VATLIEU WHERE MaVL=@mavl)
	BEGIN
		PRINT(N'Mã vật liệu này đã tồn tại')
	END
ELSE
	BEGIN
		INSERT INTO VATLIEU VALUES (@mavl,@tenvl,@soluong)
		PRINT(N'Thêm thành công')
	END
END

GO
----- SỬA
CREATE PROC SUA_VL
@mavl CHAR(6),
@tenvl nvarchar(20),
@soluong int 
AS
BEGIN
IF EXISTS(SELECT 1 FROM VATLIEU WHERE MaVL=@mavl)
	BEGIN
		UPDATE VATLIEU
		SET TenVL=@tenvl,SoLuong=@soluong
		WHERE MaVL=@mavl
		PRINT(N'Sửa thành công')
	END
ELSE
	BEGIN
		PRINT(N'Mã vật liệu này không tồn tại')
	END
END

GO
----- Xóa
CREATE PROC XOA_VL
@mavl CHAR(6)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM VATLIEU WHERE MaVL=@mavl)
		BEGIN
			DELETE 
			FROM VATLIEU
			WHERE MaVL=@mavl
			PRINT(N'Xóa thành công')
		END
	ELSE
		BEGIN
			PRINT(N'Mã vật liệu này không tồn tại')
		END
END

GO
---Thêm, xóa, sửa, xuất bảng NHÀ CUNG CẤP
-----XUẤT
CREATE FUNCTION XUAT_NCC() RETURNS table
as
RETURN (SELECT * FROM NHACUNGCAP)
GO
-----THÊM
CREATE PROC THEM_NCC
@manhacc CHAR(6),
@tennhacc nvarchar(30),
@dienthoai CHAR(11),
@diachi nvarchar(30)
AS
BEGIN
IF EXISTS(SELECT 1 FROM NHACUNGCAP WHERE MaNhaCC=@manhacc)
	BEGIN
		PRINT(N'Mã nhà cung cấp này đã tồn tại')
	END
ELSE
	BEGIN
		INSERT INTO NHACUNGCAP VALUES (@manhacc,@tennhacc,@dienthoai,@diachi)
		PRINT(N'Thêm thành công')
	END
END

GO
----- SỬA
CREATE PROC SUA_NCC
@manhacc CHAR(6),
@tennhacc nvarchar(30),
@dienthoai CHAR(11),
@diachi nvarchar(30)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM NHACUNGCAP WHERE MaNhaCC=@manhacc)
	BEGIN
		UPDATE NHACUNGCAP
		SET TenNhaCC=@tennhacc,DienThoai=@dienthoai,DiaChi=@diachi
		WHERE MaNhaCC=@manhacc
		PRINT(N'Sửa thành công')
	END
	ELSE
		BEGIN
			PRINT(N'Mã nhà cung cấp này không tồn tại')
		END	
END

GO
----- Xóa
CREATE PROC XOA_NCC
@manhacc CHAR(6)
AS
IF EXISTS(SELECT 1 FROM NHACUNGCAP WHERE MaNhaCC=@manhacc)
	BEGIN
		DELETE 
		FROM NHACUNGCAP
		WHERE MaNhaCC=@manhacc
	END
ELSE
	BEGIN
		PRINT(N'Mã nhà cung cấp này không tồn tại')
	END	
GO
---Thêm, xóa, sửa, xuất bảng CONGVIEC
CREATE FUNCTION XUAT_CVIEC() RETURNS table
as
RETURN (SELECT * FROM CONGVIEC)

GO
-----THÊM
CREATE PROC THEM_CVIEC
@macv CHAR(6),
@noidungcv nvarchar(40),
@tiencong int,
@vatlieu char(6)
AS
BEGIN
IF EXISTS(SELECT 1 FROM CONGVIEC WHERE MaCViec=@macv)
	BEGIN
		PRINT(N'Mã công việc này đã tồn tại')
	END
ELSE
	BEGIN
		INSERT INTO CONGVIEC VALUES (@macv,@noidungcv,@tiencong,@vatlieu)
	END
END

GO
----- SỬA
CREATE PROC SUA_CViec
@macv CHAR(6),
@noidungcv nvarchar(40),
@tiencong int,
@vatlieu char(6)
AS
BEGIN
IF EXISTS(SELECT 1 FROM CONGVIEC WHERE MaCViec=@macv)
	BEGIN
		UPDATE CONGVIEC
		SET NoiDungCV=@noidungcv,TienCong=@tiencong,VatLieu=@vatlieu
		WHERE MaCViec=@macv
		PRINT(N'Sửa thành công')
	END
ELSE
	BEGIN
		PRINT(N'Mã số công việc này không tồn tại')
	END
END

GO
----- Xóa
CREATE PROC XOA_CViec
@macv CHAR(6)
AS
IF EXISTS(SELECT 1 FROM CONGVIEC WHERE MaCViec=@macv)
	BEGIN
		DELETE 
		FROM CONGVIEC
		WHERE MaCViec=@macv
		PRINT(N'Sửa thành công')
	END
ELSE
	BEGIN

		PRINT(N'Mã số công việc này không tồn tại')
	END
GO
---Thêm, xóa, sửa, xuất bảng HÓA ĐƠN
CREATE FUNCTION XUAT_HOADON() RETURNS TABLE
AS
	RETURN (SELECT * FROM HOADON)
GO
-----THÊM
CREATE PROC THEM_HOADON
@MaHoaDon CHAR(6),
@NgayLapHoaDon DATE,
@MaHopDong CHAR(6),
@KH_NguoiID CHAR(6),
@HoTen NVARCHAR(40),
@SoTienThu INT
AS
BEGIN
	INSERT INTO HOADON
	VALUES(@MaHoaDon,@NgayLapHoaDon,@MaHopDong,@KH_NguoiID,@HoTen,@SoTienThu)
END
GO
--Sửa
CREATE PROC SUA_HOADON
@MaHoaDon CHAR(6),
@NgayLapHoaDon DATE,
@MaHopDong CHAR(6),
@KH_NguoiID CHAR(6),
@HoTen NVARCHAR(40),
@SoTienThu INT
AS
BEGIN
	UPDATE HOADON
	SET MaHoaDon=@MaHoaDon, NgayLapHoaDon=@NgayLapHoaDon, MaHopDong=@MaHopDong, KH_NguoiID=@KH_NguoiID, HoTen=@HoTen, SoTienThu=@SoTienThu
	WHERE MaHoaDon=@MaHoaDon
END

GO
--Xóa
CREATE PROC XOA_HOADON(@MaHoaDon CHAR(6))
AS
	DELETE
	FROM HOADON
	WHERE MaHoaDon=@MaHoaDon
GO
---Thêm xóa sửa xuất bảng chức vụ
-----Xuất chuc vu
CREATE FUNCTION XUAT_CHUCVU() RETURNS table
as
RETURN (SELECT * FROM CHUCVU)
GO
-----Them chuc vu
CREATE proc THEM_CHUCVU
@macv char(6),
@tencv nvarchar(20)
AS
INSERT INTO dbo.CHUCVU
VALUES(@macv,@tencv)
GO
------Xoa chuc vu
CREATE PROC XOA_CHUCVU
@macv CHAR(6)
as
DELETE FROM dbo.CHUCVU WHERE @macv = MaCV;
GO
----Sua chuc vu
create proc SUA_CHUCVU
@macv char(6),
@tencv nvarchar(20)
as
update dbo.CHUCVU
set TenCV = @tencv
where @macv = MaCV
go
---Thêm xóa sửa bảng USERS
-----Thêm
CREATE PROC THEM_USER
@Username CHAR(20),
@Pass CHAR(20),
@Chucvu NVARCHAR(30)
AS
BEGIN
	INSERT INTO USERS
	VALUES(@Username,@Pass,@Chucvu)
END
GO
-----Sửa
CREATE PROC SUA_USERS
@Username CHAR(20),
@Pass CHAR(20),
@Chucvu NVARCHAR(30)
AS
BEGIN
	UPDATE USERS
	SET Username=@Username, Pass=@Pass, Chucvu=@Chucvu
	WHERE Username=@Username
END
GO
--Xóa
CREATE PROC XOA_USER(@Username CHAR(20))
AS
	DELETE
	FROM USERS
	WHERE Username=@Username
