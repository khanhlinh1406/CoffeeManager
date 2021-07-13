
namespace Coffee_Manager
{
    partial class UC_BeverageStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.beverageStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.picker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lb_Total_Status = new System.Windows.Forms.Label();
            this.dropdownSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.findTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.buttonFind = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.beverageStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // beverageStatistic
            // 
            chartArea1.Name = "ChartArea1";
            this.beverageStatistic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.beverageStatistic.Legends.Add(legend1);
            this.beverageStatistic.Location = new System.Drawing.Point(0, 107);
            this.beverageStatistic.Name = "beverageStatistic";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng bán ra";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.beverageStatistic.Series.Add(series1);
            this.beverageStatistic.Size = new System.Drawing.Size(778, 369);
            this.beverageStatistic.TabIndex = 6;
            this.beverageStatistic.Text = "chart1";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "đến";
            // 
            // picker1
            // 
            this.picker1.BorderRadius = 15;
            this.picker1.CheckedState.Parent = this.picker1;
            this.picker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.picker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.picker1.HoverState.Parent = this.picker1;
            this.picker1.Location = new System.Drawing.Point(588, 21);
            this.picker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.picker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.picker1.Name = "picker1";
            this.picker1.ShadowDecoration.Parent = this.picker1;
            this.picker1.Size = new System.Drawing.Size(187, 36);
            this.picker1.TabIndex = 39;
            this.picker1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.picker1.ValueChanged += new System.EventHandler(this.picker1_ValueChanged);
            // 
            // picker2
            // 
            this.picker2.BorderRadius = 15;
            this.picker2.CheckedState.Parent = this.picker2;
            this.picker2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.picker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.picker2.HoverState.Parent = this.picker2;
            this.picker2.Location = new System.Drawing.Point(588, 69);
            this.picker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.picker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.picker2.Name = "picker2";
            this.picker2.ShadowDecoration.Parent = this.picker2;
            this.picker2.Size = new System.Drawing.Size(187, 36);
            this.picker2.TabIndex = 38;
            this.picker2.Value = new System.DateTime(2021, 5, 30, 14, 32, 35, 975);
            this.picker2.ValueChanged += new System.EventHandler(this.picker2_ValueChanged);
            // 
            // lb_Total_Status
            // 
            this.lb_Total_Status.AutoSize = true;
            this.lb_Total_Status.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total_Status.Location = new System.Drawing.Point(27, 479);
            this.lb_Total_Status.Name = "lb_Total_Status";
            this.lb_Total_Status.Size = new System.Drawing.Size(278, 24);
            this.lb_Total_Status.TabIndex = 42;
            this.lb_Total_Status.Text = "TỔNG SẢN PHẨM BÁN RA:";
            // 
            // dropdownSort
            // 
            this.dropdownSort.BackColor = System.Drawing.Color.Transparent;
            this.dropdownSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropdownSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownSort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dropdownSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dropdownSort.FocusedState.Parent = this.dropdownSort;
            this.dropdownSort.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownSort.ForeColor = System.Drawing.Color.Black;
            this.dropdownSort.HoverState.Parent = this.dropdownSort;
            this.dropdownSort.ItemHeight = 30;
            this.dropdownSort.Items.AddRange(new object[] {
            "Doanh số tăng dần",
            "Doanh số giảm dần"});
            this.dropdownSort.ItemsAppearance.Parent = this.dropdownSort;
            this.dropdownSort.Location = new System.Drawing.Point(588, 467);
            this.dropdownSort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dropdownSort.Name = "dropdownSort";
            this.dropdownSort.ShadowDecoration.Parent = this.dropdownSort;
            this.dropdownSort.Size = new System.Drawing.Size(187, 36);
            this.dropdownSort.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.dropdownSort.TabIndex = 43;
            this.dropdownSort.SelectedIndexChanged += new System.EventHandler(this.dropdownSort_onItemSelected);
            // 
            // findTextbox
            // 
            this.findTextbox.BorderRadius = 20;
            this.findTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.findTextbox.DefaultText = "";
            this.findTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.findTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.findTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.findTextbox.DisabledState.Parent = this.findTextbox;
            this.findTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.findTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.findTextbox.FocusedState.Parent = this.findTextbox;
            this.findTextbox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findTextbox.ForeColor = System.Drawing.Color.Black;
            this.findTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.findTextbox.HoverState.Parent = this.findTextbox;
            this.findTextbox.Location = new System.Drawing.Point(194, 31);
            this.findTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.findTextbox.Name = "findTextbox";
            this.findTextbox.PasswordChar = '\0';
            this.findTextbox.PlaceholderText = "";
            this.findTextbox.SelectedText = "";
            this.findTextbox.ShadowDecoration.Parent = this.findTextbox;
            this.findTextbox.Size = new System.Drawing.Size(226, 30);
            this.findTextbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.findTextbox.TabIndex = 44;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(62, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 19);
            this.metroLabel2.TabIndex = 45;
            this.metroLabel2.Text = "Tìm kiếm sản phẩm";
            // 
            // buttonFind
            // 
            this.buttonFind.BorderRadius = 15;
            this.buttonFind.CheckedState.Parent = this.buttonFind;
            this.buttonFind.CustomImages.Parent = this.buttonFind;
            this.buttonFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.ForeColor = System.Drawing.Color.White;
            this.buttonFind.HoverState.Parent = this.buttonFind;
            this.buttonFind.Location = new System.Drawing.Point(438, 31);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.ShadowDecoration.Parent = this.buttonFind;
            this.buttonFind.Size = new System.Drawing.Size(71, 34);
            this.buttonFind.TabIndex = 46;
            this.buttonFind.Text = "Tìm";
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // UC_BeverageStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.findTextbox);
            this.Controls.Add(this.dropdownSort);
            this.Controls.Add(this.lb_Total_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picker1);
            this.Controls.Add(this.picker2);
            this.Controls.Add(this.beverageStatistic);
            this.Name = "UC_BeverageStatistics";
            this.Size = new System.Drawing.Size(781, 540);
            ((System.ComponentModel.ISupportInitialize)(this.beverageStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart beverageStatistic;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker picker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker picker2;
        private System.Windows.Forms.Label lb_Total_Status;
        private Guna.UI2.WinForms.Guna2ComboBox dropdownSort;
        private Guna.UI2.WinForms.Guna2TextBox findTextbox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Guna.UI2.WinForms.Guna2Button buttonFind;
    }
}
