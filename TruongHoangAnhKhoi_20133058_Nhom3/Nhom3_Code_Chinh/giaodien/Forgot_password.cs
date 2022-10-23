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
    public partial class Forgot_password : Form
    {
        public Forgot_password()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Forgot_password_Load(object sender, EventArgs e)
        {
            txt_FMKhau2.Hide();
            txt_FMKhau.Hide();
            btn_accept.Hide();
        }

        private void txt_FAcc_Enter(object sender, EventArgs e)
        {
            if (txt_FAcc.Text == "Tên đăng nhập")
            {
                txt_FAcc.Text = "";
                txt_FAcc.ForeColor = Color.White;
            }
        }

        private void txt_FAcc_Leave(object sender, EventArgs e)
        {
            if (txt_FAcc.Text == "")
            {
                txt_FAcc.Text = "Tên đăng nhập";
                txt_FAcc.ForeColor = Color.Silver;
            }
        }

        private void txt_FHoTen_Enter(object sender, EventArgs e)
        {
            if (txt_FHoTen.Text == "Họ và tên")
            {
                txt_FHoTen.Text = "";
                txt_FHoTen.ForeColor = Color.White;
            }
        }

        private void txt_FHoTen_Leave(object sender, EventArgs e)
        {
            if (txt_FHoTen.Text == "")
            {
                txt_FHoTen.Text = "Họ và tên";
                txt_FHoTen.ForeColor = Color.Silver;
            }
        }

        private void txt_FMaQL_Enter(object sender, EventArgs e)
        {
            if (txt_FMaQL.Text == "Mã quản lý")
            {
                txt_FMaQL.Text = "";
                txt_FMaQL.ForeColor = Color.White;
            }
        }

        private void txt_FMaQL_Leave(object sender, EventArgs e)
        {
            if (txt_FMaQL.Text == "")
            {
                txt_FMaQL.Text = "Mã quản lý";
                txt_FMaQL.ForeColor = Color.Silver;
            }
        }

        private void txt_FMKhau_Enter(object sender, EventArgs e)
        {
            if (txt_FMKhau.Text == "Mật khẩu mới")
            {
                txt_FMKhau.Text = "";
                txt_FMKhau.ForeColor = Color.White;
            }
        }

        private void txt_FMKhau_Leave(object sender, EventArgs e)
        {
            if (txt_FMKhau.Text == "")
            {
                txt_FMKhau.Text = "Mật khẩu mới";
                txt_FMKhau.ForeColor = Color.Silver;
            }
        }

        private void txt_FMKhau2_Enter(object sender, EventArgs e)
        {
            if (txt_FMKhau2.Text == "Nhập lại mật khẩu")
            {
                txt_FMKhau2.Text = "";
                txt_FMKhau2.ForeColor = Color.White;
            }
        }

        private void txt_FMKhau2_Leave(object sender, EventArgs e)
        {
            if (txt_FMKhau2.Text == "")
            {
                txt_FMKhau2.Text = "Nhập lại mật khẩu";
                txt_FMKhau2.ForeColor = Color.Silver;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.ShowDialog();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (String.Compare(txt_FMKhau.Text, txt_FMKhau2.Text, false) == 0)
            {
                DataBase db = new DataBase();
                string str = "Update DANGNHAP set pass='" + txt_FMKhau.Text + "' where acc='" + txt_FAcc.Text + "'";
                db.ExecuteNonQuery(str);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                this.Hide();
                Form1 a = new Form1();
                a.ShowDialog();
            }
            else
                MessageBox.Show("Mật khẩu không giống nhau", "Thông báo", MessageBoxButtons.OK);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_FMaQL.Text == "Mã quản lý" || txt_FHoTen.Text == "Họ và tên" || txt_FAcc.Text == "Tên tài khoản")
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (txt_FMaQL.Text != "123456")
                    MessageBox.Show("Mã quản lý không đúng", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    DataBase db = new DataBase();
                    GarageDB gr = new GarageDB();
                    string str = "select * from DANGNHAP where acc='" + txt_FAcc.Text + "'";
                    DataTable tb = db.Execute(str);
                    if (tb.Rows.Count == 1)
                    {
                        string str1 = "HoTen='" + txt_FHoTen.Text +"' and acc='" + txt_FAcc.Text + "'";
                        if (gr.LayBangDK(str1,gr.DN).Rows.Count==1)
                        {
                            txt_FMKhau.Show();
                            txt_FMKhau2.Show();
                            txt_FAcc.Hide();
                            txt_FHoTen.Hide();
                            txt_FMaQL.Hide();
                            btn_accept.Show();
                            btn_search.Hide();
                        }
                        else
                            MessageBox.Show("Họ tên của tên đăng nhập không đúng", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Tên đăng nhập không tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.ShowDialog();
        }
    }
}
