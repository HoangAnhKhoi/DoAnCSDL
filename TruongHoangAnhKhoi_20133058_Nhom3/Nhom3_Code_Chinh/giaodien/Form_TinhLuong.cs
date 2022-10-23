using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class Form_TinhLuong : Form
    {
        private DataTable tb_nv = new DataTable();
        private DataBase db = new DataBase();
        private GarageDB gr = new GarageDB();
        public Form_TinhLuong()
        {
            InitializeComponent();
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void Form_TinhLuong_Load(object sender, EventArgs e)
        {
            DataColumn column1 = new DataColumn("MaTho");
            column1.DataType = typeof(string);
            tb_nv.Columns.Add(column1);
            DataColumn column2 = new DataColumn("TenTho");
            column2.DataType = typeof(string);
            tb_nv.Columns.Add(column2);
            DataColumn column3 = new DataColumn("LuongCung");
            column3.DataType = typeof(int);
            tb_nv.Columns.Add(column3);
            DataColumn column4 = new DataColumn("HoaHong");
            column4.DataType = typeof(int);
            tb_nv.Columns.Add(column4);
            DataColumn column5 = new DataColumn("LuongTong");
            column5.DataType = typeof(int);
            tb_nv.Columns.Add(column5);

        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string BD = date_luongBD.Value.ToString("yyyy-MM-dd");
                string KT = date_luongKT.Value.ToString("yyyy-MM-dd");
                string query1 = "NgayHD>='" + BD + "' and NgayHD<='" + KT + "'";
                DataTable tb1 = gr.LayBangDK(query1, gr.HD);
                string query2 = "where";
                int index = 0;
                foreach (DataRow i in tb1.Rows)
                {
                    query2 = query2 + " SoHD=" + i["SoHD"].ToString();
                    if (index < tb1.Rows.Count - 1)
                        query2 = query2 + " or";
                    index++;
                }
                string query3 = "SELECT Matho,sum(KhoanTho) AS TongKhoan FROM dbo.CHITIET_HD "
                                + query2 + " GROUP BY MaTho";
                DataTable tb2 = db.Execute(query3);
                DataTable tb_tho = gr.LayBang(gr.THO);
                foreach (DataRow i in tb_tho.Rows)
                {
                    int tienhh = 0;
                    foreach (DataRow j in tb2.Rows)
                    {
                        if (i["MaTho"].ToString() == j["MaTho"].ToString())
                        {
                            tienhh = int.Parse(j["TongKhoan"].ToString());
                            break;
                        }
                    }
                    DataRow add = tb_nv.NewRow();
                    add["MaTho"] = i["MaTho"].ToString();
                    add["TenTho"] = i["TenTho"].ToString();
                    add["LuongCung"] = int.Parse(i["Luong"].ToString());
                    add["HoaHong"] = tienhh;
                    add["LuongTong"] = int.Parse(i["Luong"].ToString()) + tienhh;
                    tb_nv.Rows.Add(add);
                }
                MessageBox.Show("Tính lương thành công", "Thông báo", MessageBoxButtons.OK);
                FillDataIntoGrid(tb_nv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillDataIntoGrid(DataTable list)
        {
            data_Luong.Rows.Clear();
            for (int i = 0; i < list.Rows.Count; i++)
            {
                int index = data_Luong.Rows.Add();
                data_Luong.Rows[i].Cells[0].Value = list.Rows[i][0].ToString();
                data_Luong.Rows[i].Cells[1].Value = list.Rows[i][1].ToString();
                data_Luong.Rows[i].Cells[2].Value = list.Rows[i][2].ToString();
                data_Luong.Rows[i].Cells[3].Value = list.Rows[i][3].ToString();
                data_Luong.Rows[i].Cells[4].Value = list.Rows[i][4].ToString();
            }
        }
        private void ToExcel(DataGridView dataGridView1)
        {
            if (data_Luong.Rows.Count == 1)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!");
            }
            else
            {
                //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
                Microsoft.Office.Interop.Excel.Application excel;
                Microsoft.Office.Interop.Excel.Workbook workbook;
                Microsoft.Office.Interop.Excel.Worksheet worksheet;
                try
                {
                    //Tạo đối tượng COM.
                    excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = false;
                    excel.DisplayAlerts = false;
                    //tạo mới một Workbooks bằng phương thức add()
                    workbook = excel.Workbooks.Add(Type.Missing);
                    worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                    //đặt tên cho sheet
                    worksheet.Name = "Bảng lương Garage";

                    // export header trong DataGridView
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                    }
                    // export nội dung trong DataGridView
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    // sử dụng phương thức SaveAs() để lưu workbook với filename
                    string tenfile = "BảngLương " + date_luongBD.Value.Month.ToString() + "-" + date_luongBD.Value.Year.ToString();
                    workbook.SaveAs(tenfile);
                    //đóng workbook
                    workbook.Close();
                    excel.Quit();
                    MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    workbook = null;
                    worksheet = null;
                }
            }
        }

        private void btn_xuatdata_Click(object sender, EventArgs e)
        {
                ToExcel(data_Luong);
        }
    }
}
