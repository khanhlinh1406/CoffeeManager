using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coffee_Manager
{     
    public class Connect
    {
        SqlConnection Connection;
        // String connString = ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;
        //String connString = @"Server=DANH\SQLEXPRESS;Database=COFFEE_MANAGEMENT;User Id=sa;Password=c0ngdanh";
        public  string connString = @"Server=LAPTOP-DKIC94F6\SQLEXPRESS;Database=COFFEE_MANAGEMENT;User ID=sa;Password=123456";
        public Connect()
        {
            this.Connection = new SqlConnection(connString);
        }
        public void OpenConnection()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
        }

        public SqlCommand CreateSQLCmd(string args)
        {
            String sqlQuery = args;
            SqlCommand command = new SqlCommand(sqlQuery, Connection);
            return command;
        }
        public void CloseConnection()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
        }
    }
}

