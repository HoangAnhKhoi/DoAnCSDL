using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace giaodien
{
    internal class GarageDB
    {
        DataBase db;
        public string CT = "CHITIET_HD";
        public string CV = "CONGVIEC";
        public string DN = "DANGNHAP";
        public string HD = "HOPDONG";
        public string KH = "KHACHHANG";
        public string PT = "PHIEUTHU";
        public string THO = "THO";
        public string NHOM = "NHOM";
        public GarageDB()
        {
            db = new DataBase();
        }
        public DataTable LayBang(string Name_Table)
        {
            string strSV = " select * from dbo."+Name_Table;
            DataTable dt = db.Execute(strSV);
            return dt;
        }
        public DataTable LayBangDK(string DieuKien, string TenBang)
        {
            string query = "select * from " + TenBang + " where " + DieuKien;
            return db.Execute(query);
        }
        public void insertAcc(string acc, string pass, string ten, string chucvu)
        {
            string strsql = " insert into " + this.DN + " values ('" + acc + "','" + pass + "',N'" + ten + "',N'" + chucvu + "')";
            db.ExecuteNonQuery(strsql);
        }
        public void insertTho(string maso,string ten,string nhom,string nhomtruong,string luong)
        {
            string query="insert into "+this.THO+" values('"+maso+ "',N'" + ten + "','" + nhom + "','" + nhomtruong + "'," + luong + ")";
            db.ExecuteNonQuery(query);
        }
        public void updateTho(string maso, string ten, string nhom, string nhomtruong, string luong)
        {
            string query = "UPDATE " + this.THO + " SET TenTho = N'" + ten + "',Nhom = " + nhom + ", NhomTruong='" + nhomtruong + "',Luong=" + luong + " WHERE MaTho = '" + maso + "'";
            db.ExecuteNonQuery(query);
        }
        public void deleteDK(string DieuKien,string TenBang)
        {
            string query = "delete from " + TenBang + " where " + DieuKien;
            db.ExecuteNonQuery(query);
        }
        /* public void updateSinhVien(int MSSV, string HoTen, int DiemTB, int Khoa)
         {
             //string sql = " update SinhVien set MSSV ='" + MSSV.ToString()+ "',HoTen='"+HoTen+"',DiemTB ='"+DiemTB.ToString()+"',Khoa='"+Khoa.ToString()+"'";
             string sql = "update sinhvien set HoTen = '" + HoTen + "', DiemTB = " + DiemTB.ToString() + ", Khoa = " + Khoa.ToString() + " where MSSV = '" + MSSV.ToString() + "'";
             DataBase db = new DataBase();
             db.ExecuteNonQuery(sql);
         }
         public void deleteSinhVien(int MSSV)
         {
             string sql = " delete from SinhVien where MSSV = '" + MSSV.ToString() + "'";
             Database db = new Database();
             db.ExecuteNonQuery(sql);
         }*/
    }
}
