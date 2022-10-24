using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class Form_CongViec : Form
    {
        DataBase db = new DataBase();
        public Form_CongViec()
        {
            InitializeComponent();
        }

        private void Form_CongViec_Load(object sender, EventArgs e)
        {
            try
            {
                Form1 formDangNhap = new Form1();
                string query = "SELECT * FROM  XUAT_CVIEC()";
                DataTable table_cv = db.Execute(query);
                if (formDangNhap.ChucVu() == "Quản lý")
                {
                    tabControl.TabPages.Remove(tabThuNgan);
                    data_cv.DataSource = table_cv;
                    string query1 = "SELECT * FROM  XUAT_VL()";
                    DataTable table_chuVu = db.Execute(query1);
                    cb_vlieu.DataSource = null;
                    cb_vlieu.Items.Clear();
                    cb_vlieu.DataSource = table_chuVu;
                    cb_vlieu.DisplayMember = "TenVL";
                    cb_vlieu.ValueMember = "MaVL";
                }
                else
                {
                    data_cv_thungan.DataSource = table_cv;
                    tabControl.TabPages.Remove(tabPageQuanLy);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void data_cv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    DataGridViewRow row = new DataGridViewRow();
                    row = data_cv.Rows[e.RowIndex];
                    if (row != null)
                    {
                        txt_macv.Text = row.Cells[0].Value.ToString();
                        txt_noidungcv.Text = row.Cells[1].Value.ToString();
                        txt_tiencongcv.Text = row.Cells[2].Value.ToString();
                        cb_vlieu.Text= row.Cells[3].Value.ToString();
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
            string tiencv = txt_noidungcv.Text;
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
                txt_noidungcv.Text = "";
            }
        }

        private void txt_tienhh_Leave(object sender, EventArgs e)
        {
        }

        private void btn_themcv_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXECUTE THEM_CViec @mavl,@noidungcv,@tietcong,@vatlieu,@result output";
            SqlParameter maCVParam = new SqlParameter("@mavl", txt_macv.Text);
            maCVParam.SqlDbType = SqlDbType.Char;
            maCVParam.Size = 6;
            SqlParameter noiDungCVParam = new SqlParameter("@noidungcv", txt_noidungcv.Text);
            noiDungCVParam.SqlDbType = SqlDbType.NVarChar;
            noiDungCVParam.Size = 40;
            SqlParameter tienCongParam = new SqlParameter("@tietcong", txt_tiencongcv.Text);
            tienCongParam.SqlDbType = SqlDbType.Decimal;
            SqlParameter maVLParam = new SqlParameter("@vatlieu", cb_vlieu.SelectedValue.ToString());
            maVLParam.SqlDbType = SqlDbType.Char;
            maVLParam.Size = 6;
            SqlParameter resultParam = new SqlParameter("@result", 0);
            resultParam.SqlDbType = SqlDbType.Int;
            resultParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(maCVParam);
            cmd.Parameters.Add(noiDungCVParam);
            cmd.Parameters.Add(tienCongParam);
            cmd.Parameters.Add(maVLParam);
            cmd.Parameters.Add(resultParam);
            db.ExecuteCMD(cmd);
            int result = (int)cmd.Parameters["@result"].Value;
            if (result == 0)
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            Form_CongViec_Load(sender, e);
        }

        private void btn_suacv_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXECUTE SUA_CViec @macv,@noidungcv,@tietcong,@vatlieu,@result output";
            SqlParameter maCVParam = new SqlParameter("@macv", txt_macv.Text);
            maCVParam.SqlDbType = SqlDbType.Char;
            maCVParam.Size = 6;
            SqlParameter noiDungCVParam = new SqlParameter("@noidungcv", txt_noidungcv.Text);
            noiDungCVParam.SqlDbType = SqlDbType.NVarChar;
            noiDungCVParam.Size = 40;
            SqlParameter tienCongParam = new SqlParameter("@tietcong", txt_tiencongcv.Text);
            tienCongParam.SqlDbType = SqlDbType.Decimal;
            SqlParameter maVLParam = new SqlParameter("@vatlieu", cb_vlieu.SelectedValue.ToString());
            maVLParam.SqlDbType = SqlDbType.Char;
            maVLParam.Size = 6;
            SqlParameter resultParam = new SqlParameter("@result", 0);
            resultParam.SqlDbType = SqlDbType.Int;
            resultParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(maCVParam);
            cmd.Parameters.Add(noiDungCVParam);
            cmd.Parameters.Add(tienCongParam);
            cmd.Parameters.Add(maVLParam);
            cmd.Parameters.Add(resultParam);
            db.ExecuteCMD(cmd);
            int result = (int)cmd.Parameters["@result"].Value;
            if (result == 0)
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            Form_CongViec_Load(sender, e);
        }

        private void btn_xoacv_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXECUTE XOA_CViec @macv,@result output";
            SqlParameter maNVParam = new SqlParameter("@macv", txt_macv.Text);
            maNVParam.SqlDbType = SqlDbType.Char;
            maNVParam.Size = 6;
            SqlParameter resultParam = new SqlParameter("@result", 0);
            resultParam.SqlDbType = SqlDbType.Int;
            resultParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(resultParam);
            cmd.Parameters.Add(maNVParam);
            db.ExecuteCMD(cmd);
            int result = (int)cmd.Parameters["@result"].Value;
            if (result == 0)
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            Form_CongViec_Load(sender, e);
        }
    }
}
