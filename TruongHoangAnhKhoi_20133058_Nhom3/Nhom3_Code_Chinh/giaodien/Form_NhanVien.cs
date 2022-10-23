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
    public partial class Form_NhanVien : Form
    {
        DataBase db = new DataBase();
        public Form_NhanVien()
        {
            InitializeComponent();
        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM  XUAT_NV()";
                DataTable table_nv = db.Execute(query);
                data_nv.DataSource = table_nv;
                string query1 = "SELECT * FROM  XUAT_CHUCVU()";
                DataTable table_chuVu=db.Execute(query1);
                cb_chucvu.DataSource = null;
                cb_chucvu.Items.Clear();
                cb_chucvu.DataSource = table_chuVu;
                cb_chucvu.DisplayMember = "TenCV";
                cb_chucvu.ValueMember = "MaCV";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillDataIntoGrid(DataTable list)
        {
            data_nv.Rows.Clear();
            for (int i = 0; i < list.Rows.Count; i++)
            {
                int index = data_nv.Rows.Add();
                data_nv.Rows[i].Cells[0].Value = list.Rows[i][0].ToString();
                data_nv.Rows[i].Cells[1].Value = list.Rows[i][1].ToString();
                data_nv.Rows[i].Cells[2].Value = list.Rows[i][2].ToString();
                data_nv.Rows[i].Cells[3].Value = list.Rows[i][3].ToString();
                data_nv.Rows[i].Cells[4].Value = list.Rows[i][4].ToString();
            }
        }
        private void FillComboxNhom(DataTable nhom)
        {
            //cb_nhom.DataSource = null;
            //cb_nhom.Items.Clear();
            //cb_nhom.DataSource = nhom;
            //cb_nhom.DisplayMember = "MaNhom";
            //cb_nhom.ValueMember = "MaNhom";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            GarageDB gr = new GarageDB();
            int gTinh = 0;
            if (rdn_nu.Checked == false)
                gTinh = 1;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EXECUTE THEM_NV @nguoiid,@hoten,@diachi,@dienthoai,@ngaysinh,@cccd,@gioitinnh,@macv,@luong,@result output";
            SqlParameter maNVParam = new SqlParameter("@nguoiid",txt_manv.Text);
            maNVParam.SqlDbType = SqlDbType.Char;
            maNVParam.Size = 6;
            SqlParameter hoTenParam = new SqlParameter("@hoten", txt_tennv.Text);
            hoTenParam.SqlDbType = SqlDbType.NVarChar;
            hoTenParam.Size = 30;
            SqlParameter diaChiParam = new SqlParameter("@diachi", txt_dchinv.Text);
            diaChiParam.SqlDbType = SqlDbType.NVarChar;
            diaChiParam.Size = 30;
            SqlParameter sdtParam = new SqlParameter("@dienthoai", txt_sdtnv.Text);
            sdtParam.SqlDbType = SqlDbType.Char;
            sdtParam.Size = 11;
            string ngaySinh = date_ngaysinh.Value.ToString("yyyy-MM-dd");
            SqlParameter ngaySinhParam = new SqlParameter("@ngaysinh", ngaySinh);
            ngaySinhParam.SqlDbType = SqlDbType.Date;
            SqlParameter cccdParam = new SqlParameter("@cccd", txt_cccdnv.Text);
            cccdParam.SqlDbType = SqlDbType.Char;
            cccdParam.Size = 11;
            SqlParameter gTinhParam = new SqlParameter("@gioitinnh", gTinh);
            gTinhParam.SqlDbType = SqlDbType.Bit;
            SqlParameter maChucVuParam = new SqlParameter("@macv", cb_chucvu.SelectedValue.ToString());
            maChucVuParam.SqlDbType = SqlDbType.Char;
            maChucVuParam.Size = 6;
            SqlParameter luongParam = new SqlParameter("@luong", txt_luong.Text);
            luongParam.SqlDbType = SqlDbType.Decimal;
            SqlParameter resultParam = new SqlParameter("@result", 0);
            resultParam.SqlDbType = SqlDbType.Int;
            resultParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(luongParam);
            cmd.Parameters.Add(maChucVuParam);
            cmd.Parameters.Add(maNVParam);
            cmd.Parameters.Add(hoTenParam);
            cmd.Parameters.Add(diaChiParam);
            cmd.Parameters.Add(sdtParam);
            cmd.Parameters.Add(ngaySinhParam);
            cmd.Parameters.Add(cccdParam);
            cmd.Parameters.Add(gTinhParam);
            cmd.Parameters.Add(resultParam);
            // int result = int.Parse(db.ExecuteCMD(cmd).Rows[0][0].ToString());
            db.ExecuteCMD(cmd);
            int result = (int)cmd.Parameters["@result"].Value;
            /*string query= "DECLARE @result as int EXECUTE THEM_NV '" + txt_manv.Text+"','"+txt_tennv.Text+"','"+txt_dchinv.Text+"','"+txt_sdtnv.Text+"','"+date_ngaysinh.Text+"','"
                                                +txt_cccdnv.Text+"',"+gTinh.ToString()+",'"+txt_macv.Text+"',"+txt_luong.Text+",@result output SELECT @result";
            db.Execute(query);
            DataTable d = db.Execute(query);
            int result = int.Parse(db.Execute(query).Rows[0][0].ToString());*/
            if (result==0)
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            Form_NhanVien_Load(sender,e);
            /*string ms = txt_matho.Text;
            string ten = txt_tentho.Text;
            string luong = txt_luong.Text;
            string nhom = cb_nhom.Text;
            if (ms == "" || ten == "" || luong == "")
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            else
            {
                string query1 = "MaTho = '" + ms + "'";
                if (gr.LayBangDK(query1, gr.THO).Rows.Count != 0)
                    MessageBox.Show("Mã số này đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    if (cb_nhom.FindStringExact(nhom) < 0 && rd_tvien.Checked == true)
                    {
                        MessageBox.Show("Nhóm này chưa có nhóm trưởng. Hãy thêm nhóm trưởng trước", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (cb_nhom.FindStringExact(nhom) > -1 && rd_truong.Checked == true)
                        {
                            if (MessageBox.Show("Nhóm này đã có nhóm trưởng. Bạn có muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                gr.insertTho(ms, ten, nhom, LayNhomTruong(nhom), luong);
                                updateNhomTruong(ms, nhom);
                            }
                        }
                        else if (cb_nhom.FindStringExact(nhom) < 0 && rd_truong.Checked == true)
                        {
                            gr.insertTho(ms, ten, nhom, ms, luong);
                            string query2 = "insert into NHOM values(" + nhom + ",'" + ms + "')";
                            db.ExecuteNonQuery(query2);
                        }
                        else
                        {
                            gr.insertTho(ms, ten, nhom, LayNhomTruong(nhom), luong);
                        }
                    }
                }
            }
            DataTable nhom1 = gr.LayBang(gr.NHOM);
            DataTable tho = gr.LayBang(gr.THO);
            FillComboxNhom(nhom1);
            FillDataIntoGrid(tho);*/
        }
        private string LayNhomTruong(string maNhom)
        {
            string query = "select NhomTruong from NHOM where MaNhom=" + maNhom;
            DataBase db = new DataBase();
            DataTable tb = db.Execute(query);
            return tb.Rows[0][0].ToString();
        }
        private void updateNhomTruong(string ms,string maNhom)
        {
            DataBase db = new DataBase();
            string query2 = "UPDATE NHOM set NhomTruong = '" + ms + "' where MaNhom=" + maNhom;
            string query3 = "UPDATE THO set NhomTruong='" + ms + "' where Nhom=" + maNhom;
            db.ExecuteNonQuery(query2);
            db.ExecuteNonQuery(query3);
        }

        private void btn_suanv_Click(object sender, EventArgs e)
        {
            /*DataBase db = new DataBase();
            GarageDB gr = new GarageDB();
            string ms = txt_matho.Text;
            string ten = txt_tentho.Text;
            string luong = txt_luong.Text;
            string nhom = cb_nhom.Text;
            if (ms == "" || ten == "" || luong == "")
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            else
            {
                string query1 = "MaTho = '" + ms + "'";
                if (gr.LayBangDK(query1, gr.THO).Rows.Count == 0)
                    MessageBox.Show("Mã số này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    string query2 = "MaTho= '" + ms + "'";
                    DataTable tb= gr.LayBangDK(query2, gr.THO);
                    if(String.Compare(tb.Rows[0][0].ToString(),tb.Rows[0][3].ToString(),false)==0)
                    {
                        if (rd_truong.Checked == true && String.Compare(tb.Rows[0][2].ToString(), nhom, false) == 0)
                        {
                            gr.updateTho(ms, ten, nhom, ms, luong);
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            string query4 = " Nhom = " + tb.Rows[0][2].ToString();
                            if (gr.LayBangDK(query4, gr.THO).Rows.Count == 1)
                            {
                                string query5 = "MaNhom=" + tb.Rows[0][2].ToString();
                                if (cb_nhom.FindStringExact(nhom) > -1 && rd_truong.Checked == true)
                                {
                                    if (MessageBox.Show("Nhóm này đã có nhóm trưởng. Bạn có muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        gr.updateTho(ms, ten, nhom, LayNhomTruong(nhom), luong);
                                        updateNhomTruong(ms, nhom);
                                        gr.deleteDK(query5, gr.NHOM);
                                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                                    }
                                }
                                else if (cb_nhom.FindStringExact(nhom) < 0 && rd_truong.Checked == true)
                                {
                                    gr.updateTho(ms, ten, nhom, ms, luong);
                                    string query3 = "insert into NHOM values(" + nhom + ",'" + ms + "')";
                                    db.ExecuteNonQuery(query3);
                                    gr.deleteDK(query5, gr.NHOM);
                                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    gr.updateTho(ms, ten, nhom, LayNhomTruong(nhom), luong);
                                    gr.deleteDK(query5, gr.NHOM);
                                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                                }
                            }
                            else
                                MessageBox.Show("Thợ đang là nhóm trưởng. Hãy cập nhật nhóm trưởng khác", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        if (cb_nhom.FindStringExact(nhom) < 0 && rd_tvien.Checked == true)
                        {
                            MessageBox.Show("Nhóm này chưa có nhóm trưởng. Hãy thêm nhóm trưởng trước", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (cb_nhom.FindStringExact(nhom) > -1 && rd_truong.Checked == true)
                            {
                                if (MessageBox.Show("Nhóm này đã có nhóm trưởng. Bạn có muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    gr.updateTho(ms, ten, nhom, LayNhomTruong(nhom), luong);
                                    updateNhomTruong(ms, nhom);
                                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                                }
                            }
                            else if (cb_nhom.FindStringExact(nhom) < 0 && rd_truong.Checked == true)
                            {
                                gr.updateTho(ms, ten, nhom, ms, luong);
                                string query3 = "insert into NHOM values(" + nhom + ",'" + ms + "')";
                                db.ExecuteNonQuery(query3);
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                            {
                                gr.updateTho(ms, ten, nhom, LayNhomTruong(nhom), luong);
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                    }    
                }
            }
             DataTable nhom1 = gr.LayBang(gr.NHOM);
            DataTable tho = gr.LayBang(gr.THO);
            FillComboxNhom(nhom1);
            FillDataIntoGrid(tho);*/
        }

        private void btn_xoanv_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            GarageDB gr = new GarageDB();
            /*string ms = txt_matho.Text;
            if (ms == "")
                MessageBox.Show("Hãy nhập mã thợ", "Thông báo", MessageBoxButtons.OK);
            else
            {
                string query1 = "MaTho = '" + ms + "'";
                DataTable tb = gr.LayBangDK(query1, gr.THO);
                if (tb.Rows.Count == 0)
                    MessageBox.Show("Mã số này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    string query5 = "MaTho='" + ms + "'";
                    DataTable a = gr.LayBangDK(query5, gr.CT);
                    if (a.Rows.Count != 0)
                    {
                        MessageBox.Show("Không thể xóa. Dữ liệu đang liên kết với bảng hợp đồng nào đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (String.Compare(tb.Rows[0][0].ToString(), tb.Rows[0][3].ToString(), false) == 0)
                        {
                            string query2 = "Nhom=" + tb.Rows[0][2].ToString();
                            if (gr.LayBangDK(query2, gr.THO).Rows.Count != 1)
                                MessageBox.Show("Thợ đang là nhóm trưởng. Hãy cập nhật nhóm trưởng trước.", "Thông báo", MessageBoxButtons.OK);
                            else
                            {
                                string query3 = "MaTho='" + ms + "'";
                                string query4 = "MaNhom=" + tb.Rows[0][2].ToString();
                                gr.deleteDK(query4, gr.NHOM);
                                gr.deleteDK(query3, gr.THO);
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            string query3 = "MaTho='" + ms + "'";
                            gr.deleteDK(query3, gr.THO);
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            DataTable nhom1 = gr.LayBang(gr.NHOM);
            DataTable tho = gr.LayBang(gr.THO);
            FillComboxNhom(nhom1);
            FillDataIntoGrid(tho);*/
        }

        private void data_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (data_nv.Rows.Count != 1)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = data_nv.Rows[e.RowIndex];
                    if (row != data_nv.Rows[data_nv.Rows.Count-1] && row!=null)
                    {
                        txt_manv.Text = row.Cells[0].Value.ToString();
                        txt_tennv.Text = row.Cells[1].Value.ToString();
                        txt_dchinv.Text = row.Cells[2].Value.ToString();
                        txt_sdtnv.Text = row.Cells[3].Value.ToString();
                        string[] arrListStr = row.Cells[4].Value.ToString().Split('/');
                        arrListStr[2]= arrListStr[2].Substring(0,4);
                        date_ngaysinh.Value = new DateTime(int.Parse(arrListStr[2]),int.Parse(arrListStr[1]),int.Parse(arrListStr[0]));
                        txt_cccdnv.Text = row.Cells[5].Value.ToString();
                        if (row.Cells[6].Value.ToString() == "False")
                            rdn_nu.Checked = true;
                        else
                            rbn_nam.Checked = true;
                        cb_chucvu.Text = row.Cells[7].Value.ToString();
                        txt_luong.Text = row.Cells[8].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_luong_Leave(object sender, EventArgs e)
        {
            /*bool a = true;
            GarageDB gr = new GarageDB();
            string luong = txt_luong.Text;
            foreach (int i in luong)
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
                txt_luong.Text = "";
            }*/
        }
    }
}
