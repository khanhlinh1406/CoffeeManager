
namespace Coffee_Manager
{
    partial class UC_AddItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbCalculationUnit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bAddItem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM MÓN MỚI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên món";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá";
            // 
            // tbItemName
            // 
            this.tbItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbItemName.DefaultText = "";
            this.tbItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbItemName.DisabledState.Parent = this.tbItemName;
            this.tbItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbItemName.FocusedState.Parent = this.tbItemName;
            this.tbItemName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemName.ForeColor = System.Drawing.Color.Black;
            this.tbItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbItemName.HoverState.Parent = this.tbItemName;
            this.tbItemName.Location = new System.Drawing.Point(181, 237);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.PasswordChar = '\0';
            this.tbItemName.PlaceholderText = "";
            this.tbItemName.SelectedText = "";
            this.tbItemName.ShadowDecoration.Parent = this.tbItemName;
            this.tbItemName.Size = new System.Drawing.Size(399, 36);
            this.tbItemName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbItemName.TabIndex = 5;
            // 
            // tbPrice
            // 
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.DisabledState.Parent = this.tbPrice;
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.FocusedState.Parent = this.tbPrice;
            this.tbPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.Black;
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.HoverState.Parent = this.tbPrice;
            this.tbPrice.Location = new System.Drawing.Point(181, 324);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderText = "";
            this.tbPrice.SelectedText = "";
            this.tbPrice.ShadowDecoration.Parent = this.tbPrice;
            this.tbPrice.Size = new System.Drawing.Size(399, 36);
            this.tbPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbPrice.TabIndex = 6;
            // 
            // cbCalculationUnit
            // 
            this.cbCalculationUnit.BackColor = System.Drawing.Color.Transparent;
            this.cbCalculationUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCalculationUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalculationUnit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCalculationUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCalculationUnit.FocusedState.Parent = this.cbCalculationUnit;
            this.cbCalculationUnit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCalculationUnit.ForeColor = System.Drawing.Color.Black;
            this.cbCalculationUnit.HoverState.Parent = this.cbCalculationUnit;
            this.cbCalculationUnit.ItemHeight = 30;
            this.cbCalculationUnit.ItemsAppearance.Parent = this.cbCalculationUnit;
            this.cbCalculationUnit.Location = new System.Drawing.Point(181, 157);
            this.cbCalculationUnit.Name = "cbCalculationUnit";
            this.cbCalculationUnit.ShadowDecoration.Parent = this.cbCalculationUnit;
            this.cbCalculationUnit.Size = new System.Drawing.Size(399, 36);
            this.cbCalculationUnit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbCalculationUnit.TabIndex = 7;
            this.cbCalculationUnit.SelectedIndexChanged += new System.EventHandler(this.cbCalculationUnit_SelectedIndexChanged);
            // 
            // bAddItem
            // 
            this.bAddItem.BorderRadius = 26;
            this.bAddItem.CheckedState.Parent = this.bAddItem;
            this.bAddItem.CustomImages.Parent = this.bAddItem;
            this.bAddItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddItem.ForeColor = System.Drawing.Color.White;
            this.bAddItem.HoverState.Parent = this.bAddItem;
            this.bAddItem.Location = new System.Drawing.Point(290, 390);
            this.bAddItem.Name = "bAddItem";
            this.bAddItem.ShadowDecoration.Parent = this.bAddItem;
            this.bAddItem.Size = new System.Drawing.Size(180, 45);
            this.bAddItem.TabIndex = 8;
            this.bAddItem.Text = "Thêm món";
            this.bAddItem.Click += new System.EventHandler(this.bAddItem_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bAddItem);
            this.Controls.Add(this.cbCalculationUnit);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddItems";
            this.Size = new System.Drawing.Size(781, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbItemName;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cbCalculationUnit;
        private Guna.UI2.WinForms.Guna2Button bAddItem;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
