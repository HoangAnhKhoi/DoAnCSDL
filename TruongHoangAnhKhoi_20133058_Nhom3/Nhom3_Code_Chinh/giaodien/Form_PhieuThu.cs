using Spire.Doc;
using Spire.Doc.Documents;
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
    public partial class Form_PhieuThu : Form
    {
        private GarageDB gr = new GarageDB();
        private DataBase db = new DataBase();
        public Form_PhieuThu()
        {
            InitializeComponent();
        }

        private void btn_timpt_Click(object sender, EventArgs e)
        {
            string sohd = txt_mahd.Text;
            if (sohd == "")
                MessageBox.Show("Hãy điền sô hợp đồng", "Thông báo", MessageBoxButtons.OK);
            else
            {
                string query1 = "SoHD=" + sohd;
                DataTable tb1 = gr.LayBangDK(query1, gr.HD);
                if (tb1.Rows.Count == 0)
                    MessageBox.Show("Không tồn tại mã hợp đồng này", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    DataTable tb = gr.LayBangDK(query1, gr.PT);
                    txt_tienthieu.Text = (int.Parse(tb1.Rows[0][4].ToString()) - FillDataPT(tb)).ToString();
                }
            }
        }
        private int FillDataPT(DataTable list)
        {
            int tiendong = 0;
            data_phieuthu.Rows.Clear();
            for (int i = 0; i < list.Rows.Count; i++)
            {
                int index = data_phieuthu.Rows.Add();
                data_phieuthu.Rows[i].Cells[0].Value = list.Rows[i][0].ToString();
                data_phieuthu.Rows[i].Cells[1].Value = list.Rows[i][2].ToString();
                data_phieuthu.Rows[i].Cells[2].Value = list.Rows[i][3].ToString();
                data_phieuthu.Rows[i].Cells[3].Value = list.Rows[i][4].ToString();
                data_phieuthu.Rows[i].Cells[4].Value = list.Rows[i][5].ToString();
                data_phieuthu.Rows[i].Cells[5].Value = list.Rows[i][1].ToString();
                tiendong=tiendong+ int.Parse(list.Rows[i][5].ToString());
            }
            return tiendong;
        }
        private void txt_mahd_Leave(object sender, EventArgs e)
        {
            string sohd = txt_mahd.Text;
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
            {
                MessageBox.Show("Mục này không có chữ", "Thông báo", MessageBoxButtons.OK);
                txt_mahd.Text = "";
            }
        }

        private void data_phieuthu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_taopt_Click(object sender, EventArgs e)
        {
            string sopt = txt_sopt.Text;
            string mahd = txt_mahd.Text;
            string tienthu = txt_tienthu.Text;
            string hoten = txt_hoten.Text;
            if (sopt==""|| mahd==""||tienthu== ""||hoten=="")
                MessageBox.Show("Hãy điền đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            else
            {
                string query1 = "SoPT=" + sopt;
                DataTable tb = gr.LayBangDK(query1, gr.PT);
                if(tb.Rows.Count!=0)
                    MessageBox.Show("Mã phiếu thu đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    string query2 = "SoHD=" + mahd;
                    DataTable tb1 = gr.LayBangDK(query2, gr.HD);
                    if (tb1.Rows.Count == 0)
                        MessageBox.Show("Không tồn tại mã hợp đồng này", "Thông báo", MessageBoxButtons.OK);
                    else if (tb1.Rows[0][6].ToString() != "")
                    {
                        txt_hoten.Text = "";
                        txt_mahd.Text = "";
                        txt_sopt.Text = "";
                        txt_tienthu.Text = "";
                        MessageBox.Show("Hợp đồng này đã hoàn tất", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        btn_timpt_Click(sender, e);
                        if (int.Parse(txt_tienthu.Text) - (int.Parse(txt_tienthieu.Text)) > 0)
                            MessageBox.Show("Số tiền thu lớn hơn số tiền còn thiếu", "Thông báo", MessageBoxButtons.OK);
                        else
                        {
                            if (MessageBox.Show("Bạn chắc muốn tạo phiếu thu này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                string query3 = "insert into PHIEUTHU values(" + sopt + ",'" + DateTime.Now.ToString("dd-MM-yyyy") + "'," + mahd + ",'" + tb1.Rows[0][2].ToString() + "','" + hoten + "'," + tienthu + ")";
                                db.ExecuteNonQuery(query3);
                                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                            DataTable tb2 = gr.LayBangDK(query2, gr.PT);
                            txt_tienthieu.Text = (int.Parse(tb1.Rows[0][4].ToString()) - FillDataPT(tb2)).ToString();
                            if (int.Parse(txt_tienthieu.Text) == 0)
                            {
                                string query4 = "update HOPDONG set NgayNgThu='" + DateTime.Now.ToString("dd-MM-yyyy") + "' where SoHD=" + mahd;
                                db.ExecuteNonQuery(query4);
                                MessageBox.Show("Hợp đồng đã được thanh toán hoàn tất", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                    }
                }    
            }
        }

        private void txt_sopt_Leave(object sender, EventArgs e)
        {
            string sopt = txt_sopt.Text;
            bool a = true;
            foreach (int i in sopt)
            {
                if (i < 48 || i > 57)
                {
                    a = false;
                    break;
                }
            }
            if (a == false)
            {
                MessageBox.Show("Mục này không có chữ", "Thông báo", MessageBoxButtons.OK);
                txt_sopt.Text = "";
            }
        }

        private void txt_tienthu_Leave(object sender, EventArgs e)
        {
            string tienthu = txt_tienthu.Text;
            bool a = true;
            foreach (int i in tienthu)
            {
                if (i < 48 || i > 57)
                {
                    a = false;
                    break;
                }
            }
            if (a == false)
            {
                MessageBox.Show("Mục này không có chữ", "Thông báo", MessageBoxButtons.OK);
                txt_tienthu.Text = "";
            }
        }

        private void txt_sopt_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_sopt_Enter(object sender, EventArgs e)
        {
            DataTable tb = gr.LayBang(gr.PT);
            int i = 1;
            foreach (DataRow j in tb.Rows)
            {
                if (int.Parse(j["SoPT"].ToString()) == i)
                {
                    i++;
                }
                else
                {
                    txt_sopt.Text = i.ToString();
                    break;
                }
            }
            if(i==tb.Rows.Count+1)
                txt_sopt.Text = (i).ToString();
        }

        private void btn_xuatpt_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txt_mahd.Text;
                if (txt_tienthu.Text == "" || a == "" || txt_hoten.Text == "" || txt_sopt.Text == "")
                {
                    MessageBox.Show("Hãy điền đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    string query1 = "SoHD=" + txt_mahd.Text;
                    DataTable tb = gr.LayBangDK(query1, gr.HD);
                    Spire.Doc.Document doc = new Document();
                    string query = "MaKH='" + tb.Rows[0][2].ToString() + "'";
                    System.Data.DataTable KH = gr.LayBangDK(query, gr.KH);
                    Spire.Doc.Documents.Paragraph paragraph = doc.AddSection().AddParagraph();
                    Spire.Doc.Fields.TextRange text = paragraph.AppendText("Garage OWL");
                    text.CharacterFormat.Bold = true;
                    text.CharacterFormat.FontSize = 22;
                    paragraph.Format.TextAlignment = Spire.Doc.Documents.TextAlignment.Center;
                    paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    Spire.Doc.Documents.Paragraph paragraph2 = doc.Sections[0].AddParagraph();
                    Spire.Doc.Fields.TextRange text1 = paragraph2.AppendText("PHIẾU THU TIỀN HỢP ĐỒNG");
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
                    str[7] = "Tên người thanh toán: " + txt_hoten.Text;
                    str[8] = "";
                    str[9] = "THÔNG TIN PHIẾU THU";
                    str[10] = "";
                    str[11] = "Số phiếu thu: " + txt_sopt.Text;
                    str[12] = "Số hợp đồng: " + txt_mahd.Text;
                    str[13] = "Tiền thu: " + txt_tienthu.Text;
                    str[14] = "Tiền còn thiếu: " + txt_tienthieu.Text;
                    str[15] = "Tình trạng hợp đồng: ";
                    if (int.Parse(txt_tienthieu.Text) == 0)
                        str[15] = str[15] + "Đã hoàn thành";
                    else
                        str[15] = str[15] + "Chưa hoàn thành";
                    str[16] = "                                                                                          Ký tên người trả tiền";
                    int index1 = 0;
                    foreach (string i in str)
                    {
                        ghileft(ref doc, str[index1++]);
                        if (index1 > 17 - 3)
                            break;
                    }
                    ghiright(ref doc, str[index1++]);
                    ghiright(ref doc, str[index1]);

                    string tenhd = "PhieuThu-So" + txt_sopt.Text + ".doc";
                    doc.SaveToFile("D:/" + tenhd, Spire.Doc.FileFormat.Doc);
                    doc.Close();
                    MessageBox.Show("Xuất phiếu thu thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void data_phieuthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
