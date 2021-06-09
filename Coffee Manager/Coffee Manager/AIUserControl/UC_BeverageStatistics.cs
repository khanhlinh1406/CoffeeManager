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
    public partial class UC_BeverageStatistics : UserControl
    {
        Connect Connection;
        string Queries = "";
        string TimeCondition;
        int TongSoLuong = 0;
        public UC_BeverageStatistics()
        {
            InitializeComponent();
            try
            {
                Connection = new Connect();
                TimeCondition = "";
                UpdateTimeCondition();
                beverageStatistic.Titles.Add("THỐNG KÊ DOANH THU SẢN PHẨM BÁN RA");
                //MonthlyStatisticByNV(Queries[0], "Số lượng hóa đơn");
                MonthlyStatisticByNV(Queries, "Số lượng bán ra");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
        }

        private void MonthlyStatisticByNV(string Query, string Series)
        {
            try
            {
                TongSoLuong = 0;
                Connection.OpenConnection();
                SqlCommand cmd = Connection.CreateSQLCmd(Query);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    if (!reader.Read())
                        break;
                    beverageStatistic.Series[Series].Points.AddXY(reader.GetString(0), reader.GetInt32(1));
                    TongSoLuong += reader.GetInt32(1);
                }
                lb_Total_Status.Text = "Tổng sản phẩm bán ra: " + TongSoLuong.ToString();

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
            Queries = "select TenMon, sum(SoLuong) sl from MON m, HOADON hd, CT_HOADON ct where m.MaMon = ct.MaMon and ct.MaHD = hd.MaHD " + TimeCondition +  " group by TenMon";
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
            beverageStatistic.Series["Số lượng bán ra"].Points.Clear();
            MonthlyStatisticByNV(Queries, "Số lượng bán ra");
        }
    }
}
