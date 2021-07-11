using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coffee_Manager
{
    public class TinhTrang
    {

        string MaTT, TenTT;
        Connect Connection = new Connect();
        public TinhTrang()
        {

        }

        public TinhTrang(string MaTT, string TenTT)
        {
            this.MaTT = MaTT;
            this.TenTT = TenTT;
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

        public void Add()
        {
            try
            {
                string sql = "insert into TINHTRANGMON(MaTT, TenTT) values " +
                    "('" + this.MaTT + "', N'" + this.TenTT + "') ";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sql);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");

            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }

        public void Update()
        {
            try
            {
                string sql = "update TINHTRANGMON set TenTT = N'" + this.TenTT + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sql);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");

            }
            finally
            {
                this.Connection.CloseConnection();
            }

        }


        public void Remove()
        {
            try
            {
                string sql = "delete TINHTRANGMON where MaTT = '" + this.MaTT + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sql);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");

            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
    }
}
