using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manager.Class
{
    class ChucVu
    {
        string MaCV;
        string TenCV;
        Connect Connection = new Connect();
        public ChucVu()
        {
            MaCV = TenCV = "";
        }

        public ChucVu(string MaCV, string TenCV)
        {
            this.MaCV = MaCV;
            this.TenCV = TenCV;
        }

        public string MA_CV
        {
            get { return this.MaCV; }
            set { this.MaCV = value; }
        }

        public string TEN_CV
        {
            get { return this.TenCV; }
            set { this.TenCV = value; }
        }
        public void Add()
        {
            try
            {
                string sQuery = "insert into CHUCVU values('" +
                        MaCV + "', N'" + TenCV + "')";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sQuery);
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
                string sQuery = "update CHUCVU set MaCV = '" +
                        MaCV + "', TenCV = N'" + TenCV + "')" +
                        "where MaCV = '" + MaCV + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sQuery);
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
        public void Delete()
        {
            try
            {
                string sQuery = "delete CHUCVU where MaCV = '" + MaCV + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sQuery);
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
