﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public partial class ForgotPass : Form
    {
        LoginForm parent;
        EmailVerify Email;
        Connect connect = new Connect();
        MD5Encoder encoder = new MD5Encoder();
        public ForgotPass(LoginForm parent)
        {
            this.parent = parent;
            InitializeComponent();
           // int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            //style |= NativeWinAPI.WS_EX_COMPOSITED;
           // NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);

           // SetColor(Properties.Settings.Default.Color);
        }
        private int CheckPassword()
        {
            if (tbNewPass1.Text.Length < 8) return 2;
            if (tbNewPass1.Text != tbNewPass2.Text) return 3;
            return 1;
        }
        private int CheckCode()
        {
            if (this.Email.GetCode != tbVerifyCode.Text)
                return 0;
            else return 1;
        }
        private int CheckEmail()
        {
            if (!(tbEmail.Text.Contains("@")))
                return 0;
            return 1;
        }
        #region EventHandler
        private void bSend_Click(object sender, EventArgs e)
        {
            try
            {
                USER temp = new USER();
                temp.Email = this.tbEmail.Text;
                if (CheckEmail() == 0)
                {
                    lInvalid.Show();
                }
                else if (temp.CheckEmail() == 1)
                {
                    this.Email = new EmailVerify(tbEmail.Text);
                    this.Email.GetRandomCode();
                    this.Email.SendMail();
                    lSent.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
        }
        private void bChange_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                if (CheckPassword() == 1 && CheckCode() == 1)
                {
                    string newPass = encoder.FromString(tbNewPass1.Text);
                    string Query = "UPDATE USER SET PASS='" + newPass + "' WHERE EMAIL='" + tbEmail.Text + "'";
                    this.connect.OpenConnection();
                    SqlCommand cmd = this.connect.CreateSQLCmd(Query);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                ReportError rp = new ReportError(this, ex);
                rp.Show();
            }
            finally
            {
                connect.CloseConnection();
            }

        }
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
        private void tbNewPass1_OnValueChanged(object sender, EventArgs e)
        {
            tbNewPass1.isPassword = true;
        }
        private void tbNewPass2_OnValueChanged(object sender, EventArgs e)
        {
            tbNewPass2.isPassword = true;
        }
        #endregion
        void SetColor(Color x)
        {
            GradientPanelForgotPasswd.BackColor = GradientPanelForgotPasswd.GradientTopLeft = GradientPanelForgotPasswd.GradientTopRight =
                GradientPanelForgotPasswd.GradientBottomLeft = GradientPanelForgotPasswd.GradientBottomRight =

                tbEmail.LineFocusedColor = tbEmail.LineMouseHoverColor =
                tbVerifyCode.LineMouseHoverColor = tbVerifyCode.LineFocusedColor =
                tbNewPass1.LineFocusedColor = tbNewPass1.LineMouseHoverColor =
                tbNewPass2.LineFocusedColor = tbNewPass2.LineMouseHoverColor =

                 bChange.ActiveFillColor = bChange.ForeColor = bChange.IdleLineColor = bChange.IdleForecolor = bChange.ActiveLineColor =

                  bSend.ActiveFillColor = bSend.ForeColor = bSend.IdleLineColor = bSend.IdleForecolor = bSend.ActiveLineColor =

                   bExit.ActiveFillColor = bExit.ForeColor = bExit.IdleLineColor = bExit.IdleForecolor = bExit.ActiveLineColor = x;
        }

        
    }
}
