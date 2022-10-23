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
    public partial class Form_KhachHang : Form
    {
        public Form_KhachHang()
        {
            InitializeComponent();
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_KhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                GarageDB db = new GarageDB();
                DataTable KHang = db.LayBang(db.KH);
                FillDataIntoGrid(KHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillDataIntoGrid(DataTable list)
        {
            /*data_KHang.Rows.Clear();
            for (int i = 0; i < list.Rows.Count; i++)
            {
                int index = data_KHang.Rows.Add();
                data_KHang.Rows[i].Cells[0].Value = list.Rows[i][0].ToString();
                data_KHang.Rows[i].Cells[1].Value = list.Rows[i][1].ToString();
                data_KHang.Rows[i].Cells[2].Value = list.Rows[i][2].ToString();
                data_KHang.Rows[i].Cells[3].Value = list.Rows[i][3].ToString();
            }*/
        }

        private void btn_themKH_Click(object sender, EventArgs e)
        {
            /*DataBase db = new DataBase();
            GarageDB gr = new GarageDB();
            string makh = txt_makh.Text;
            string tenkh = txt_tenkh.Text;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            string query1 = "MaKH='" + makh + "'";
            if (makh == "" || tenkh == "" || diachi == "" || sdt == "")
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (gr.LayBangDK(query1, gr.KH).Rows.Count != 0)
                    MessageBox.Show("Mã số này đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    string query2 = "insert into KHACHHANG values('" + makh + "',N'" + tenkh + "',N'" + diachi + "','" + sdt + "')";
                    db.ExecuteNonQuery(query2);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            DataTable KHang = gr.LayBang(gr.KH);
            FillDataIntoGrid(KHang);*/
        }

        private void btn_suaKH_Click(object sender, EventArgs e)
        {
            /*DataBase db = new DataBase();
            GarageDB gr = new GarageDB();
            string makh = txt_makh.Text;
            string tenkh = txt_tenkh.Text;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            string query1 = "MaKH='" + makh + "'";
            if (makh == "" || tenkh == "" || diachi == "" || sdt == "")
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (gr.LayBangDK(query1, gr.KH).Rows.Count == 0)
                    MessageBox.Show("Mã số này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    string query2 = "update KHACHHANG set TenKH=N'" + tenkh + "',Diachi=N'" + diachi + "',DienThoai='" + sdt + "' where MaKH='" + makh + "'";
                    db.ExecuteNonQuery(query2);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            DataTable KHang = gr.LayBang(gr.KH);
            FillDataIntoGrid(KHang);*/
        }

        private void btn_xoaKH_Click(object sender, EventArgs e)
        {
            /*DataBase db = new DataBase();
            GarageDB gr = new GarageDB();
            string makh = txt_makh.Text;
            string query1 = "MaKH='" + makh + "'";
            if (makh == "")
                MessageBox.Show("Hãy nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (gr.LayBangDK(query1, gr.KH).Rows.Count == 0)
                    MessageBox.Show("Mã số này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    string query3 = "MaKH='" + makh + "'";
                    DataTable a = gr.LayBangDK(query3, gr.HD);
                    if (a.Rows.Count != 0)
                    {
                        MessageBox.Show("Không thể xóa. Dữ liệu đang liên kết với bảng hợp đồng nào đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string query2 = "MaKH='" + makh + "'";
                        gr.deleteDK(query2, gr.KH);
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            DataTable KHang = gr.LayBang(gr.KH);
            FillDataIntoGrid(KHang);*/
        }

        private void data_KHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                    DataGridViewRow row = new DataGridViewRow();
                    row = data_KHang.Rows[e.RowIndex];
                    if (row != null && row!=data_KHang.Rows[data_KHang.Rows.Count-1])
                    {
                        txt_makh.Text = row.Cells[0].Value.ToString();
                        txt_tenkh.Text = row.Cells[1].Value.ToString();
                        txt_diachi.Text = row.Cells[2].Value.ToString();
                        txt_sdt.Text = row.Cells[3].Value.ToString();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void txt_sdt_Leave(object sender, EventArgs e)
        {
            /*bool a = true;
            GarageDB gr = new GarageDB();
            string sdt = txt_sdt.Text;
            foreach (int i in sdt)
            {
                if (i < 48 || i > 57)
                {
                    a = false;
                    break;
                }
            }
            if (a == false)
            {
                MessageBox.Show("Mục này không được có chữ", "Thông báo", MessageBoxButtons.OK);
                txt_sdt.Text = "";
            }
            if(sdt.Length>10)
            {
                MessageBox.Show("Số điện thoại phải 10 số", "Thông báo", MessageBoxButtons.OK);
                txt_sdt.Text = "";
            }*/    
        }
    }
}
