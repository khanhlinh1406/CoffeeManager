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
        string OrderCondition;
        string FindCondition;
        int TongSoLuong = 0;
        public UC_BeverageStatistics()
        {
            InitializeComponent();
            try
            {
                Connection = new Connect();
                TimeCondition = "";
                OrderCondition = "";
                FindCondition = "";
                UpdateCondition();
                beverageStatistic.Titles.Add("THỐNG KÊ DOANH THU SẢN PHẨM BÁN RA");
                BeverageStatistic(Queries, "Số lượng bán ra");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
        }

        private void BeverageStatistic(string Query, string Series)
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

        private void UpdateCondition()
        {
            Queries = "select TenMon, sum(SoLuong) sl from MON m, HOADON hd, CT_HOADON ct where m.MaMon = ct.MaMon and ct.MaHD = hd.MaHD " + TimeCondition + FindCondition + " group by TenMon " + OrderCondition;
        }
        private void picker1_ValueChanged(object sender, EventArgs e)
        {
            TimeCondition = "and hd.NgLap between'" + picker1.Value.ToString("MM/dd/yyyy") + "' and '" + picker2.Value.ToString("MM/dd/yyyy") + "'";
            UpdateCondition();
            ReLoad();
        }

        private void picker2_ValueChanged(object sender, EventArgs e)
        {
            TimeCondition = "and hd.NgLap between'" + picker1.Value.ToString("MM/dd/yyyy") + "' and '" + picker2.Value.ToString("MM/dd/yyyy") + "'";
            UpdateCondition();
            ReLoad();
        }

        private void ReLoad()
        {
            beverageStatistic.Series["Số lượng bán ra"].Points.Clear();
            BeverageStatistic(Queries, "Số lượng bán ra");
        }

        private void dropdownSort_onItemSelected(object sender, EventArgs e)
        {
            if (dropdownSort.Text == "Doanh số tăng dần")
            {
                OrderCondition = "order by sl asc";
            }
            else
            {
                OrderCondition = "order by sl desc";
            }
            UpdateCondition();
            ReLoad();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FindCondition = " and TenMon like '%" + findTextbox.Text + "%' ";
            UpdateCondition();
            ReLoad();
        }

        private void findTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindCondition = " and TenMon like '%" + findTextbox.Text + "%' ";
                UpdateCondition();
                ReLoad();
            }
        }
    }
}
