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
        string LoaiDVT;

        Connect Connection = new Connect();

        public DonViTinh()
        {
            MaDVT = TenDVT = "";
        }

        public DonViTinh(string ma)
        {
            this.MaDVT = ma;
            this.TenDVT = FindTenDVT();
        }

        public DonViTinh(string MaDVT, string TenDVT)
        {
            this.MaDVT = MaDVT;
            this.TenDVT = TenDVT;
            this.LoaiDVT = "";
        }

        public DonViTinh(string MaDVT, string TenDVT, string LoaiDVT)
        {
            this.MaDVT = MaDVT;
            this.TenDVT = TenDVT;
            this.LoaiDVT = LoaiDVT;
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

        public string LOAI_DVT
        {
            get { return this.LoaiDVT; }
            set { this.LoaiDVT = value; }
        }
        public void Add(string table)
        {
            if (table == "Mon")
                table = "DVT_MON";
            else
                table = "DVT_NGUYENLIEU";
            try
            {
                string sQuery = "insert into " + table + " values('" +
                        MaDVT + "', N'" + TEN_DVT + "')";
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
        public void Update(string table)
        {
            if (table == "Mon")
                table = "DVT_MON";
            else
                table = "DVT_NGUYENLIEU";
            try
            {
                string column = (table == "DVT_MON" ? "TenDVTM" : "TenDVTNL");
                string column2 = (table == "DVT_MON" ? "MaDVTM" : "MaDVTNL");
                string sQuery = "update " + table + " set " + column + " = N'" + TenDVT + "' where " + column2 + " = '" + MaDVT + "'";
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
        public void Delete(string table)
        {
            if (table == "Mon")
                table = "DVT_MON";
            else
                table = "DVT_NGUYENLIEU";
            try
            {
                string column2 = (table == "DVT_MON" ? "MaDVTM" : "MaDVTNL");
                string sQuery = "delete " + table + " where " + column2 + " = '" + MaDVT + "'";
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
                string sCheckLogin = "SELECT TenDVTM FROM DVT_MON WHERE MaDVTM = '" + this.MaDVT + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sCheckLogin);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    this.TenDVT = reader.GetString(0);
                }
                reader.Close();
                return this.TEN_DVT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");

            }
            finally
            {
                this.Connection.CloseConnection();
            }
            return this.TEN_DVT;
        }

        public bool CheckMaDVT(string table)
        {
            if (table == "Mon")
                table = "DVT_MON";
            else
                table = "DVT_NGUYENLIEU";
            try
            {
                string column = (table == "DVT_MON" ? "MaDVTM" : "MaDVTNL");
                string sQuery = "select " + column + " from " + table + " where " +
                                column + "= '" + MaDVT + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sQuery);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    reader.Close();
                    return true;
                }
                reader.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                return true;
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }

        public bool CheckDelete()
        {
            try
            {
                string sQuery = "select MaDVTNL as Ma from NGUYENLIEU where MaDVTNL = '" + MaDVT + "'" +
                                " union " +
                                "select MaDVTM as Ma from MON where MaDVTM = '" + MaDVT + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sQuery);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    reader.Close();
                    return true;
                }
                reader.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                return true;
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
    }
}
