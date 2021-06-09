using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public partial class UC_MonthlyStatistics : UserControl
    {
        Connect Connection;
        string[] Queries = new string[2];
        string TimeCondition;
        int TongDoanhThu = 0;
        int TongDonHang = 0;
        public UC_MonthlyStatistics()
        {
            InitializeComponent();
            try
            {
                Connection = new Connect();
                TimeCondition = "";
                UpdateTimeCondition();
                monthlyStatistic.Titles.Add("THỐNG KÊ DOANH THU THEO THÁNG");
                //MonthlyStatisticByNV(Queries[0], "Số lượng hóa đơn");
                MonthlyStatisticByNV(Queries[1], "Tổng giá trị các hóa đơn (VNĐ)");
            }
            catch
            {

            }
            finally
            {
                
            }
        }

        private void MonthlyStatisticByNV(string Query, string Series)
        {
            try
            {
                TongDoanhThu = TongDonHang = 0;
                Connection.OpenConnection();
                SqlCommand cmd = Connection.CreateSQLCmd(Query);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    if (!reader.Read())
                        break;
                    monthlyStatistic.Series[Series].Points.AddXY(reader.GetString(0), reader.GetInt32(1));
                    if (Series == "Số lượng hóa đơn")
                    {
                        TongDonHang += reader.GetInt32(1);
                    }
                    else
                    {
                        TongDoanhThu += reader.GetInt32(1);
                    }    
                }
                lb_Total_Status.Text = "Tổng doanh thu: " + TongDoanhThu.ToString() + " VNĐ"; 
                lb_Count_Status.Text = "Tổng đơn hàng: " + TongDonHang.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
            finally
            {
                Connection.CloseConnection();
            }
        }

        private void UpdateTimeCondition()
        {
            Queries[0] = "select TenNV, count(MaHD) sl from NHANVIEN nv, HOADON hd where nv.MaNV = hd.MaNV_Lap " + TimeCondition + " group by TenNV";
            Queries[1] = "select TenNV, sum(TriGia) sum from NHANVIEN nv, HOADON hd where nv.MaNV = hd.MaNV_Lap " + TimeCondition + " group by TenNV";
        }

        private void UC_MonthlyStatistics_Load(object sender, EventArgs e)
        {

        }


        private void cb_byQuanity_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_byQuanity.Checked)
            {
                MonthlyStatisticByNV(Queries[0], "Số lượng hóa đơn");
            }
            else
            {
                monthlyStatistic.Series["Số lượng hóa đơn"].Points.Clear();
            }
        }

        private void cb_byValue_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_byValue.Checked)
            {
                MonthlyStatisticByNV(Queries[1], "Tổng giá trị các hóa đơn (VNĐ)");
            }
            else
            {
                monthlyStatistic.Series["Tổng giá trị các hóa đơn (VNĐ)"].Points.Clear();

            }
        }

        private void picker1_ValueChanged(object sender, EventArgs e)
        {
            TimeCondition = "and hd.NgLap between'" + picker1.Value.ToString("MM/dd/yyyy") + "' and '" + picker2.Value.ToString("MM/dd/yyyy") + "'";
            UpdateTimeCondition();
            ReLoad();
        }

        private void picker2_ValueChanged(object sender, EventArgs e)
        {
            TimeCondition = "and hd.NgLap between'" + picker1.Value.ToString("MM/dd/yyyy") + "' and '" + picker2.Value.ToString("MM/dd/yyyy") + "'";
            UpdateTimeCondition();
            ReLoad();
        }

        private void ReLoad()
        {
            monthlyStatistic.Series["Số lượng hóa đơn"].Points.Clear();
            monthlyStatistic.Series["Tổng giá trị các hóa đơn (VNĐ)"].Points.Clear();
            if (cb_byQuanity.Checked)
                MonthlyStatisticByNV(Queries[0], "Số lượng hóa đơn");
            if (cb_byValue.Checked)
                MonthlyStatisticByNV(Queries[1], "Tổng giá trị các hóa đơn (VNĐ)");
        }
    }
}
