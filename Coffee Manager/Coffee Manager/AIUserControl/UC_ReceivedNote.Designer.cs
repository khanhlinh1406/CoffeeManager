
namespace Coffee_Manager
{
    partial class UC_ReceivedNote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridviewDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveDetail = new Guna.UI2.WinForms.Guna2Button();
            this.cbMaterial = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.gridviewGeneral = new Guna.UI2.WinForms.Guna2DataGridView();
            this.date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnRemoveGeneral = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnDone = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeen = new Guna.UI2.WinForms.Guna2Button();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewDetails
            // 
            this.gridviewDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridviewDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewDetails.BackgroundColor = System.Drawing.Color.White;
            this.gridviewDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridviewDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewDetails.ColumnHeadersHeight = 15;
            this.gridviewDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.name,
            this.dvt,
            this.sl,
            this.price,
            this.totalprice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewDetails.EnableHeadersVisualStyles = false;
            this.gridviewDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewDetails.Location = new System.Drawing.Point(13, 251);
            this.gridviewDetails.Name = "gridviewDetails";
            this.gridviewDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridviewDetails.RowHeadersVisible = false;
            this.gridviewDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewDetails.Size = new System.Drawing.Size(371, 235);
            this.gridviewDetails.TabIndex = 18;
            this.gridviewDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridviewDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridviewDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridviewDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridviewDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridviewDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridviewDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridviewDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewDetails.ThemeStyle.HeaderStyle.Height = 15;
            this.gridviewDetails.ThemeStyle.ReadOnly = true;
            this.gridviewDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridviewDetails.ThemeStyle.RowsStyle.Height = 22;
            this.gridviewDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewDetails_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NL";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Tên NL";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // dvt
            // 
            this.dvt.HeaderText = "ĐVT";
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            // 
            // sl
            // 
            this.sl.HeaderText = "SL";
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // totalprice
            // 
            this.totalprice.HeaderText = "Tổng";
            this.totalprice.Name = "totalprice";
            this.totalprice.ReadOnly = true;
            // 
            // btnRemoveDetail
            // 
            this.btnRemoveDetail.BorderRadius = 15;
            this.btnRemoveDetail.CheckedState.Parent = this.btnRemoveDetail;
            this.btnRemoveDetail.CustomImages.Parent = this.btnRemoveDetail;
            this.btnRemoveDetail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDetail.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDetail.HoverState.Parent = this.btnRemoveDetail;
            this.btnRemoveDetail.Location = new System.Drawing.Point(239, 492);
            this.btnRemoveDetail.Name = "btnRemoveDetail";
            this.btnRemoveDetail.ShadowDecoration.Parent = this.btnRemoveDetail;
            this.btnRemoveDetail.Size = new System.Drawing.Size(79, 39);
            this.btnRemoveDetail.TabIndex = 20;
            this.btnRemoveDetail.Text = "Xoá";
            this.btnRemoveDetail.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cbMaterial
            // 
            this.cbMaterial.BackColor = System.Drawing.Color.Transparent;
            this.cbMaterial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaterial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaterial.FocusedState.Parent = this.cbMaterial;
            this.cbMaterial.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMaterial.HoverState.Parent = this.cbMaterial;
            this.cbMaterial.ItemHeight = 30;
            this.cbMaterial.ItemsAppearance.Parent = this.cbMaterial;
            this.cbMaterial.Location = new System.Drawing.Point(25, 45);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.ShadowDecoration.Parent = this.cbMaterial;
            this.cbMaterial.Size = new System.Drawing.Size(241, 36);
            this.cbMaterial.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbMaterial.TabIndex = 27;
            this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(228, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(156, 39);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Thêm vào phiếu nhập";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số lượng";
            // 
            // numeric
            // 
            this.numeric.BackColor = System.Drawing.Color.Transparent;
            this.numeric.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numeric.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numeric.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numeric.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numeric.DisabledState.Parent = this.numeric;
            this.numeric.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numeric.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numeric.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numeric.FocusedState.Parent = this.numeric;
            this.numeric.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numeric.Location = new System.Drawing.Point(297, 45);
            this.numeric.Name = "numeric";
            this.numeric.ShadowDecoration.Parent = this.numeric;
            this.numeric.Size = new System.Drawing.Size(87, 39);
            this.numeric.TabIndex = 25;
            this.numeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nguyên liệu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày nhập";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(153, 492);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(80, 39);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gridviewGeneral
            // 
            this.gridviewGeneral.AllowUserToAddRows = false;
            this.gridviewGeneral.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.gridviewGeneral.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridviewGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewGeneral.BackgroundColor = System.Drawing.Color.White;
            this.gridviewGeneral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridviewGeneral.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewGeneral.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewGeneral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridviewGeneral.ColumnHeadersHeight = 15;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewGeneral.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridviewGeneral.EnableHeadersVisualStyles = false;
            this.gridviewGeneral.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewGeneral.Location = new System.Drawing.Point(412, 31);
            this.gridviewGeneral.Name = "gridviewGeneral";
            this.gridviewGeneral.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewGeneral.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridviewGeneral.RowHeadersVisible = false;
            this.gridviewGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewGeneral.Size = new System.Drawing.Size(341, 445);
            this.gridviewGeneral.TabIndex = 29;
            this.gridviewGeneral.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridviewGeneral.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewGeneral.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridviewGeneral.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridviewGeneral.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridviewGeneral.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridviewGeneral.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridviewGeneral.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewGeneral.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridviewGeneral.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewGeneral.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewGeneral.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewGeneral.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewGeneral.ThemeStyle.HeaderStyle.Height = 15;
            this.gridviewGeneral.ThemeStyle.ReadOnly = true;
            this.gridviewGeneral.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewGeneral.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewGeneral.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewGeneral.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridviewGeneral.ThemeStyle.RowsStyle.Height = 22;
            this.gridviewGeneral.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewGeneral.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewGeneral.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewGeneral_CellClick);
            // 
            // date
            // 
            this.date.BorderRadius = 15;
            this.date.CheckedState.Parent = this.date;
            this.date.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date.HoverState.Parent = this.date;
            this.date.Location = new System.Drawing.Point(202, 196);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.ShadowDecoration.Parent = this.date;
            this.date.Size = new System.Drawing.Size(182, 39);
            this.date.TabIndex = 30;
            this.date.Value = new System.DateTime(2021, 5, 30, 14, 32, 35, 975);
            // 
            // btnRemoveGeneral
            // 
            this.btnRemoveGeneral.BorderRadius = 15;
            this.btnRemoveGeneral.CheckedState.Parent = this.btnRemoveGeneral;
            this.btnRemoveGeneral.CustomImages.Parent = this.btnRemoveGeneral;
            this.btnRemoveGeneral.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGeneral.ForeColor = System.Drawing.Color.White;
            this.btnRemoveGeneral.HoverState.Parent = this.btnRemoveGeneral;
            this.btnRemoveGeneral.Location = new System.Drawing.Point(643, 492);
            this.btnRemoveGeneral.Name = "btnRemoveGeneral";
            this.btnRemoveGeneral.ShadowDecoration.Parent = this.btnRemoveGeneral;
            this.btnRemoveGeneral.Size = new System.Drawing.Size(91, 39);
            this.btnRemoveGeneral.TabIndex = 31;
            this.btnRemoveGeneral.Text = "Xoá";
            this.btnRemoveGeneral.Click += new System.EventHandler(this.btnRemoveGeneral_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnDone
            // 
            this.btnDone.BorderRadius = 15;
            this.btnDone.CheckedState.Parent = this.btnDone;
            this.btnDone.CustomImages.Parent = this.btnDone;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.HoverState.Parent = this.btnDone;
            this.btnDone.Location = new System.Drawing.Point(65, 492);
            this.btnDone.Name = "btnDone";
            this.btnDone.ShadowDecoration.Parent = this.btnDone;
            this.btnDone.Size = new System.Drawing.Size(82, 39);
            this.btnDone.TabIndex = 32;
            this.btnDone.Text = "Hoàn tất";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnSeen
            // 
            this.btnSeen.BorderRadius = 15;
            this.btnSeen.CheckedState.Parent = this.btnSeen;
            this.btnSeen.CustomImages.Parent = this.btnSeen;
            this.btnSeen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeen.ForeColor = System.Drawing.Color.White;
            this.btnSeen.HoverState.Parent = this.btnSeen;
            this.btnSeen.Location = new System.Drawing.Point(555, 492);
            this.btnSeen.Name = "btnSeen";
            this.btnSeen.ShadowDecoration.Parent = this.btnSeen;
            this.btnSeen.Size = new System.Drawing.Size(82, 39);
            this.btnSeen.TabIndex = 33;
            this.btnSeen.Text = "Xem xong";
            this.btnSeen.Click += new System.EventHandler(this.btnSeen_Click);
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
            this.tbPrice.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.Black;
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.HoverState.Parent = this.tbPrice;
            this.tbPrice.Location = new System.Drawing.Point(28, 131);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(5);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderText = "";
            this.tbPrice.SelectedText = "";
            this.tbPrice.ShadowDecoration.Parent = this.tbPrice;
            this.tbPrice.Size = new System.Drawing.Size(192, 39);
            this.tbPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbPrice.TabIndex = 34;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Đơn giá";
            // 
            // UC_ReceivedNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btnSeen);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnRemoveGeneral);
            this.Controls.Add(this.date);
            this.Controls.Add(this.gridviewGeneral);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRemoveDetail);
            this.Controls.Add(this.gridviewDetails);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_ReceivedNote";
            this.Size = new System.Drawing.Size(781, 554);
            this.Load += new System.EventHandler(this.UC_ReceivedNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gridviewDetails;
        private Guna.UI2.WinForms.Guna2Button btnRemoveDetail;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaterial;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown numeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewGeneral;
        private Guna.UI2.WinForms.Guna2DateTimePicker date;
        private Guna.UI2.WinForms.Guna2Button btnRemoveGeneral;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnDone;
        private Guna.UI2.WinForms.Guna2Button btnSeen;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
    }
}
