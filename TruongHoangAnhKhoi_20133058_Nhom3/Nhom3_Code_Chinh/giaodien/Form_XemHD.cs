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
    public partial class Form_XemHD : Form
    {
        public Form_XemHD()
        {
            InitializeComponent();
        }

        private void txt_mahd_Enter(object sender, EventArgs e)
        {
            if(txt_mahd.Text=="Nhập mã hợp đồng")
            {
                txt_mahd.Text = "";
                txt_mahd.ForeColor = Color.Silver;
            }    
        }

        private void txt_mahd_Leave(object sender, EventArgs e)
        {
            if (txt_mahd.Text == "")
            {
                txt_mahd.Text = "Nhập mã hợp đồng";
                txt_mahd.ForeColor = Color.Silver;
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                GarageDB gr = new GarageDB();
                string mahd = txt_mahd.Text;
                if (mahd == "Nhập mã hợp đồng")
                {
                    MessageBox.Show("Hãy nhập mã hợp đồng", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    data_infoHD.Rows.Clear();
                    string query1 = "SoHD=" + mahd;
                    DataTable tb = gr.LayBangDK(query1, gr.HD);
                    if (tb.Rows.Count == 0)
                        MessageBox.Show("Mã hợp đồng không tồn tại", "Thông báo", MessageBoxButtons.OK);
                    else
                    {
                        data_infoHD.Rows[0].Cells[0].Value = tb.Rows[0][0].ToString();
                        data_infoHD.Rows[0].Cells[1].Value = tb.Rows[0][1].ToString();
                        data_infoHD.Rows[0].Cells[2].Value = tb.Rows[0][2].ToString();
                        data_infoHD.Rows[0].Cells[3].Value = tb.Rows[0][3].ToString();
                        data_infoHD.Rows[0].Cells[4].Value = tb.Rows[0][4].ToString();
                        data_infoHD.Rows[0].Cells[5].Value = tb.Rows[0][5].ToString();
                        if (tb.Rows[0][6].ToString() != null)
                            data_infoHD.Rows[0].Cells[6].Value = tb.Rows[0][6].ToString();
                        else
                            data_infoHD.Rows[0].Cells[6].Value = "Chưa giao xe";
                        string query2 = "SoHD=" + mahd;
                        DataTable tb1 = gr.LayBangDK(query2, gr.CT);
                        FillDataIntoGrid(tb1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillDataIntoGrid(DataTable list)
        {
            data_chitietHD.Rows.Clear();
            for (int i = 0; i < list.Rows.Count; i++)
            {
                int index = data_chitietHD.Rows.Add();
                data_chitietHD.Rows[i].Cells[0].Value = list.Rows[i][0].ToString();
                data_chitietHD.Rows[i].Cells[1].Value = list.Rows[i][1].ToString();
                data_chitietHD.Rows[i].Cells[2].Value = list.Rows[i][2].ToString();
                data_chitietHD.Rows[i].Cells[3].Value = list.Rows[i][3].ToString();
                data_chitietHD.Rows[i].Cells[4].Value = list.Rows[i][4].ToString();
            }
        }

        private void Form_XemHD_Load(object sender, EventArgs e)
        {

        }
    }
}
