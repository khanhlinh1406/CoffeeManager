using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public class NhanVien
    {
        string MaNV;
        string TenNV;
        DateTime NgSinh;
        string SoDT;
        DateTime NgVaoLam;
        string MaCV;
        string MaTK;
        Connect Connection = new Connect();

        public NhanVien()
        {
            MaNV = TenNV = SoDT  = MaCV = MaTK = "";
            NgSinh = NgVaoLam = DateTime.Now;
        }

        public NhanVien(string MaNV, string TenNV, string SoDT, string MaCV, string MaTK,
            DateTime NgSinh, DateTime NgVaoLam)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.SoDT = SoDT;
            this.MaCV = MaCV;
            this.MaTK = MaTK;
            this.NgSinh = NgSinh;
            this.NgVaoLam = NgVaoLam;
        }
        public NhanVien( string TenNV, string SoDT, string MaCV, string MaTK, DateTime NgSinh, DateTime NgVaoLam)
        {
            CreateMaNV();
            this.TenNV = TenNV;
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
        public string TEN_NV
        {
            get { return this.TenNV; }
            set { this.TenNV = value; }
        }
        public string SO_DT
        {
            get { return this.SoDT; }
            set { this.SoDT = value; }
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
        public DateTime NG_SINH
        {
            get { return this.NgSinh; }
            set { this.NgSinh = value; }
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
                    "('" + this.MaNV + "', N'" + this.TenNV + "', '" + this.NgSinh + "', '" + this.SoDT  + "', '" + this.NgVaoLam + "', '" + this.MaCV + "', '" + this.MaTK +"') ";
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
                string sql = "update NHANVIEN set TenNV = N'" + this.TenNV + "', NgSinh = '" + this.NgSinh + "', " +
                    "SDT = '" + this.SoDT  + "', NgVaoLam ='" + this.NgVaoLam + "', MaCV ='" + this.MaCV + 
                    "' where MaNV = '" + this.MaNV + "'";

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
        //public void Save(){};


    }
}
