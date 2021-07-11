
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.beverageStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.picker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lb_Total_Status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beverageStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "THỐNG KÊ";
            // 
            // beverageStatistic
            // 
            chartArea3.Name = "ChartArea1";
            this.beverageStatistic.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.beverageStatistic.Legends.Add(legend3);
            this.beverageStatistic.Location = new System.Drawing.Point(0, 107);
            this.beverageStatistic.Name = "beverageStatistic";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Số lượng bán ra";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.beverageStatistic.Series.Add(series3);
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
            this.lb_Total_Status.Location = new System.Drawing.Point(474, 479);
            this.lb_Total_Status.Name = "lb_Total_Status";
            this.lb_Total_Status.Size = new System.Drawing.Size(278, 24);
            this.lb_Total_Status.TabIndex = 42;
            this.lb_Total_Status.Text = "TỔNG SẢN PHẨM BÁN RA:";
            // 
            // UC_BeverageStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_Total_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picker1);
            this.Controls.Add(this.picker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beverageStatistic);
            this.Name = "UC_BeverageStatistics";
            this.Size = new System.Drawing.Size(781, 540);
            ((System.ComponentModel.ISupportInitialize)(this.beverageStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart beverageStatistic;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker picker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker picker2;
        private System.Windows.Forms.Label lb_Total_Status;
    }
}
