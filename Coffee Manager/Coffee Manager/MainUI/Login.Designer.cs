
namespace Coffee_Manager
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuest = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbLoginStatus = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Black;
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(75, 251);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUsername.PlaceholderText = "Tên đăng nhập";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(182, 29);
            this.txtUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUsername.TabIndex = 2;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(75, 332);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(182, 29);
            this.txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnLogin.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogin.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(102, 384);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(131, 34);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.Location = new System.Drawing.Point(0, 0);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(100, 23);
            this.btnGuest.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coffee_Manager.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(78, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbLoginStatus
            // 
            this.lbLoginStatus.AutoSize = true;
            this.lbLoginStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginStatus.ForeColor = System.Drawing.Color.Red;
            this.lbLoginStatus.Location = new System.Drawing.Point(100, 441);
            this.lbLoginStatus.Name = "lbLoginStatus";
            this.lbLoginStatus.Size = new System.Drawing.Size(132, 17);
            this.lbLoginStatus.TabIndex = 7;
            this.lbLoginStatus.Text = "Trạng thái đăng nhập";
            this.lbLoginStatus.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 10;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(283, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(43, 24);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(333, 516);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbLoginStatus);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.LinkLabel btnGuest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLoginStatus;
        private Guna.UI2.WinForms.Guna2GradientButton btnExit;
    }
}

