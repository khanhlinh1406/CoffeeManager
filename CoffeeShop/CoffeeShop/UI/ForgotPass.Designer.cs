
namespace CoffeeShop
{
    partial class ForgotPass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.GradientPanelForgotPasswd = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbForgotPass = new System.Windows.Forms.Label();
            this.lSent = new System.Windows.Forms.Label();
            this.bSend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lCodeWrong = new System.Windows.Forms.Label();
            this.tbVerifyCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbNewPass2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bChange = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lInvalid = new System.Windows.Forms.Label();
            this.lConfirmWrong = new System.Windows.Forms.Label();
            this.lShortPass = new System.Windows.Forms.Label();
            this.tbNewPass1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.GradientPanelForgotPasswd.SuspendLayout();
            this.SuspendLayout();
            // 
            // GradientPanelForgotPasswd
            // 
            this.GradientPanelForgotPasswd.BackColor = System.Drawing.SystemColors.Highlight;
            this.GradientPanelForgotPasswd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GradientPanelForgotPasswd.BackgroundImage")));
            this.GradientPanelForgotPasswd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GradientPanelForgotPasswd.Controls.Add(this.lbForgotPass);
            this.GradientPanelForgotPasswd.Dock = System.Windows.Forms.DockStyle.Left;
            this.GradientPanelForgotPasswd.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelForgotPasswd.GradientBottomRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelForgotPasswd.GradientTopLeft = System.Drawing.SystemColors.Highlight;
            this.GradientPanelForgotPasswd.GradientTopRight = System.Drawing.SystemColors.Highlight;
            this.GradientPanelForgotPasswd.Location = new System.Drawing.Point(0, 0);
            this.GradientPanelForgotPasswd.Margin = new System.Windows.Forms.Padding(2);
            this.GradientPanelForgotPasswd.Name = "GradientPanelForgotPasswd";
            this.GradientPanelForgotPasswd.Quality = 10;
            this.GradientPanelForgotPasswd.Size = new System.Drawing.Size(155, 420);
            this.GradientPanelForgotPasswd.TabIndex = 101;
            // 
            // lbForgotPass
            // 
            this.lbForgotPass.AutoSize = true;
            this.lbForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.lbForgotPass.Font = new System.Drawing.Font("Times New Roman", 28F);
            this.lbForgotPass.ForeColor = System.Drawing.Color.White;
            this.lbForgotPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbForgotPass.Location = new System.Drawing.Point(25, 143);
            this.lbForgotPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbForgotPass.Name = "lbForgotPass";
            this.lbForgotPass.Size = new System.Drawing.Size(101, 129);
            this.lbForgotPass.TabIndex = 20;
            this.lbForgotPass.Text = "Quên\r\nmật\r\nkhẩu";
            this.lbForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lSent
            // 
            this.lSent.BackColor = System.Drawing.Color.Transparent;
            this.lSent.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lSent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lSent.Location = new System.Drawing.Point(192, 177);
            this.lSent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSent.Name = "lSent";
            this.lSent.Size = new System.Drawing.Size(67, 15);
            this.lSent.TabIndex = 100;
            // 
            // bSend
            // 
            this.bSend.ActiveBorderThickness = 1;
            this.bSend.ActiveCornerRadius = 20;
            this.bSend.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bSend.ActiveForecolor = System.Drawing.Color.White;
            this.bSend.ActiveLineColor = System.Drawing.Color.Empty;
            this.bSend.BackColor = System.Drawing.SystemColors.Control;
            this.bSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSend.BackgroundImage")));
            this.bSend.ButtonText = "Gửi mã";
            this.bSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSend.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.bSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bSend.IdleBorderThickness = 1;
            this.bSend.IdleCornerRadius = 20;
            this.bSend.IdleFillColor = System.Drawing.Color.White;
            this.bSend.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bSend.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bSend.Location = new System.Drawing.Point(462, 101);
            this.bSend.Margin = new System.Windows.Forms.Padding(5);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(104, 44);
            this.bSend.TabIndex = 99;
            this.bSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // lCodeWrong
            // 
            this.lCodeWrong.AutoSize = true;
            this.lCodeWrong.BackColor = System.Drawing.Color.Transparent;
            this.lCodeWrong.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lCodeWrong.ForeColor = System.Drawing.Color.Red;
            this.lCodeWrong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lCodeWrong.Location = new System.Drawing.Point(192, 156);
            this.lCodeWrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCodeWrong.Name = "lCodeWrong";
            this.lCodeWrong.Size = new System.Drawing.Size(249, 17);
            this.lCodeWrong.TabIndex = 98;
            this.lCodeWrong.Text = "Mã xác nhận không đúng, vui lòng thử lại";
            this.lCodeWrong.Visible = false;
            // 
            // tbVerifyCode
            // 
            this.tbVerifyCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbVerifyCode.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbVerifyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbVerifyCode.HintForeColor = System.Drawing.Color.Empty;
            this.tbVerifyCode.HintText = "Mã xác nhận";
            this.tbVerifyCode.isPassword = false;
            this.tbVerifyCode.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbVerifyCode.LineIdleColor = System.Drawing.Color.Gray;
            this.tbVerifyCode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbVerifyCode.LineThickness = 4;
            this.tbVerifyCode.Location = new System.Drawing.Point(196, 101);
            this.tbVerifyCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbVerifyCode.Name = "tbVerifyCode";
            this.tbVerifyCode.Size = new System.Drawing.Size(235, 44);
            this.tbVerifyCode.TabIndex = 97;
            this.tbVerifyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbNewPass2
            // 
            this.tbNewPass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPass2.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbNewPass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPass2.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPass2.HintText = "Lặp lại mật khẩu";
            this.tbNewPass2.isPassword = true;
            this.tbNewPass2.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPass2.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNewPass2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPass2.LineThickness = 4;
            this.tbNewPass2.Location = new System.Drawing.Point(196, 285);
            this.tbNewPass2.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPass2.Name = "tbNewPass2";
            this.tbNewPass2.Size = new System.Drawing.Size(370, 44);
            this.tbNewPass2.TabIndex = 91;
            this.tbNewPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNewPass2.OnValueChanged += new System.EventHandler(this.tbNewPass2_OnValueChanged);
            // 
            // bExit
            // 
            this.bExit.ActiveBorderThickness = 1;
            this.bExit.ActiveCornerRadius = 20;
            this.bExit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bExit.ActiveForecolor = System.Drawing.Color.White;
            this.bExit.ActiveLineColor = System.Drawing.Color.Empty;
            this.bExit.BackColor = System.Drawing.SystemColors.Control;
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.ButtonText = "Thoát";
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.bExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.IdleBorderThickness = 1;
            this.bExit.IdleCornerRadius = 20;
            this.bExit.IdleFillColor = System.Drawing.Color.White;
            this.bExit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.Location = new System.Drawing.Point(462, 370);
            this.bExit.Margin = new System.Windows.Forms.Padding(5);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(104, 44);
            this.bExit.TabIndex = 93;
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bChange
            // 
            this.bChange.ActiveBorderThickness = 1;
            this.bChange.ActiveCornerRadius = 20;
            this.bChange.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bChange.ActiveForecolor = System.Drawing.Color.White;
            this.bChange.ActiveLineColor = System.Drawing.Color.Empty;
            this.bChange.BackColor = System.Drawing.SystemColors.Control;
            this.bChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bChange.BackgroundImage")));
            this.bChange.ButtonText = "Đổi";
            this.bChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bChange.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.bChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bChange.IdleBorderThickness = 1;
            this.bChange.IdleCornerRadius = 20;
            this.bChange.IdleFillColor = System.Drawing.Color.White;
            this.bChange.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bChange.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bChange.Location = new System.Drawing.Point(338, 370);
            this.bChange.Margin = new System.Windows.Forms.Padding(5);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(104, 45);
            this.bChange.TabIndex = 92;
            this.bChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // lInvalid
            // 
            this.lInvalid.AutoSize = true;
            this.lInvalid.BackColor = System.Drawing.Color.Transparent;
            this.lInvalid.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lInvalid.ForeColor = System.Drawing.Color.Red;
            this.lInvalid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lInvalid.Location = new System.Drawing.Point(192, 71);
            this.lInvalid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lInvalid.Name = "lInvalid";
            this.lInvalid.Size = new System.Drawing.Size(233, 17);
            this.lInvalid.TabIndex = 96;
            this.lInvalid.Text = "Tài khoản không tồn tại trong hệ thống";
            this.lInvalid.Visible = false;
            // 
            // lConfirmWrong
            // 
            this.lConfirmWrong.AutoSize = true;
            this.lConfirmWrong.BackColor = System.Drawing.Color.Transparent;
            this.lConfirmWrong.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lConfirmWrong.ForeColor = System.Drawing.Color.Red;
            this.lConfirmWrong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lConfirmWrong.Location = new System.Drawing.Point(192, 343);
            this.lConfirmWrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lConfirmWrong.Name = "lConfirmWrong";
            this.lConfirmWrong.Size = new System.Drawing.Size(170, 17);
            this.lConfirmWrong.TabIndex = 95;
            this.lConfirmWrong.Text = "Mật khẩu không trùng khớp";
            this.lConfirmWrong.Visible = false;
            // 
            // lShortPass
            // 
            this.lShortPass.AutoSize = true;
            this.lShortPass.BackColor = System.Drawing.Color.Transparent;
            this.lShortPass.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lShortPass.ForeColor = System.Drawing.Color.Red;
            this.lShortPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lShortPass.Location = new System.Drawing.Point(192, 247);
            this.lShortPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lShortPass.Name = "lShortPass";
            this.lShortPass.Size = new System.Drawing.Size(180, 17);
            this.lShortPass.TabIndex = 94;
            this.lShortPass.Text = "Mật khẩu phải dài hơn 8 kí tự";
            this.lShortPass.Visible = false;
            // 
            // tbNewPass1
            // 
            this.tbNewPass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPass1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbNewPass1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPass1.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPass1.HintText = "Mật khẩu mới";
            this.tbNewPass1.isPassword = true;
            this.tbNewPass1.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPass1.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNewPass1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPass1.LineThickness = 4;
            this.tbNewPass1.Location = new System.Drawing.Point(196, 196);
            this.tbNewPass1.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPass1.Name = "tbNewPass1";
            this.tbNewPass1.Size = new System.Drawing.Size(370, 44);
            this.tbNewPass1.TabIndex = 90;
            this.tbNewPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNewPass1.OnValueChanged += new System.EventHandler(this.tbNewPass1_OnValueChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.HintForeColor = System.Drawing.Color.Empty;
            this.tbEmail.HintText = "Email";
            this.tbEmail.isPassword = false;
            this.tbEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.tbEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbEmail.LineThickness = 4;
            this.tbEmail.Location = new System.Drawing.Point(195, 17);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(370, 44);
            this.tbEmail.TabIndex = 89;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 420);
            this.Controls.Add(this.GradientPanelForgotPasswd);
            this.Controls.Add(this.lSent);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.lCodeWrong);
            this.Controls.Add(this.tbVerifyCode);
            this.Controls.Add(this.tbNewPass2);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.lInvalid);
            this.Controls.Add(this.lConfirmWrong);
            this.Controls.Add(this.lShortPass);
            this.Controls.Add(this.tbNewPass1);
            this.Controls.Add(this.tbEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPass";
            this.Text = "ForgotPass";
            this.GradientPanelForgotPasswd.ResumeLayout(false);
            this.GradientPanelForgotPasswd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel GradientPanelForgotPasswd;
        private System.Windows.Forms.Label lbForgotPass;
        private System.Windows.Forms.Label lSent;
        private Bunifu.Framework.UI.BunifuThinButton2 bSend;
        private System.Windows.Forms.Label lCodeWrong;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbVerifyCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNewPass2;
        private Bunifu.Framework.UI.BunifuThinButton2 bExit;
        private Bunifu.Framework.UI.BunifuThinButton2 bChange;
        private System.Windows.Forms.Label lInvalid;
        private System.Windows.Forms.Label lConfirmWrong;
        private System.Windows.Forms.Label lShortPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNewPass1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbEmail;
    }
}