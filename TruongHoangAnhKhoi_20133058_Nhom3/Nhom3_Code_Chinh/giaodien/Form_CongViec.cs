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
    public partial class Form_CongViec : Form
    {
        public Form_CongViec()
        {
            InitializeComponent();
        }

        private void Form_CongViec_Load(object sender, EventArgs e)
        {
            try
            {
                GarageDB db = new GarageDB();
                DataTable tho = db.LayBang(db.CV);
                FillDataIntoGrid(tho);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillDataIntoGrid(DataTable list)
        {
            data_cv.Rows.Clear();
            for (int i = 0; i < list.Rows.Count; i++)
            {
                int index = data_cv.Rows.Add();
                data_cv.Rows[i].Cells[0].Value = list.Rows[i][0].ToString();
                data_cv.Rows[i].Cells[1].Value = list.Rows[i][1].ToString();
                data_cv.Rows[i].Cells[2].Value = list.Rows[i][2].ToString();
                data_cv.Rows[i].Cells[3].Value = list.Rows[i][3].ToString();
            }
        }

        private void btn_themcv_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            GarageDB gr = new GarageDB();
            string macv = txt_macv.Text;
            string ndcv = txt_ndcv.Text;
            string tiencong = txt_tiencv.Text;
            string tienhh = txt_tienhh.Text;
            string query1 = "MaCV='" + macv + "'";
            if (macv == "" || ndcv == "" || tiencong == "" || tienhh == "")
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (gr.LayBangDK(query1, gr.CV).Rows.Count != 0)
                    MessageBox.Show("Mã số này đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    string query2 = "insert into CONGVIEC values('" + macv + "',N'" + ndcv + "'," + tiencong + "," + tienhh + ")";
                    db.ExecuteNonQuery(query2);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            DataTable tho = gr.LayBang(gr.CV);
            FillDataIntoGrid(tho);
        }

        private void btn_suacv_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            GarageDB gr = new GarageDB();
            string macv = txt_macv.Text;
            string ndcv = txt_ndcv.Text;
            string tiencong = txt_tiencv.Text;
            string tienhh = txt_tienhh.Text;
            string query1 = "MaCV='" + macv + "'";
            if (macv == "" || ndcv == "" || tiencong == "" || tienhh == "")
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (gr.LayBangDK(query1, gr.CV).Rows.Count == 0)
                    MessageBox.Show("Mã số này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    string query2 = "update CONGVIEC set NoiDungCV=N'" + ndcv + "',TienCong=" + tiencong + ",TienHH=" + tienhh + " where MaCV='" + macv + "'";
                    db.ExecuteNonQuery(query2);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            DataTable tho = gr.LayBang(gr.CV);
            FillDataIntoGrid(tho);
        }

        private void btn_xoacv_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            GarageDB gr = new GarageDB();
            string macv = txt_macv.Text;
            string query1 = "MaCV='" + macv + "'";
            if (macv == "")
                MessageBox.Show("Hãy nhập mã công việc", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (gr.LayBangDK(query1, gr.CV).Rows.Count == 0)
                    MessageBox.Show("Mã số này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    string query3 = "MaCV='" + macv + "'";
                    DataTable a = gr.LayBangDK(query3, gr.CT);
                    if (a.Rows.Count != 0)
                    {
                        MessageBox.Show("Không thể xóa. Dữ liệu đang liên kết với bảng hợp đồng nào đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string query2 = "MaCV='" + macv + "'";
                        gr.deleteDK(query2, gr.CV);
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            DataTable tho = gr.LayBang(gr.CV);
            FillDataIntoGrid(tho);
        }

        private void data_cv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    DataGridViewRow row = new DataGridViewRow();
                    row = data_cv.Rows[e.RowIndex];
                    if (row != null && row!=data_cv.Rows[data_cv.Rows.Count-1])
                    {
                        txt_macv.Text = row.Cells[0].Value.ToString();
                        txt_ndcv.Text = row.Cells[1].Value.ToString();
                        txt_tiencv.Text = row.Cells[2].Value.ToString();
                        txt_tienhh.Text = row.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_tiencv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tiencv_Leave(object sender, EventArgs e)
        {
            bool a = true;
            GarageDB gr = new GarageDB();
            string tiencv = txt_tiencv.Text;
            foreach (int i in tiencv)
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
                txt_tiencv.Text = "";
            }
        }

        private void txt_tienhh_Leave(object sender, EventArgs e)
        {
            bool a = true;
            GarageDB gr = new GarageDB();
            string tienhh = txt_tienhh.Text;
            foreach (int i in tienhh)
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
                txt_tienhh.Text = "";
            }
        }
    }
}
