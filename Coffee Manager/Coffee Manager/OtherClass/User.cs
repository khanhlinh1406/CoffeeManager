using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Coffee_Manager
{
    public class User
    {
        string MaTK;
        string MatKhau;
        
        Connect Connection = new Connect();
        public User()
        {
            this.MaTK = this.MatKhau = "";
        }

        public User(string MaTK, string MatKhau)
        {
            this.MaTK = MaTK;
            this.MatKhau = MatKhau;
        }
        public User(string[] args)
        {
            this.MaTK = args[0];
            this.MatKhau = args[1];
        }
        public User(string arg)
        {
            Connect Data = new Connect();
            try
            {
                Data.OpenConnection();

                SqlCommand command = Data.CreateSQLCmd("select FULLNAME, EMAIL from USERS where ID_USER='" + arg + "'");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    this.MaTK = reader.GetString(0);
                    this.MatKhau = reader.GetString(1);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
            finally
            {
                Data.CloseConnection();
            }
           
        }

        public bool IsStaff()
        {
            try
            {
                string sCheckLogin = "SELECT MaTK FROM NHANVIEN WHERE MaTK = '" + this.MaTK + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sCheckLogin);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {

                    if (reader.Read() == false) break;
                    if (reader.GetString(0) == this.MaTK)
                    {
                        this.Connection.CloseConnection();
                        reader.Close();
                        return true;
                    }
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
            return false;
        }
        public string MA_TK
        {
            get
            {
                return this.MaTK;
            }
            set
            {
                this.MaTK = value;
            }
        }
        public string MAT_KHAU
        {
            get
            {
                return this.MatKhau;
            }
            set
            {
                this.MatKhau = value;
            }
        }
       
       
        public int CheckLogin()
        {
            try
            {
                string sCheckLogin = "SELECT MatKhau FROM TAIKHOAN WHERE MaTK = '" + this.MaTK + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sCheckLogin);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                   
                    if (reader.Read() == false) break;
                    if (reader.GetString(0) == this.MatKhau)
                    {
                        this.Connection.CloseConnection();
                        reader.Close();
                        return 1;
                    }
                    reader.Close();
                    this.Connection.CloseConnection();
                    return -1;
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
            return 0;
        }

        public void updatePass()
        {
            using (SqlConnection connection = new SqlConnection(this.Connection.connString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE TAIKHOAN SET  MatKhau = @pass WHERE MaTK = @acc ";

                    command.Parameters.AddWithValue("@acc", this.MaTK);
                    command.Parameters.AddWithValue("@pass", this.MatKhau);
                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                      
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void AddUserToDatabase()
        {
            try
            {
                string sCheckLogin = "INSERT INTO TAIKHOAN VALUES('" + this.MaTK + "', '" + this.MatKhau + "')";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sCheckLogin);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Form temp = new Form();
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");

            }
            finally
            {
                this.Connection.CloseConnection();
            }


        }


        public void DeleteUser()
        {
            try
            {
                string Query = "delete from TAIKHOAN where MaTK = '" + this.MaTK + "'";


                Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(Query);
                command.ExecuteNonQuery();
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
    }
}

