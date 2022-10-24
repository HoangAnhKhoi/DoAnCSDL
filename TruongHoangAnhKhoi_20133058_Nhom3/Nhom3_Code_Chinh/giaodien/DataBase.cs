using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Data.Common;

namespace giaodien
{
    internal class DataBase
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;

        DataSet ds;
        public DataBase()
        {
            string strCnn = @"Data Source=DESKTOP-VB316NT\SQLEXPRESS; Database=QLSuaChuaXe3;" +
                            "user id = sa;password = 123456; MultipleActiveResultSets=True;";
            //string strCnn = @"Data Source=LAPTOP-ER9IVPEV\SQLEXPRESS; Database=QLSuaChuaXe3;" +
            //                "user id = sa;password = 01677448545; MultipleActiveResultSets=True;";
            sqlConn = new SqlConnection(strCnn);

        }
        public void ExecuteCMD(SqlCommand cmd)
        {
            sqlConn.Open();
            cmd.Connection = sqlConn;
            cmd.ExecuteNonQuery();
            sqlConn.Close();
        }
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }
        public string ChuanTen(string ten)
        {
            ten = ten.Trim();
            Regex trimmer = new Regex(@"\s\s+");
            ten = trimmer.Replace(ten, " ");
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ten);
        }
    }
}
