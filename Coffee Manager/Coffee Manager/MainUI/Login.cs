using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public partial class Login : Form
    {
        User loginUser;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Login_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        string CheckUserType()
        {
            if (loginUser.IsStaff())
                return "Staff";
            return "Admin";
        }

        void SetLoginStatus(int number)
        {
            lbLoginStatus.Visible = true;
            if (number == 0)
                this.lbLoginStatus.Text = "Tài khoản không hợp lệ";
            if (number == -1)
                this.lbLoginStatus.Text = "Sai mật khẩu";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                loginUser = new User(this.txtUsername.Text, this.txtPassword.Text);
                int check = loginUser.CheckLogin();
                switch (check)
                {
                    case 1:
                        Dashboard dashboard = new Dashboard(this.CheckUserType(), this.txtUsername.Text);
                        dashboard.Show();
                        this.Hide();
                        break;
                    case 0:
                    case -1:
                        SetLoginStatus(check);
                        break;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode  == Keys.Tab)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}
