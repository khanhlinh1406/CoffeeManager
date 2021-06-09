using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public class HoaDon
    {
        string MaHD;
        string MaNVLap;
        DateTime NgLap;
        List<string> DSMon = new List<string>();
        List<int> SoLuong = new List<int>();
        int TriGia;
        string MaKH;
        Connect connect = new Connect();

        public HoaDon()
        {
            MaHD = MaNVLap = "";
            NgLap = DateTime.Now;
            TriGia = 0; 
        }

        public HoaDon(string MaHD, string MaNVLap, DateTime NgLap,
            List<string>DSMon, List<int>SoLuong, int TriGia, string MaKh)
        {
            this.MaHD = MaHD;
            this.MaNVLap = MaNVLap;
            this.NgLap = NgLap;
            this.DSMon = DSMon;
            this.SoLuong = SoLuong;
            this.TriGia = TriGia;
            this.MaKH = MaKh;
        }
        public int TRI_GIA
        {
            get { return this.TriGia; }
            set { this.TriGia = value; }
        }
        public List<int> SO_LUONG
        {
            get { return this.SoLuong; }
            set { this.SoLuong = value; }
        }
        public List<string> DS_MON
        {
            get { return this.DSMon; }
            set { this.DSMon = value; }
        }
        public DateTime NG_LAP
        {
            get { return this.NgLap; }
            set { this.NgLap = value; }
        }
        public string MA_NV_LAP
        {
            get { return this.MaNVLap; }
            set { this.MaNVLap = value; }
        }
        public string MA_HD
        {
            get { return this.MaHD; }
            set { this.MaHD = value; }
        }

        public string MA_KH
        {
            get { return this.MaKH; }
            set { this.MaKH = value; }
        }

        public void CreateMaKH()
        {
            try
            {
                Random random = new Random();
                string tmp = random.Next(0, 999999999).ToString();

                string find = "SELECT MaHD FROM HOADON where MaHD = '" + tmp + "'";

                this.connect.OpenConnection();
                SqlCommand command = this.connect.CreateSQLCmd(find);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    while (reader.GetString(0) == tmp)
                    {
                        tmp = random.Next(0, 999999999).ToString();
                    }

                }
                this.MaHD = tmp;
                reader.Close();
                this.connect.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");

            }
            finally
            {
                this.connect.CloseConnection();
            }
        }

        public void SaveHoaDon()
        {
            try
            {
                string sql = "insert into HOADON values " +
                    "('" + this.MaHD + "', '" + this.MaNVLap + "', '" + this.NgLap  + "', '" +
                    this.TriGia + "', '" + this.MaKH +  "')";
                this.connect.OpenConnection();
                SqlCommand command = this.connect.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
            finally
            {
                this.connect.CloseConnection();
            }
        }

        public void SaveChiTietHoaDon ()
        {
            try
            {
                this.connect.OpenConnection();
                for (int i = 0; i < DSMon.Count; i++)
                {
                    string sql = "insert into CT_HOADON values " +
                    "('" + this.MaHD + "', '" + DSMon[i] + "', '" + SoLuong[i] + "')";
                    SqlCommand command = this.connect.CreateSQLCmd(sql);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
            finally
            {
                this.connect.CloseConnection();
            }
        }
    }
}
