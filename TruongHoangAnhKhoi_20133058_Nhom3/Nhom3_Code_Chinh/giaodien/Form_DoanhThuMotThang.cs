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
    public partial class Form_DoanhThuMotThang : Form
    {
        private GarageDB gr = new GarageDB();
        private DataBase db = new DataBase();
        public Form_DoanhThuMotThang()
        {
            InitializeComponent();
        }

        private void btn_tinhDthu_Click(object sender, EventArgs e)
        {
            try
            {
                string BD = date_from.Value.ToString("yyyy-MM-dd");
                string KT = date_to.Value.ToString("yyyy-MM-dd");
                string query1 = "NgayNgThu>='" + BD + "' and NgayNgThu<='" + KT + "'";
                DataTable tb1 = gr.LayBangDK(query1, gr.HD);
                txt_tongtien.Text =FillDataIntoGrid(tb1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int FillDataIntoGrid(DataTable list)
        {
            int doanhthu = 0;
            data_DoanhThu.Rows.Clear();
            for (int i = 0; i < list.Rows.Count; i++)
            {
                int index = data_DoanhThu.Rows.Add();
                data_DoanhThu.Rows[i].Cells[0].Value = list.Rows[i][0].ToString();
                data_DoanhThu.Rows[i].Cells[1].Value = list.Rows[i][1].ToString();
                data_DoanhThu.Rows[i].Cells[2].Value = list.Rows[i][6].ToString();
                data_DoanhThu.Rows[i].Cells[3].Value = list.Rows[i][4].ToString();
                doanhthu = doanhthu + int.Parse(list.Rows[i][4].ToString());
            }
            return doanhthu;
        }

        private void Form_DoanhThuMotThang_Load(object sender, EventArgs e)
        {

        }

        private void btn_xuatDL_Click(object sender, EventArgs e)
        {
            ToExcel(data_DoanhThu);
        }
        private void ToExcel(DataGridView dataGridView1)
        {
            if (dataGridView1.Rows.Count == 1)
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
                    worksheet.Cells[dataGridView1.RowCount + 1, dataGridView1.ColumnCount] = "Tổng: " + txt_tongtien.Text;
                    string tenfile = "Doanhthu " + date_from.Value.Month.ToString() + "-" + date_to.Value.Year.ToString();
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(data_DoanhThu.Rows.Count==1)
                MessageBox.Show("Hãy tính doanh thu của tháng trước");
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa hết dữ liệu của tháng này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 0; i < data_DoanhThu.Rows.Count - 1; i++)
                    {
                        string query1 = " SoHD =" + data_DoanhThu.Rows[i].Cells[0].Value.ToString();
                        gr.deleteDK(query1, gr.CT);
                        gr.deleteDK(query1, gr.PT);
                        gr.deleteDK(query1, gr.HD);
                    }
                    MessageBox.Show("Xóa thành công");
                }
            }    
        }
    }
}
