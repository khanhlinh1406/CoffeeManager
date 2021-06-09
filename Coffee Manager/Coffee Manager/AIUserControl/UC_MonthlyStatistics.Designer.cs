
namespace Coffee_Manager
{
    partial class UC_MonthlyStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.monthlyStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lb_Total_Status = new System.Windows.Forms.Label();
            this.cb_byQuanity = new System.Windows.Forms.CheckBox();
            this.cb_byValue = new System.Windows.Forms.CheckBox();
            this.picker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.picker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Count_Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // monthlyStatistic
            // 
            chartArea2.Name = "ChartArea1";
            this.monthlyStatistic.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.monthlyStatistic.Legends.Add(legend2);
            this.monthlyStatistic.Location = new System.Drawing.Point(0, 90);
            this.monthlyStatistic.Name = "monthlyStatistic";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Tổng giá trị các hóa đơn (VNĐ)";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Số lượng hóa đơn";
            this.monthlyStatistic.Series.Add(series3);
            this.monthlyStatistic.Series.Add(series4);
            this.monthlyStatistic.Size = new System.Drawing.Size(778, 369);
            this.monthlyStatistic.TabIndex = 0;
            this.monthlyStatistic.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lb_Total_Status
            // 
            this.lb_Total_Status.AutoSize = true;
            this.lb_Total_Status.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total_Status.Location = new System.Drawing.Point(465, 462);
            this.lb_Total_Status.Name = "lb_Total_Status";
            this.lb_Total_Status.Size = new System.Drawing.Size(228, 27);
            this.lb_Total_Status.TabIndex = 6;
            this.lb_Total_Status.Text = "TỔNG DOANH THU: 0";
            // 
            // cb_byQuanity
            // 
            this.cb_byQuanity.AutoSize = true;
            this.cb_byQuanity.Location = new System.Drawing.Point(613, 347);
            this.cb_byQuanity.Name = "cb_byQuanity";
            this.cb_byQuanity.Size = new System.Drawing.Size(111, 17);
            this.cb_byQuanity.TabIndex = 7;
            this.cb_byQuanity.Text = "Số lượng hóa đơn";
            this.cb_byQuanity.UseVisualStyleBackColor = true;
            this.cb_byQuanity.CheckedChanged += new System.EventHandler(this.cb_byQuanity_CheckedChanged);
            // 
            // cb_byValue
            // 
            this.cb_byValue.AutoSize = true;
            this.cb_byValue.Checked = true;
            this.cb_byValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_byValue.Location = new System.Drawing.Point(613, 385);
            this.cb_byValue.Name = "cb_byValue";
            this.cb_byValue.Size = new System.Drawing.Size(143, 17);
            this.cb_byValue.TabIndex = 8;
            this.cb_byValue.Text = "Tổng giá trị các hóa đơn";
            this.cb_byValue.UseVisualStyleBackColor = true;
            this.cb_byValue.CheckedChanged += new System.EventHandler(this.cb_byValue_CheckedChanged);
            // 
            // picker2
            // 
            this.picker2.CheckedState.Parent = this.picker2;
            this.picker2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.picker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.picker2.HoverState.Parent = this.picker2;
            this.picker2.Location = new System.Drawing.Point(591, 60);
            this.picker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.picker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.picker2.Name = "picker2";
            this.picker2.ShadowDecoration.Parent = this.picker2;
            this.picker2.Size = new System.Drawing.Size(187, 36);
            this.picker2.TabIndex = 33;
            this.picker2.Value = new System.DateTime(2021, 5, 30, 14, 32, 35, 975);
            this.picker2.ValueChanged += new System.EventHandler(this.picker2_ValueChanged);
            // 
            // picker1
            // 
            this.picker1.CheckedState.Parent = this.picker1;
            this.picker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.picker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.picker1.HoverState.Parent = this.picker1;
            this.picker1.Location = new System.Drawing.Point(591, 12);
            this.picker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.picker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.picker1.Name = "picker1";
            this.picker1.ShadowDecoration.Parent = this.picker1;
            this.picker1.Size = new System.Drawing.Size(187, 36);
            this.picker1.TabIndex = 34;
            this.picker1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.picker1.ValueChanged += new System.EventHandler(this.picker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "đến";
            // 
            // lb_Count_Status
            // 
            this.lb_Count_Status.AutoSize = true;
            this.lb_Count_Status.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Count_Status.Location = new System.Drawing.Point(465, 505);
            this.lb_Count_Status.Name = "lb_Count_Status";
            this.lb_Count_Status.Size = new System.Drawing.Size(215, 27);
            this.lb_Count_Status.TabIndex = 36;
            this.lb_Count_Status.Text = "TỔNG ĐƠN HÀNG: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Từ";
            // 
            // UC_MonthlyStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Count_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picker1);
            this.Controls.Add(this.picker2);
            this.Controls.Add(this.cb_byValue);
            this.Controls.Add(this.cb_byQuanity);
            this.Controls.Add(this.lb_Total_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthlyStatistic);
            this.Name = "UC_MonthlyStatistics";
            this.Size = new System.Drawing.Size(781, 540);
            this.Load += new System.EventHandler(this.UC_MonthlyStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthlyStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart monthlyStatistic;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lb_Total_Status;
        private System.Windows.Forms.CheckBox cb_byValue;
        private System.Windows.Forms.CheckBox cb_byQuanity;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker picker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker picker2;
        private System.Windows.Forms.Label lb_Count_Status;
        private System.Windows.Forms.Label label3;
    }
}
