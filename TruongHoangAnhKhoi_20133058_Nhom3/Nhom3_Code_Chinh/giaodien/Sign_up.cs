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
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void HoTen_txt_Leave(object sender, EventArgs e)
        {
            if (HoTen_txt.Text == "")
            {
                HoTen_txt.Text = "Họ tên";
                HoTen_txt.ForeColor = Color.Silver;
            }
        }

        private void HoTen_txt_Enter(object sender, EventArgs e)
        {
            if (HoTen_txt.Text == "Họ tên")
            {
                HoTen_txt.Text = "";
                HoTen_txt.ForeColor = Color.Black;
            }
        }

        private void ChucVu_txt_Enter(object sender, EventArgs e)
        {
            if (ChucVu_txt.Text == "Chức vụ")
            {
                ChucVu_txt.Text = "";
                ChucVu_txt.ForeColor = Color.Black;
            }
        }

        private void ChucVu_txt_Leave(object sender, EventArgs e)
        {
            if (ChucVu_txt.Text == "")
            {
                ChucVu_txt.Text = "Chức vụ";
                ChucVu_txt.ForeColor = Color.Silver;
            }
        }

        private void ĐNhap_txt_Enter(object sender, EventArgs e)
        {
            if (ĐNhap_txt.Text == "Tên đăng nhập")
            {
                ĐNhap_txt.Text = "";
                ĐNhap_txt.ForeColor = Color.Black;
            }
        }

        private void ĐNhap_txt_Leave(object sender, EventArgs e)
        {
            if (ĐNhap_txt.Text == "")
            {
                ĐNhap_txt.Text = "Tên đăng nhập";
                ĐNhap_txt.ForeColor = Color.Silver;
            }
        }

        private void MKhau_txt_Enter(object sender, EventArgs e)
        {
            if (MKhau_txt.Text == "Mật khẩu")
            {
                MKhau_txt.Text = "";
                MKhau_txt.UseSystemPasswordChar = true;
                MKhau_txt.ForeColor = Color.Black;
            }
        }

        private void MKhau_txt_Leave(object sender, EventArgs e)
        {
            if (MKhau_txt.Text == "")
            {
                MKhau_txt.UseSystemPasswordChar = false;
                MKhau_txt.Text = "Mật khẩu";
                MKhau_txt.ForeColor = Color.Silver;
            }
        }

        private void MaQL_txt_Enter(object sender, EventArgs e)
        {
            if (MaQL_txt.Text == "Mã quản lý")
            {
                MaQL_txt.Text = "";
                MaQL_txt.ForeColor = Color.Black;
            }
        }

        private void MaQL_txt_Leave(object sender, EventArgs e)
        {
            if (MaQL_txt.Text == "")
            {
                MaQL_txt.Text = "Mã quản lý";
                MaQL_txt.ForeColor = Color.Silver;
            }
        }

        private void Mkhau2_txt_Enter(object sender, EventArgs e)
        {
            if (Mkhau2_txt.Text == "Nhập lại mật khẩu")
            {
                Mkhau2_txt.UseSystemPasswordChar = true;
                Mkhau2_txt.Text = "";
                Mkhau2_txt.ForeColor = Color.Black;
            }
        }

        private void Mkhau2_txt_Leave(object sender, EventArgs e)
        {
            if (Mkhau2_txt.Text == "")
            {
                Mkhau2_txt.UseSystemPasswordChar = false;
                Mkhau2_txt.Text = "Nhập lại mật khẩu";
                Mkhau2_txt.ForeColor = Color.Silver;
            }
        }

        private void SingUp_btn_Click(object sender, EventArgs e)
        {
            if (HoTen_txt.Text == "Họ tên" || ChucVu_txt.Text == "Chức vụ" || ĐNhap_txt.Text == "Tên đăng nhập" || MKhau_txt.Text == "Mật khẩu" || MaQL_txt.Text == "Mã quản lý")
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MaQL_txt.Text != "123456")
                    MessageBox.Show("Mã quản lý không đúng", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    DataBase db = new DataBase();
                    string str = "select * from DangNhap where acc='" + ĐNhap_txt.Text + "'";
                    DataTable tb = db.Execute(str);
                    if (tb.Rows.Count != 0)
                        MessageBox.Show("Tên đăng nhập này đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    else
                    {
                        if (String.Compare(Mkhau2_txt.Text.ToString(), MKhau_txt.Text.ToString(), false) == 0)
                        {
                            MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                            GarageDB gr = new GarageDB();
                            string ten = db.ChuanTen(HoTen_txt.Text);
                            string chucvu = db.ChuanTen(ChucVu_txt.Text);
                            gr.insertAcc(ĐNhap_txt.Text, MKhau_txt.Text, ten, chucvu);
                            this.Hide();
                            Form1 a = new Form1();
                            a.ShowDialog();
                        }
                        else
                            MessageBox.Show("Mật khẩu không giống nhau", "Thông báo", MessageBoxButtons.OK);
                    }


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
