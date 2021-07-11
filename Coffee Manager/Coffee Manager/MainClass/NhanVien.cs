using Coffee_Manager.MainClass;
using System;
using System.Collections.Generic;
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

        public NhanVien(string MaNV, string TenNV, string SoDT, string MaCV, string MaTK,
            DateTime NgSinh, DateTime NgVaoLam)
        {
            this.MaNV = MaNV;
            this.HoTen = TenNV;
            this.SoDT = SoDT;
            this.MaCV = MaCV;
            this.MaTK = MaTK;
            this.NgSinh = NgSinh;
            this.NgVaoLam = NgVaoLam;
        }
        public NhanVien( string TenNV, string SoDT, string MaCV, string MaTK, DateTime NgSinh, DateTime NgVaoLam)
        {
            CreateMaNV();
            this.HoTen = TenNV;
            this.SoDT = SoDT;
            this.MaCV = MaCV;
            this.MaTK = MaTK;
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
                string tmp = random.Next(0, 999999999).ToString();

                string find = "SELECT MaNV FROM NHANVIEN where MaNV = '" + tmp + "'";

                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    while (reader.GetString(0) == tmp)
                    {
                        tmp = random.Next(0, 999999999).ToString();
                    }

                }
                this.MaNV = tmp;
                reader.Close();
                this.Connection.CloseConnection();

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
        public void Add()
        {
            try
            {
                string sql = "insert into NHANVIEN values " +
                    "('" + this.MaNV + "', N'" + this.HoTen + "', '" + this.NgSinh + "', '" + this.SoDT + "', N'" + this.DiaChi + "', '" + this.NgVaoLam + "', '" + this.MaCV + "', '" + this.MaTK +  "') ";
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
                string sql = "update NHANVIEN set TenNV = N'" + this.HoTen + "', NgSinh = '" + this.NgSinh + "', " +
                    "SoDT = '" + this.SoDT + "' , DiaChi = N'" + this.DiaChi + "', NgVaoLam ='" + this.NgVaoLam + "', " +
                    "MaCV = '" + this.MaCV + "' where MaNV = '" + this.MaNV + "'";

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
                string sql = "delete NHANVIEN where MaNV = '" + this.MaNV + "'";
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
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
        //public void Save(){};


    }
}
