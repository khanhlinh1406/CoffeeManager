
namespace Coffee_Manager
{
    partial class UC_Material
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bAddItem = new Guna.UI2.WinForms.Guna2Button();
            this.cbCalculationUnit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddItem
            // 
            this.bAddItem.BorderRadius = 15;
            this.bAddItem.CheckedState.Parent = this.bAddItem;
            this.bAddItem.CustomImages.Parent = this.bAddItem;
            this.bAddItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddItem.ForeColor = System.Drawing.Color.White;
            this.bAddItem.HoverState.Parent = this.bAddItem;
            this.bAddItem.Location = new System.Drawing.Point(80, 325);
            this.bAddItem.Name = "bAddItem";
            this.bAddItem.ShadowDecoration.Parent = this.bAddItem;
            this.bAddItem.Size = new System.Drawing.Size(124, 40);
            this.bAddItem.TabIndex = 15;
            this.bAddItem.Text = "Thêm";
            this.bAddItem.Click += new System.EventHandler(this.bAddItem_Click);
            // 
            // cbCalculationUnit
            // 
            this.cbCalculationUnit.BackColor = System.Drawing.Color.Transparent;
            this.cbCalculationUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCalculationUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalculationUnit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCalculationUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCalculationUnit.FocusedState.Parent = this.cbCalculationUnit;
            this.cbCalculationUnit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCalculationUnit.ForeColor = System.Drawing.Color.Black;
            this.cbCalculationUnit.HoverState.Parent = this.cbCalculationUnit;
            this.cbCalculationUnit.ItemHeight = 30;
            this.cbCalculationUnit.ItemsAppearance.Parent = this.cbCalculationUnit;
            this.cbCalculationUnit.Location = new System.Drawing.Point(31, 146);
            this.cbCalculationUnit.Name = "cbCalculationUnit";
            this.cbCalculationUnit.ShadowDecoration.Parent = this.cbCalculationUnit;
            this.cbCalculationUnit.Size = new System.Drawing.Size(226, 36);
            this.cbCalculationUnit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbCalculationUnit.TabIndex = 14;
            this.cbCalculationUnit.SelectedIndexChanged += new System.EventHandler(this.cbCalculationUnit_SelectedIndexChanged);
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
            this.tbItemName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemName.ForeColor = System.Drawing.Color.Black;
            this.tbItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbItemName.HoverState.Parent = this.tbItemName;
            this.tbItemName.Location = new System.Drawing.Point(31, 226);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(5);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.PasswordChar = '\0';
            this.tbItemName.PlaceholderText = "";
            this.tbItemName.SelectedText = "";
            this.tbItemName.ShadowDecoration.Parent = this.tbItemName;
            this.tbItemName.Size = new System.Drawing.Size(226, 39);
            this.tbItemName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbItemName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên nguyên liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đơn vị tính";
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview.BackgroundColor = System.Drawing.Color.White;
            this.gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridview.ColumnHeadersHeight = 15;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridview.EnableHeadersVisualStyles = false;
            this.gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview.Location = new System.Drawing.Point(297, 30);
            this.gridview.Name = "gridview";
            this.gridview.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridview.RowHeadersVisible = false;
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview.Size = new System.Drawing.Size(468, 425);
            this.gridview.TabIndex = 19;
            this.gridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridview.ThemeStyle.HeaderStyle.Height = 15;
            this.gridview.ThemeStyle.ReadOnly = true;
            this.gridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridview.ThemeStyle.RowsStyle.Height = 22;
            this.gridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(80, 384);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(124, 40);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderRadius = 15;
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(642, 475);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(102, 40);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Xoá";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "NGUYÊN LIỆU";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.bAddItem);
            this.Controls.Add(this.cbCalculationUnit);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Material";
            this.Size = new System.Drawing.Size(781, 554);
            this.Load += new System.EventHandler(this.UC_Material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button bAddItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbCalculationUnit;
        private Guna.UI2.WinForms.Guna2TextBox tbItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView gridview;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
