using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Document = Spire.Doc.Document;

namespace giaodien
{
    public partial class Form_ChinhSuaHD : Form
    {
        private System.Data.DataTable tb_cv = new System.Data.DataTable();
        private System.Data.DataTable CV = new System.Data.DataTable();
        public Form_ChinhSuaHD()
        {
            InitializeComponent();
        }

        private void Form_ChinhSuaHD_Load(object sender, EventArgs e)
        {
            DataColumn column3 = new DataColumn("MaCV");
            column3.DataType = typeof(string);
            tb_cv.Columns.Add(column3);
            DataColumn column4 = new DataColumn("TenCV");
            column4.DataType = typeof(string);
            tb_cv.Columns.Add(column4);
            DataColumn column1 = new DataColumn("MaTho");
            column1.DataType = typeof(string);
            tb_cv.Columns.Add(column1);
            DataColumn column2 = new DataColumn("TenTho");
            column2.DataType = typeof(string);
            tb_cv.Columns.Add(column2);
            DataColumn column5 = new DataColumn("TienCong");
            column5.DataType = typeof(string);
            tb_cv.Columns.Add(column5);
            DataColumn column6 = new DataColumn("KhoanTho");
            column6.DataType = typeof(string);
            tb_cv.Columns.Add(column6);
            data_hopdong.Rows[0].Cells[1].Value = DateTime.Now.ToString("dd-MM-yyyy");
            date_ngayhd.Value= DateTime.Now;
            try
            {
                GarageDB db = new GarageDB();
                System.Data.DataTable KH = db.LayBang(db.KH);
                CV=db.LayBang(db.CV);
                System.Data.DataTable THO = db.LayBang(db.THO);
                FillComBoKH(KH);
                FillComBoCV(CV);
                FillComBoTHO(THO);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillComBoKH(System.Data.DataTable list)
        {
            cb_makh.DataSource = null;
            cb_makh.Items.Clear();
            cb_makh.DataSource = list;
            cb_makh.DisplayMember = "MaKH";
            cb_makh.ValueMember = "MaKH";
        }
        private void FillComBoCV(System.Data.DataTable list)
        {
            cb_cviec.DataSource = null;
            cb_cviec.Items.Clear();
            cb_cviec.DataSource = list;
            cb_cviec.DisplayMember = "NoiDungCV";
            cb_cviec.ValueMember = "MaCV";
        }
        private void FillComBoTHO(System.Data.DataTable list)
        {
            cb_thochinh.DataSource = null;
            cb_thochinh.Items.Clear();
            cb_thochinh.DataSource = list;
            cb_thochinh.DisplayMember = "TenTho";
            cb_thochinh.ValueMember = "MaTho";
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (data_hopdong.Rows[0].Cells[0].Value == null || data_hopdong.Rows[0].Cells[1].Value == null || data_hopdong.Rows[0].Cells[2].Value == null || data_hopdong.Rows[0].Cells[3].Value == null || data_hopdong.Rows[0].Cells[4].Value == null || data_cvhopdong.Rows[0].Cells[0].Value==null)
                MessageBox.Show("Hãy điền đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            else
            {
                GarageDB gr = new GarageDB();
                string query = "MaKH='" + cb_makh.Text + "'";
                System.Data.DataTable KH = gr.LayBangDK(query, gr.KH);
                Spire.Doc.Document doc = new Document();

                Spire.Doc.Documents.Paragraph paragraph = doc.AddSection().AddParagraph();
                Spire.Doc.Fields.TextRange text = paragraph.AppendText("Garage OWL");
                text.CharacterFormat.Bold = true;
                text.CharacterFormat.FontSize = 22;
                paragraph.Format.TextAlignment = TextAlignment.Center;
                paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                Spire.Doc.Documents.Paragraph paragraph2 = doc.Sections[0].AddParagraph();
                Spire.Doc.Fields.TextRange text1 = paragraph2.AppendText("HỢP ĐỒNG SỮA XE");
                text1.CharacterFormat.Bold = true;
                text1.CharacterFormat.FontSize = 20;
                paragraph2.Format.TextAlignment = TextAlignment.Center;
                paragraph2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                string[] str = new string[50];
                str[0] = "";
                str[1] = "THÔNG TIN KHÁCH HÀNG";
                str[2] = "";
                str[3] = "Tên khách hàng: " + KH.Rows[0][1].ToString();
                str[4] = "Mã khách hàng: " + KH.Rows[0][0].ToString();
                str[5] = "Số điện thoại: " + KH.Rows[0][3].ToString();
                str[6] = "Địa chỉ: " + KH.Rows[0][2].ToString();
                str[7] = "";
                str[8] = "THÔNG TIN HỢP ĐỒNG";
                str[9] = "";
                str[10] = "Số hợp đồng: " + txt_sohd.Text;
                str[11] = "Số xe: " + txt_soxe.Text;
                str[12] = "Ngày lập hợp đồng: " + date_ngayhd.Value.ToString("dd/MM/yyyy");
                str[13] = "Ngày giao dự kiện: " + date_ngaygiaohd.Value.ToString("dd/MM/yyyy");
                str[14] = "";
                str[15] = "CÔNG VIỆC YÊU CẦU";
                str[16] = "";
                Form1 a = new Form1();
                int index = 17;
                int triGiaHD = 0;
                foreach (DataRow i in tb_cv.Rows)
                {
                    str[index++] = i["TenCV"].ToString() + " - " + i["TienCong"].ToString() + "VND" + " - " + i["TenTho"].ToString();
                    triGiaHD = triGiaHD + int.Parse(i["TienCong"].ToString());
                }
                str[index++] = "Tổng giá trị hợp đồng: " + triGiaHD.ToString();
                str[index++] = "                                                                                                                Ký tên";
                int index1 = 0;
                foreach (string i in str)
                {
                    ghileft(ref doc, str[index1++]);
                    if (index1 > index - 3)
                        break;
                }
                ghiright(ref doc, str[index1++]);
                ghileft(ref doc, str[index1]);
                string tenhd = "HopDong-So" + txt_sohd.Text + ".doc";
                doc.SaveToFile("D:/" + tenhd, Spire.Doc.FileFormat.Doc);
                doc.Close();
                MessageBox.Show("Xuất hợp đồng thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void ghileft(ref Spire.Doc.Document doc, string str)
        {
            Spire.Doc.Documents.Paragraph paragraph = doc.Sections[0].AddParagraph();
            Spire.Doc.Fields.TextRange text = paragraph.AppendText(str);
            text.CharacterFormat.Bold = false;
            text.CharacterFormat.FontSize = 14;
            paragraph.Format.TextAlignment = TextAlignment.Center;
            paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;
        }
        private void ghiright(ref Spire.Doc.Document doc, string str)
        {
            Spire.Doc.Documents.Paragraph paragraph = doc.Sections[0].AddParagraph();
            Spire.Doc.Fields.TextRange text = paragraph.AppendText(str);
            text.CharacterFormat.Bold = false;
            text.CharacterFormat.FontSize = 14;
            paragraph.Format.TextAlignment = TextAlignment.Auto;
            paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;
        }
        private void txt_sohd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_soxe_TextChanged(object sender, EventArgs e)
        {
            data_hopdong.Rows[0].Cells[3].Value = txt_soxe.Text;
        }

        private void cb_makh_SelectedIndexChanged(object sender, EventArgs e)
        {
            data_hopdong.Rows[0].Cells[2].Value = cb_makh.Text;
        }

        private void date_ngaygiaohd_ValueChanged(object sender, EventArgs e)
        {
            data_hopdong.Rows[0].Cells[4].Value = date_ngaygiaohd.Value.ToString("dd/MM/yyyy");
        }

        private void date_ngayhd_ValueChanged(object sender, EventArgs e)
        {
            data_hopdong.Rows[0].Cells[1].Value = date_ngayhd.Value.ToString("dd/MM/yyyy");
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (data_hopdong.Rows[0].Cells[0].Value == null || data_hopdong.Rows[0].Cells[1].Value == null || data_hopdong.Rows[0].Cells[2].Value == null || data_hopdong.Rows[0].Cells[3].Value == null || data_hopdong.Rows[0].Cells[4].Value == null || data_cvhopdong.Rows[0].Cells[0].Value == null)
                MessageBox.Show("Hãy điền đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (MessageBox.Show("Bạn có muốn tạo hợp đồng này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int TriGiaHD = 0;
                    foreach (DataRow i in tb_cv.Rows)
                    {
                        TriGiaHD = TriGiaHD + int.Parse(i["TienCong"].ToString());
                    }
                    DataBase db = new DataBase();
                    string query1 = "insert into HOPDONG values(" + txt_sohd.Text + ",'" + date_ngayhd.Value.Year.ToString() + "-" + date_ngayhd.Value.Month.ToString() + "-" + date_ngayhd.Value.Day.ToString() + "','" + cb_makh.Text + "','" + txt_soxe.Text + "'," + TriGiaHD.ToString() + ",'" + date_ngaygiaohd.Value.Year.ToString() + "-" + date_ngaygiaohd.Value.Month.ToString() + "-" + date_ngaygiaohd.Value.Day.ToString() + "'" + ",NULL)";
                    db.ExecuteNonQuery(query1);
                    foreach (DataRow i in tb_cv.Rows)
                    {
                        string query2 = "insert into CHITIET_HD values(" + txt_sohd.Text + ",'" + i["MaCV"].ToString() + "'," + i["TienCong"].ToString() + ",'" + i["MaTho"].ToString() + "'," + i["KhoanTho"] + ")";
                        db.ExecuteNonQuery(query2);
                    }
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_themcv_Click(object sender, EventArgs e)
        {
            bool a = true;
            string macv = cb_cviec.SelectedValue.ToString();
            string tencv = cb_cviec.Text;
            string matho = cb_thochinh.SelectedValue.ToString();
            string tentho = cb_thochinh.Text;
            string TienCong = "";
            string khoanTho = "";
            foreach(DataRow i in CV.Rows)
            {
                if(i["MaCV"].ToString()==macv)
                {
                    TienCong = i["TienCong"].ToString();
                    khoanTho = i["TienHH"].ToString();
                }    
            }    
            for (int i = 0; i < tb_cv.Rows.Count; i++)
            {
                if (macv == tb_cv.Rows[i][0].ToString())
                {
                    a = false;
                    break;
                }
            }
            if (a == false)
                MessageBox.Show("Công việc đã có trong hợp đồng", "Thông báo", MessageBoxButtons.OK);
            else
            {
                DataRow row = tb_cv.NewRow();
                row["MaCV"] = macv;
                row["TenCV"] = tencv;
                row["MaTho"] = matho;
                row["TenTho"] = tentho;
                row["TienCong"] = TienCong;
                row["KhoanTho"] = khoanTho;
                tb_cv.Rows.Add(row);
            }
            FillDataCV(tb_cv);
        }
        private void FillDataCV(System.Data.DataTable list)
        {
            data_cvhopdong.Rows.Clear();
            for (int i = 0; i < list.Rows.Count; i++)
            {
                int index = data_cvhopdong.Rows.Add();
                data_cvhopdong.Rows[i].Cells[1].Value = list.Rows[i][1].ToString();
                data_cvhopdong.Rows[i].Cells[0].Value = list.Rows[i][3].ToString();
            }
        }

        private void btn_xoacv_Click(object sender, EventArgs e)
        {
            string macv = cb_cviec.SelectedValue.ToString();
            string tencv = cb_cviec.Text;
            foreach(DataRow i in tb_cv.Rows)
            {
                if (i["MaCV"].ToString() == macv)
                {
                    i.Delete();
                    break;
                }
            }    
            FillDataCV(tb_cv);
        }

        private void data_cvhopdong_Click(object sender, EventArgs e)
        {
        }

        private void data_cvhopdong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    DataGridViewRow row = new DataGridViewRow();
                    row = data_cvhopdong.Rows[e.RowIndex];
                    if (row != null && row!=data_cvhopdong.Rows[data_cvhopdong.Rows.Count-1])
                    {
                        cb_cviec.Text = row.Cells[1].Value.ToString();
                        cb_thochinh.Text = row.Cells[0].Value.ToString();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_sohd_Leave(object sender, EventArgs e)
        {
            GarageDB gr = new GarageDB();
            string sohd = txt_sohd.Text;
            bool a = true;
            foreach (int i in sohd)
            {
                if (i < 48 || i > 57)
                {
                    a = false;
                    break;
                }
            }
            if (a == false)
                MessageBox.Show("Mã hợp đồng không có chữ", "Thông báo", MessageBoxButtons.OK);
            else
            {
                string query = "SoHD='" + sohd + "'";
                System.Data.DataTable tb = gr.LayBangDK(query, gr.HD);
                if (tb.Rows.Count != 0)
                {
                    MessageBox.Show("Mã hợp đồng đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    txt_sohd.Text = "";
                }
                else
                    data_hopdong.Rows[0].Cells[0].Value = txt_sohd.Text;
            }
        }

        private void txt_sohd_Enter(object sender, EventArgs e)
        {
            GarageDB gr = new GarageDB();
            System.Data.DataTable tb = gr.LayBang(gr.HD);
            int i = 1;
            foreach (DataRow j in tb.Rows)
            {
                if (int.Parse(j["SoHD"].ToString()) == i)
                {
                    i++;
                }
                else
                {
                    txt_sohd.Text = i.ToString();
                    break;
                }
            }
            if (i == tb.Rows.Count + 1)
                txt_sohd.Text = (i).ToString();
        }

        private void cb_makh_Leave(object sender, EventArgs e)
        {
            string query = "MaKH='" + cb_makh.Text + "'";
            GarageDB gr = new GarageDB();
            if (gr.LayBangDK(query, gr.KH).Rows.Count == 0)
            {
                MessageBox.Show("Mã số khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK);
                cb_makh.Text = "";
                data_hopdong.Rows[0].Cells[2].Value = "";
            }
        }
    }
}
