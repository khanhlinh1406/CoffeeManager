using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public class DonViTinh
    {
        string MaDVT;
        string TenDVT;

        Connect Connection = new Connect();

        public DonViTinh()
        {
            MaDVT = TenDVT = "";
        }

        public DonViTinh(string ma)
        {
            this.MaDVT = ma;
            this.TenDVT = "null";
        }

        public DonViTinh(string MaDVT, string TenDVT)
        {
            this.MaDVT = MaDVT;
            this.TenDVT = TenDVT;
        }

        public string MA_DVT
        {
            get { return this.MaDVT; }
            set { this.MaDVT = value; }
        }

        public string TEN_DVT
        {
            get { return this.TenDVT; }
            set { this.TenDVT = value; }
        }
        //public void Add() { };
        //public void Update() { };
        //public void Remove() { };

        public string FindMaDVT()
        {
            try
            {
                string sCheckLogin = "SELECT MaDVT FROM DONVITINH WHERE TenDVT = '" + this.TenDVT + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sCheckLogin);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {

                    if (reader.Read() == false) break;
                    return reader.GetString(0);
                    reader.Close();
                    this.Connection.CloseConnection();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");

            }
            finally
            {
                this.Connection.CloseConnection();
            }
            return "";
        }

        public string FindTenDVT()
        {
            try
            {
                string sCheckLogin = "SELECT TenDVT FROM DONVITINH WHERE MaDVT = '" + this.MaDVT + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sCheckLogin);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    this.TenDVT = reader.GetString(0);
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");

            }
            finally
            {
                this.Connection.CloseConnection();
            }

            return this.TenDVT;
        }
    }
}
