
namespace Coffee_Manager
{
    partial class UC_PlaceOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCalculationUnit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbxLookup = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxOrderItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxOrderItemPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxOrderItemCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxOrderItemQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.orderGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrintBill = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.menuGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbLoaiKh = new System.Windows.Forms.Label();
            this.tbxCustomerType = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.btnRefreshCL = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbxOrderItemQuantity)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẶT MÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị tính";
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
            this.cbCalculationUnit.Location = new System.Drawing.Point(26, 112);
            this.cbCalculationUnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbCalculationUnit.Name = "cbCalculationUnit";
            this.cbCalculationUnit.ShadowDecoration.Parent = this.cbCalculationUnit;
            this.cbCalculationUnit.Size = new System.Drawing.Size(164, 36);
            this.cbCalculationUnit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbCalculationUnit.TabIndex = 4;
            this.cbCalculationUnit.SelectedValueChanged += new System.EventHandler(this.cbCalculationUnit_SelectedValueChanged);
            // 
            // tbxLookup
            // 
            this.tbxLookup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxLookup.DefaultText = "";
            this.tbxLookup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxLookup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxLookup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxLookup.DisabledState.Parent = this.tbxLookup;
            this.tbxLookup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxLookup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxLookup.FocusedState.Parent = this.tbxLookup;
            this.tbxLookup.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLookup.ForeColor = System.Drawing.Color.Black;
            this.tbxLookup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxLookup.HoverState.Parent = this.tbxLookup;
            this.tbxLookup.Location = new System.Drawing.Point(26, 159);
            this.tbxLookup.Margin = new System.Windows.Forms.Padding(5);
            this.tbxLookup.Name = "tbxLookup";
            this.tbxLookup.PasswordChar = '\0';
            this.tbxLookup.PlaceholderText = "Tìm kiếm";
            this.tbxLookup.SelectedText = "";
            this.tbxLookup.ShadowDecoration.Parent = this.tbxLookup;
            this.tbxLookup.Size = new System.Drawing.Size(194, 30);
            this.tbxLookup.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxLookup.TabIndex = 5;
            this.tbxLookup.TextChanged += new System.EventHandler(this.tbxLookup_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên món";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(273, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(273, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng cộng";
            // 
            // tbxOrderItemName
            // 
            this.tbxOrderItemName.Cursor = System.Windows.Forms.Cursors.No;
            this.tbxOrderItemName.DefaultText = "";
            this.tbxOrderItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxOrderItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxOrderItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxOrderItemName.DisabledState.Parent = this.tbxOrderItemName;
            this.tbxOrderItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxOrderItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxOrderItemName.FocusedState.Parent = this.tbxOrderItemName;
            this.tbxOrderItemName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOrderItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxOrderItemName.HoverState.Parent = this.tbxOrderItemName;
            this.tbxOrderItemName.Location = new System.Drawing.Point(40, 29);
            this.tbxOrderItemName.Margin = new System.Windows.Forms.Padding(5);
            this.tbxOrderItemName.Name = "tbxOrderItemName";
            this.tbxOrderItemName.PasswordChar = '\0';
            this.tbxOrderItemName.PlaceholderText = "";
            this.tbxOrderItemName.ReadOnly = true;
            this.tbxOrderItemName.SelectedText = "";
            this.tbxOrderItemName.ShadowDecoration.Parent = this.tbxOrderItemName;
            this.tbxOrderItemName.Size = new System.Drawing.Size(188, 30);
            this.tbxOrderItemName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxOrderItemName.TabIndex = 11;
            // 
            // tbxOrderItemPrice
            // 
            this.tbxOrderItemPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxOrderItemPrice.DefaultText = "";
            this.tbxOrderItemPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxOrderItemPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxOrderItemPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxOrderItemPrice.DisabledState.Parent = this.tbxOrderItemPrice;
            this.tbxOrderItemPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxOrderItemPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxOrderItemPrice.FocusedState.Parent = this.tbxOrderItemPrice;
            this.tbxOrderItemPrice.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOrderItemPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxOrderItemPrice.HoverState.Parent = this.tbxOrderItemPrice;
            this.tbxOrderItemPrice.Location = new System.Drawing.Point(277, 30);
            this.tbxOrderItemPrice.Margin = new System.Windows.Forms.Padding(5);
            this.tbxOrderItemPrice.Name = "tbxOrderItemPrice";
            this.tbxOrderItemPrice.PasswordChar = '\0';
            this.tbxOrderItemPrice.PlaceholderText = "";
            this.tbxOrderItemPrice.ReadOnly = true;
            this.tbxOrderItemPrice.SelectedText = "";
            this.tbxOrderItemPrice.ShadowDecoration.Parent = this.tbxOrderItemPrice;
            this.tbxOrderItemPrice.Size = new System.Drawing.Size(188, 30);
            this.tbxOrderItemPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxOrderItemPrice.TabIndex = 12;
            // 
            // tbxOrderItemCost
            // 
            this.tbxOrderItemCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxOrderItemCost.DefaultText = "";
            this.tbxOrderItemCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxOrderItemCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxOrderItemCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxOrderItemCost.DisabledState.Parent = this.tbxOrderItemCost;
            this.tbxOrderItemCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxOrderItemCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxOrderItemCost.FocusedState.Parent = this.tbxOrderItemCost;
            this.tbxOrderItemCost.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOrderItemCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxOrderItemCost.HoverState.Parent = this.tbxOrderItemCost;
            this.tbxOrderItemCost.Location = new System.Drawing.Point(277, 102);
            this.tbxOrderItemCost.Margin = new System.Windows.Forms.Padding(5);
            this.tbxOrderItemCost.Name = "tbxOrderItemCost";
            this.tbxOrderItemCost.PasswordChar = '\0';
            this.tbxOrderItemCost.PlaceholderText = "";
            this.tbxOrderItemCost.ReadOnly = true;
            this.tbxOrderItemCost.SelectedText = "";
            this.tbxOrderItemCost.ShadowDecoration.Parent = this.tbxOrderItemCost;
            this.tbxOrderItemCost.Size = new System.Drawing.Size(188, 30);
            this.tbxOrderItemCost.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxOrderItemCost.TabIndex = 14;
            // 
            // tbxOrderItemQuantity
            // 
            this.tbxOrderItemQuantity.BackColor = System.Drawing.Color.Transparent;
            this.tbxOrderItemQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxOrderItemQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxOrderItemQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxOrderItemQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxOrderItemQuantity.DisabledState.Parent = this.tbxOrderItemQuantity;
            this.tbxOrderItemQuantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.tbxOrderItemQuantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.tbxOrderItemQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxOrderItemQuantity.FocusedState.Parent = this.tbxOrderItemQuantity;
            this.tbxOrderItemQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOrderItemQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxOrderItemQuantity.Location = new System.Drawing.Point(40, 106);
            this.tbxOrderItemQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxOrderItemQuantity.Name = "tbxOrderItemQuantity";
            this.tbxOrderItemQuantity.ShadowDecoration.Parent = this.tbxOrderItemQuantity;
            this.tbxOrderItemQuantity.Size = new System.Drawing.Size(188, 30);
            this.tbxOrderItemQuantity.TabIndex = 15;
            this.tbxOrderItemQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbxOrderItemQuantity.ValueChanged += new System.EventHandler(this.tbxOrderItemQuantity_ValueChanged);
            this.tbxOrderItemQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxOrderItemQuantity_KeyPress);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BorderRadius = 15;
            this.btnAddToCart.CheckedState.Parent = this.btnAddToCart;
            this.btnAddToCart.CustomImages.Parent = this.btnAddToCart;
            this.btnAddToCart.Enabled = false;
            this.btnAddToCart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.Parent = this.btnAddToCart;
            this.btnAddToCart.Location = new System.Drawing.Point(285, 147);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.ShadowDecoration.Parent = this.btnAddToCart;
            this.btnAddToCart.Size = new System.Drawing.Size(180, 48);
            this.btnAddToCart.TabIndex = 16;
            this.btnAddToCart.Text = "Thêm vào Giỏ hàng";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btnAddToCart);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.tbxOrderItemQuantity);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.tbxOrderItemCost);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.tbxOrderItemPrice);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.tbxOrderItemName);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(253, 12);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(500, 210);
            this.guna2GroupBox1.TabIndex = 17;
            // 
            // orderGridView
            // 
            this.orderGridView.AllowUserToAddRows = false;
            this.orderGridView.AllowUserToOrderColumns = true;
            this.orderGridView.AllowUserToResizeColumns = false;
            this.orderGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.orderGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.BackgroundColor = System.Drawing.Color.White;
            this.orderGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.orderGridView.ColumnHeadersHeight = 20;
            this.orderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.orderGridView.EnableHeadersVisualStyles = false;
            this.orderGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderGridView.Location = new System.Drawing.Point(253, 241);
            this.orderGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.orderGridView.RowHeadersVisible = false;
            this.orderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderGridView.Size = new System.Drawing.Size(500, 159);
            this.orderGridView.TabIndex = 17;
            this.orderGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.orderGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.orderGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.orderGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.orderGridView.ThemeStyle.ReadOnly = true;
            this.orderGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.orderGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderGridView.ThemeStyle.RowsStyle.Height = 22;
            this.orderGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.orderGridView_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên món";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Đơn vị tính";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BorderRadius = 15;
            this.btnRemoveItem.CheckedState.Parent = this.btnRemoveItem;
            this.btnRemoveItem.CustomImages.Parent = this.btnRemoveItem;
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.HoverState.Parent = this.btnRemoveItem;
            this.btnRemoveItem.Location = new System.Drawing.Point(662, 420);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.ShadowDecoration.Parent = this.btnRemoveItem;
            this.btnRemoveItem.Size = new System.Drawing.Size(91, 35);
            this.btnRemoveItem.TabIndex = 18;
            this.btnRemoveItem.Text = "Xoá món";
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BorderRadius = 15;
            this.btnPrintBill.CheckedState.Parent = this.btnPrintBill;
            this.btnPrintBill.CustomImages.Parent = this.btnPrintBill;
            this.btnPrintBill.Enabled = false;
            this.btnPrintBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.White;
            this.btnPrintBill.HoverState.Parent = this.btnPrintBill;
            this.btnPrintBill.Location = new System.Drawing.Point(635, 496);
            this.btnPrintBill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.ShadowDecoration.Parent = this.btnPrintBill;
            this.btnPrintBill.Size = new System.Drawing.Size(118, 48);
            this.btnPrintBill.TabIndex = 19;
            this.btnPrintBill.Text = "In hoá đơn";
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(258, 496);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tổng cộng";
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.ForeColor = System.Drawing.Color.Maroon;
            this.lbTotalCost.Location = new System.Drawing.Point(491, 496);
            this.lbTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(71, 24);
            this.lbTotalCost.TabIndex = 21;
            this.lbTotalCost.Text = "0 VNĐ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 420);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Khách hàng";
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.BackColor = System.Drawing.Color.Transparent;
            this.cbxCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCustomer.FocusedState.Parent = this.cbxCustomer;
            this.cbxCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCustomer.ForeColor = System.Drawing.Color.Black;
            this.cbxCustomer.HoverState.Parent = this.cbxCustomer;
            this.cbxCustomer.ItemHeight = 30;
            this.cbxCustomer.ItemsAppearance.Parent = this.cbxCustomer;
            this.cbxCustomer.Location = new System.Drawing.Point(370, 406);
            this.cbxCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.ShadowDecoration.Parent = this.cbxCustomer;
            this.cbxCustomer.Size = new System.Drawing.Size(236, 36);
            this.cbxCustomer.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbxCustomer.TabIndex = 23;
            this.cbxCustomer.SelectedIndexChanged += new System.EventHandler(this.cbxCustomer_SelectedIndexChanged);
            // 
            // menuGridView
            // 
            this.menuGridView.AllowUserToAddRows = false;
            this.menuGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.menuGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.menuGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.menuGridView.BackgroundColor = System.Drawing.Color.White;
            this.menuGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.menuGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.menuGridView.ColumnHeadersHeight = 21;
            this.menuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.PriceColumn,
            this.StatusColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.menuGridView.EnableHeadersVisualStyles = false;
            this.menuGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.menuGridView.Location = new System.Drawing.Point(26, 241);
            this.menuGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.menuGridView.MultiSelect = false;
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.menuGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.menuGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuGridView.Size = new System.Drawing.Size(194, 301);
            this.menuGridView.TabIndex = 24;
            this.menuGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.menuGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.menuGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.menuGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.menuGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.menuGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.menuGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.menuGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.menuGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menuGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.menuGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.menuGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.menuGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.menuGridView.ThemeStyle.ReadOnly = true;
            this.menuGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.menuGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.menuGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.menuGridView.ThemeStyle.RowsStyle.Height = 22;
            this.menuGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.menuGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.menuGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuGridView_CellClick);
            // 
            // NameColumn
            // 
            this.NameColumn.FillWeight = 200F;
            this.NameColumn.HeaderText = "Tên món";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 73;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Giá";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 45;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Tình Trạng";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 84;
            // 
            // lbLoaiKh
            // 
            this.lbLoaiKh.AutoSize = true;
            this.lbLoaiKh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiKh.Location = new System.Drawing.Point(258, 459);
            this.lbLoaiKh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLoaiKh.Name = "lbLoaiKh";
            this.lbLoaiKh.Size = new System.Drawing.Size(107, 22);
            this.lbLoaiKh.TabIndex = 25;
            this.lbLoaiKh.Text = "Khuyến mãi";
            // 
            // tbxCustomerType
            // 
            this.tbxCustomerType.Cursor = System.Windows.Forms.Cursors.No;
            this.tbxCustomerType.DefaultText = "";
            this.tbxCustomerType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxCustomerType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxCustomerType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxCustomerType.DisabledState.Parent = this.tbxCustomerType;
            this.tbxCustomerType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxCustomerType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxCustomerType.FocusedState.Parent = this.tbxCustomerType;
            this.tbxCustomerType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCustomerType.ForeColor = System.Drawing.Color.Black;
            this.tbxCustomerType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxCustomerType.HoverState.Parent = this.tbxCustomerType;
            this.tbxCustomerType.Location = new System.Drawing.Point(370, 456);
            this.tbxCustomerType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCustomerType.Name = "tbxCustomerType";
            this.tbxCustomerType.PasswordChar = '\0';
            this.tbxCustomerType.PlaceholderText = "";
            this.tbxCustomerType.ReadOnly = true;
            this.tbxCustomerType.SelectedText = "";
            this.tbxCustomerType.ShadowDecoration.Parent = this.tbxCustomerType;
            this.tbxCustomerType.Size = new System.Drawing.Size(82, 24);
            this.tbxCustomerType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxCustomerType.TabIndex = 26;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbDiscount.Location = new System.Drawing.Point(492, 459);
            this.lbDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(71, 24);
            this.lbDiscount.TabIndex = 27;
            this.lbDiscount.Text = "0 VNĐ";
            // 
            // btnRefreshCL
            // 
            this.btnRefreshCL.CheckedState.Parent = this.btnRefreshCL;
            this.btnRefreshCL.CustomImages.Parent = this.btnRefreshCL;
            this.btnRefreshCL.FillColor = System.Drawing.Color.Transparent;
            this.btnRefreshCL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshCL.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCL.HoverState.Parent = this.btnRefreshCL;
            this.btnRefreshCL.Image = global::Coffee_Manager.Properties.Resources.ic_refresh;
            this.btnRefreshCL.Location = new System.Drawing.Point(611, 414);
            this.btnRefreshCL.Name = "btnRefreshCL";
            this.btnRefreshCL.ShadowDecoration.Parent = this.btnRefreshCL;
            this.btnRefreshCL.Size = new System.Drawing.Size(33, 33);
            this.btnRefreshCL.TabIndex = 28;
            this.btnRefreshCL.Click += new System.EventHandler(this.btnRefreshCL_Click);
            // 
            // UC_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefreshCL);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.tbxCustomerType);
            this.Controls.Add(this.lbLoaiKh);
            this.Controls.Add(this.menuGridView);
            this.Controls.Add(this.cbxCustomer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbTotalCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.tbxLookup);
            this.Controls.Add(this.cbCalculationUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "UC_PlaceOrder";
            this.Size = new System.Drawing.Size(782, 560);
            this.Load += new System.EventHandler(this.UC_PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbxOrderItemQuantity)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox tbxLookup;
        private Guna.UI2.WinForms.Guna2ComboBox cbCalculationUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbxOrderItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnPrintBill;
        private Guna.UI2.WinForms.Guna2Button btnRemoveItem;
        private Guna.UI2.WinForms.Guna2DataGridView orderGridView;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private Guna.UI2.WinForms.Guna2NumericUpDown tbxOrderItemQuantity;
        private Guna.UI2.WinForms.Guna2TextBox tbxOrderItemCost;
        private Guna.UI2.WinForms.Guna2TextBox tbxOrderItemPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCustomer;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView menuGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lbDiscount;
        private Guna.UI2.WinForms.Guna2TextBox tbxCustomerType;
        private System.Windows.Forms.Label lbLoaiKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private Guna.UI2.WinForms.Guna2Button btnRefreshCL;
    }
}
