using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public class TinhTrang
    {
        string MaTT;
        string TenTT;
        Connect connect = new Connect();

        public TinhTrang()
        {
            MaTT = TenTT = "";
        }

        public TinhTrang(string Ma)
        {
            MaTT = Ma;
            TenTT = FindTenTTFromMaTT();
        }

        public string MA_TT
        {
            get { return this.MaTT; }
            set { this.MaTT = value; }
        }

        public string TEN_TT
        {
            get { return this.TenTT; }
            set { this.TenTT = value; }
        }

        public string FindTenTTFromMaTT()
        {
            try
            {
                string sCheckLogin = "SELECT TenTT FROM TINHTRANGMON WHERE MaTT = '" + this.MaTT + "'";
                this.connect.OpenConnection();
                SqlCommand command = this.connect.CreateSQLCmd(sCheckLogin);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {

                    if (reader.Read() == false) break;
                    String s = reader.GetString(0);
                    reader.Close();
                    this.connect.CloseConnection();
                    return s;
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
            return "";
        }
    }
}