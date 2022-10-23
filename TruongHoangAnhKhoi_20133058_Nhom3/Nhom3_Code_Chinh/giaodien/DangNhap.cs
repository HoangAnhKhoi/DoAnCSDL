using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace giaodien
{
    public partial class Form1 : Form
    {
        public string chucVuUser;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot_password form4 = new Forgot_password();
            form4.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up form2 = new Sign_up();
            form2.ShowDialog();
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            if (rbn_quanly.Checked == true)
                chucVuUser = rbn_quanly.Text;
            else
                chucVuUser = rbn_thungan.Text;
            string query = "SELECT dbo.XACMINH_USERS('"+txt_nameacc.Text+"','"+txt_pass.Text+"',N'"+chucVuUser+"')";
            DataTable b = db.Execute(query);
            int result = int.Parse(b.Rows[0][0].ToString());
            if (result == 0)
            {
                this.Hide();
                Form_Chinh form3 = new Form_Chinh();
                form3.ShowDialog();
                this.Close();
            }
            else if (result == 1)
                MessageBox.Show("Mật khẩu sai", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Không có tên đăng nhập này", "Thông báo", MessageBoxButtons.OK);
            txt_nameacc.Text = chucVuUser;
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_show.Checked == true)
                txt_pass.UseSystemPasswordChar = false;
            else
                txt_pass.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
