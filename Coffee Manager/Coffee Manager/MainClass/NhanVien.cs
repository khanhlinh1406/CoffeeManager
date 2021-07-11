using Coffee_Manager.MainClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public class NhanVien : Nguoi
    {
        string MaNV;
        DateTime NgVaoLam;
        string MaCV;
        string MaTK;
        Connect Connection = new Connect();

        public NhanVien()
        {
            MaNV = HoTen = SoDT = DiaChi = MaCV = MaTK = "";
            NgSinh = NgVaoLam = DateTime.Now;
        }

        public NhanVien(string MaNV, string TenNV, string SoDT, string DiaChi, string MaCV, string MaTK,
            DateTime NgSinh, DateTime NgVaoLam)
        {
            this.MaNV = MaNV;
            this.HoTen = TenNV;
            this.SoDT = SoDT;
            this.DiaChi = DiaChi;
            this.MaCV = MaCV;
            this.MaTK = MaTK;
            this.NgSinh = NgSinh;
            this.NgVaoLam = NgVaoLam;
        }
        public NhanVien(string TenNV, string SoDT, string MaCV, string MaTK, string DiaChi, DateTime NgSinh, DateTime NgVaoLam)
        {
            CreateMaNV();
            this.HoTen = TenNV;
            this.SoDT = SoDT;
            this.MaCV = MaCV;
            this.MaTK = MaTK;
            this.DiaChi = DiaChi;
            this.NgSinh = NgSinh;
            this.NgVaoLam = NgVaoLam;
        }

        public string MA_NV
        {
            get { return this.MaNV; }
            set { this.MaNV = value; }
        }
        public string MA_CV
        {
            get { return this.MaCV; }
            set { this.MaCV = value; }
        }
        public string MA_TK
        {
            get { return this.MaTK; }
            set { this.MaTK = value; }
        }
        public DateTime NG_VAOLAM
        {
            get { return this.NgVaoLam; }
            set { this.NgVaoLam = value; }
        }
        public void CreateMaNV()
        {
            try
            {
                Random random = new Random();
                string tmp = "NV" + random.Next(0, 9999).ToString();

                string find = "SELECT MaNv FROM NHANVIEN where MaNV = '" + tmp + "'";

                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    while (reader.GetString(0) == tmp)
                    {
                        tmp = random.Next(0, 9999).ToString();
                    }

                }
                this.MaNV =  tmp;
                reader.Close();
                this.Connection.CloseConnection();

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                this.Connection.CloseConnection();
            }

        }
        public void Add()
        {
            using (SqlConnection connection = new SqlConnection(this.Connection.connString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;          
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into NHANVIEN (MaNV, TenNV, NgSinh, SDT, DiaChi, NgVaoLam, MaCV, MaTK) " +
                                          "VALUES (@id, @name, @born, @phone, @addr, @datein, @jobid, @accid)";
                    command.Parameters.AddWithValue("@id", this.MaNV);
                    command.Parameters.AddWithValue("@name", this.HoTen);
                    command.Parameters.AddWithValue("@born", this.NgSinh);
                    command.Parameters.AddWithValue("@phone", this.SoDT);
                    command.Parameters.AddWithValue("@addr", this.DiaChi);
                    command.Parameters.AddWithValue("@datein", this.NgVaoLam);
                    command.Parameters.AddWithValue("@jobid", this.MaCV);
                    command.Parameters.AddWithValue("@accid", this.MaTK);

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

        public void Update()
        {
            using (SqlConnection connection = new SqlConnection(this.Connection.connString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE NHANVIEN SET TenNV = @name, NgSinh = @born , SDT = @phone, DiaChi = @addr, NgVaoLam = @datein, MaCV = @jobid, MaTK = @accid WHERE MaNV = @id ";
                                         
                    command.Parameters.AddWithValue("@id", this.MaNV);
                    command.Parameters.AddWithValue("@name", this.HoTen);
                    command.Parameters.AddWithValue("@born", this.NgSinh);
                    command.Parameters.AddWithValue("@phone", this.SoDT);
                    command.Parameters.AddWithValue("@addr", this.DiaChi);
                    command.Parameters.AddWithValue("@datein", this.NgVaoLam);
                    command.Parameters.AddWithValue("@jobid", this.MaCV);
                    command.Parameters.AddWithValue("@accid", this.MaTK);

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

        public void Remove()
        {
            //using (SqlConnection connection = new SqlConnection(this.Connection.connString))
            //{
            //    using (SqlCommand command = new SqlCommand())
            //    {
            //        command.Connection = connection;
            //        command.CommandType = CommandType.Text;
            //        command.CommandText = "DELETE * FROM NHANVIEN WHERE  MaNV = @id ";

            //        command.Parameters.AddWithValue("@id", this.MaNV);

            //        try
            //        {
            //            connection.Open();
            //            int recordsAffected = command.ExecuteNonQuery();
            //        }
            //        catch (SqlException)
            //        {

            //        }
            //        finally
            //        {
            //            connection.Close();
            //        }
            //    }
            //}
            try
            {
                string sql = "delete NHANVIEN where MaNV = '" + this.MaNV + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }

        public void FindNhanVienFromAccountId()
        {
            try
            {
                string sql = "select * from NHANVIEN where MaTK = '" + this.MA_TK + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sql);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    this.MaNV = reader.GetString(0);
                    this.HoTen = reader.GetString(1);
                    this.SoDT = reader.GetString(3);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
        //public void Save(){};


    }
}
