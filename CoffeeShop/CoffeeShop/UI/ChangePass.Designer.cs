﻿
namespace CoffeeShop
{
    partial class ChangePass
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChangePass = new System.Windows.Forms.Label();
            this.bExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bChange = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lWrong = new System.Windows.Forms.Label();
            this.lConfirmWrong = new System.Windows.Forms.Label();
            this.lShortPass = new System.Windows.Forms.Label();
            this.tbNewPass2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbNewPass1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbOldPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lbChangePass);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 364);
            this.panel1.TabIndex = 64;
            // 
            // lbChangePass
            // 
            this.lbChangePass.AutoSize = true;
            this.lbChangePass.BackColor = System.Drawing.Color.Transparent;
            this.lbChangePass.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangePass.ForeColor = System.Drawing.Color.White;
            this.lbChangePass.Location = new System.Drawing.Point(15, 138);
            this.lbChangePass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChangePass.Name = "lbChangePass";
            this.lbChangePass.Size = new System.Drawing.Size(134, 72);
            this.lbChangePass.TabIndex = 19;
            this.lbChangePass.Text = "Đổi\r\nMật khẩu\r\n";
            this.lbChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bExit
            // 
            this.bExit.ActiveBorderThickness = 1;
            this.bExit.ActiveCornerRadius = 20;
            this.bExit.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bExit.ActiveForecolor = System.Drawing.Color.White;
            this.bExit.ActiveLineColor = System.Drawing.Color.Empty;
            this.bExit.BackColor = System.Drawing.SystemColors.Control;
            this.bExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExit.BackgroundImage")));
            this.bExit.ButtonText = "Thoát";
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.IdleBorderThickness = 1;
            this.bExit.IdleCornerRadius = 20;
            this.bExit.IdleFillColor = System.Drawing.Color.White;
            this.bExit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bExit.Location = new System.Drawing.Point(447, 302);
            this.bExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(104, 44);
            this.bExit.TabIndex = 69;
            this.bExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bChange
            // 
            this.bChange.ActiveBorderThickness = 1;
            this.bChange.ActiveCornerRadius = 20;
            this.bChange.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bChange.ActiveForecolor = System.Drawing.Color.White;
            this.bChange.ActiveLineColor = System.Drawing.Color.Empty;
            this.bChange.BackColor = System.Drawing.SystemColors.Control;
            this.bChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bChange.BackgroundImage")));
            this.bChange.ButtonText = "Đổi";
            this.bChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bChange.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bChange.IdleBorderThickness = 1;
            this.bChange.IdleCornerRadius = 20;
            this.bChange.IdleFillColor = System.Drawing.Color.White;
            this.bChange.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bChange.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bChange.Location = new System.Drawing.Point(307, 301);
            this.bChange.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(104, 45);
            this.bChange.TabIndex = 68;
            this.bChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // lWrong
            // 
            this.lWrong.AutoSize = true;
            this.lWrong.BackColor = System.Drawing.Color.Transparent;
            this.lWrong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWrong.ForeColor = System.Drawing.Color.Red;
            this.lWrong.Location = new System.Drawing.Point(187, 71);
            this.lWrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lWrong.Name = "lWrong";
            this.lWrong.Size = new System.Drawing.Size(232, 17);
            this.lWrong.TabIndex = 72;
            this.lWrong.Text = "Mật khẩu cũ không đúng. Hãy thử lại!";
            this.lWrong.Visible = false;
            // 
            // lConfirmWrong
            // 
            this.lConfirmWrong.AutoSize = true;
            this.lConfirmWrong.BackColor = System.Drawing.Color.Transparent;
            this.lConfirmWrong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConfirmWrong.ForeColor = System.Drawing.Color.Red;
            this.lConfirmWrong.Location = new System.Drawing.Point(187, 272);
            this.lConfirmWrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lConfirmWrong.Name = "lConfirmWrong";
            this.lConfirmWrong.Size = new System.Drawing.Size(273, 17);
            this.lConfirmWrong.TabIndex = 71;
            this.lConfirmWrong.Text = "Mật khẩu này không trùng khớp. Hãy thử lại!";
            this.lConfirmWrong.Visible = false;
            // 
            // lShortPass
            // 
            this.lShortPass.AutoSize = true;
            this.lShortPass.BackColor = System.Drawing.Color.Transparent;
            this.lShortPass.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShortPass.ForeColor = System.Drawing.Color.Red;
            this.lShortPass.Location = new System.Drawing.Point(187, 162);
            this.lShortPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lShortPass.Name = "lShortPass";
            this.lShortPass.Size = new System.Drawing.Size(294, 17);
            this.lShortPass.TabIndex = 70;
            this.lShortPass.Text = "Mật khẩu cần phải từ 8 kí tự trở lên. Hãy thử lại!";
            this.lShortPass.Visible = false;
            // 
            // tbNewPass2
            // 
            this.tbNewPass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPass2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPass2.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPass2.HintText = "Xác nhận mật khẩu mới";
            this.tbNewPass2.isPassword = false;
            this.tbNewPass2.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPass2.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNewPass2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPass2.LineThickness = 4;
            this.tbNewPass2.Location = new System.Drawing.Point(190, 216);
            this.tbNewPass2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewPass2.Name = "tbNewPass2";
            this.tbNewPass2.Size = new System.Drawing.Size(370, 44);
            this.tbNewPass2.TabIndex = 67;
            this.tbNewPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNewPass2.OnValueChanged += new System.EventHandler(this.tbNewPass2_OnValueChanged);
            this.tbNewPass2.Enter += new System.EventHandler(this.tbNewPass2_Enter);
            this.tbNewPass2.Leave += new System.EventHandler(this.tbNewPass2_Leave);
            // 
            // tbNewPass1
            // 
            this.tbNewPass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPass1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewPass1.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPass1.HintText = "Mật khẩu mới";
            this.tbNewPass1.isPassword = false;
            this.tbNewPass1.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPass1.LineIdleColor = System.Drawing.Color.Gray;
            this.tbNewPass1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPass1.LineThickness = 4;
            this.tbNewPass1.Location = new System.Drawing.Point(190, 105);
            this.tbNewPass1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewPass1.Name = "tbNewPass1";
            this.tbNewPass1.Size = new System.Drawing.Size(370, 44);
            this.tbNewPass1.TabIndex = 66;
            this.tbNewPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNewPass1.OnValueChanged += new System.EventHandler(this.tbNewPass1_OnValueChanged);
            this.tbNewPass1.Enter += new System.EventHandler(this.tbNewPass1_Enter);
            this.tbNewPass1.Leave += new System.EventHandler(this.tbNewPass1_Leave);
            // 
            // tbOldPass
            // 
            this.tbOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOldPass.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOldPass.HintForeColor = System.Drawing.Color.Empty;
            this.tbOldPass.HintText = "Mật khẩu cũ";
            this.tbOldPass.isPassword = false;
            this.tbOldPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbOldPass.LineIdleColor = System.Drawing.Color.Gray;
            this.tbOldPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbOldPass.LineThickness = 4;
            this.tbOldPass.Location = new System.Drawing.Point(190, 13);
            this.tbOldPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(370, 44);
            this.tbOldPass.TabIndex = 65;
            this.tbOldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbOldPass.OnValueChanged += new System.EventHandler(this.tbOldPass_OnValueChanged);
            this.tbOldPass.Enter += new System.EventHandler(this.tbOldPass_Enter);
            this.tbOldPass.Leave += new System.EventHandler(this.tbOldPass_Leave);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 364);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.lWrong);
            this.Controls.Add(this.lConfirmWrong);
            this.Controls.Add(this.lShortPass);
            this.Controls.Add(this.tbNewPass2);
            this.Controls.Add(this.tbNewPass1);
            this.Controls.Add(this.tbOldPass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePass";
            this.Text = "ChangePass";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePass_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePass_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bExit;
        private Bunifu.Framework.UI.BunifuThinButton2 bChange;
        private System.Windows.Forms.Label lWrong;
        private System.Windows.Forms.Label lConfirmWrong;
        private System.Windows.Forms.Label lShortPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNewPass2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNewPass1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbOldPass;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label lbChangePass;
    }
}