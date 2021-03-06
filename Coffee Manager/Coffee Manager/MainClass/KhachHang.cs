using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Coffee_Manager.MainClass;

namespace Coffee_Manager
{
    public class KhachHang : Nguoi
    {
        string MaKH;
        DateTime NgDK;
        int Diem;
        LoaiKhachHang loaiKH;

        Connect Connection = new Connect();

        public KhachHang()
        {
            MaKH = HoTen = SoDT = DiaChi = "";
            NgDK = NgSinh = DateTime.Now;
            Diem = 0;
            loaiKH = new LoaiKhachHang();
        }

        public KhachHang(string MaKH,string TenKH, DateTime NgSinh, string SoDT, string DiaChi, DateTime NgDK, int Diem, LoaiKhachHang loaiKH)
        {
            this.MaKH = MaKH;
            this.NgSinh = NgSinh;
            this.SoDT = SoDT;
            this.DiaChi = DiaChi;
            this.NgDK = NgDK;
            this.Diem = Diem;
            this.HoTen = TenKH;
            this.loaiKH = loaiKH;
        }

        public KhachHang(string MaKH, string TenKH, DateTime NgSinh, string SoDT, string DiaChi, DateTime NgDK, int Diem)
        {
            this.MaKH = MaKH;
            this.NgSinh = NgSinh;
            this.SoDT = SoDT;
            this.DiaChi = DiaChi;
            this.NgDK = NgDK;
            this.Diem = Diem;
            this.HoTen = TenKH;
        }

        public KhachHang( string TenKH, DateTime NgSinh, string SoDT, string DiaChi, DateTime NgDK, int Diem, LoaiKhachHang loaiKH)
        {
            CreateMaKH();
            this.HoTen = TenKH;
            this.NgSinh = NgSinh;
            this.SoDT = SoDT;
            this.DiaChi = DiaChi;
            this.NgDK = NgDK;
            this.Diem = Diem;
            this.loaiKH = loaiKH;
        }

        public int DIEM
        {
            get { return this.Diem; }
            set { this.Diem = value; }
        }
        
        public DateTime NG_DK
        {
            get { return this.NgDK; }
            set { this.NgDK = value; }
        }

        public string MA_KH
        {
            get { return this.MaKH; }
            set { this.MaKH = value; }
        }

        public LoaiKhachHang LOAI_KH
        {
            get { return this.loaiKH; }
            set { this.loaiKH = value; }
        }
        public void CreateMaKH()
        {
            try
            {
                Random random = new Random();
                string tmp = random.Next(0, 999999999).ToString();

                string find = "SELECT MaKH FROM KHACHHANG where MaKH = '" + tmp + "'";

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
                this.MaKH = tmp;
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
                string sql = "insert into KHACHHANG values " +
                    "('" + this.MaKH + "', N'" + this.HoTen + "', '" + this.NgSinh + "', '" + this.SoDT + "', N'"+this.DiaChi+"', '"+this.NgDK+"', '"+this.Diem+"', '"+this.loaiKH.Ma_LKH+"') ";
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
                string sql = "update KHACHHANG set TenKH = N'" + this.HoTen + "', NgSinh = '" + this.NgSinh + "', " +
                    "SoDT = '" + this.SoDT + "' , DiaChi = N'" + this.DiaChi + "', NgDK ='" + this.NgDK + "', " +
                    "Diem = '" + this.Diem + "' where MaKH = '" + this.MaKH + "'";
               
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
                string sql = "select * from HOADON where MaKH = '" + this.MaKH + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sql);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    MessageBox.Show("Khách hàng này không thể xoá được vì đã tồn tại trong hoá đơn", "Xoá khách hàng", MessageBoxButtons.OK);
                    return;

                }
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

            try
            {
                string sql = "delete KHACHHANG where MaKH = '" + this.MaKH + "'";
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

        public bool CheckPointToUpType()
        {
            try
            {
                bool isAbleToUpType = false;
                string nextType = GetNextCustomerType(this.loaiKH.Ma_LKH);
                string sql = "select DiemLH " +
                                "from LOAIKHACHHANG " +
                                "where MaLKH = '" + nextType + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sql);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    int diemLh = reader.GetInt32(0);
                    if (this.Diem >= diemLh)
                    {
                        isAbleToUpType = true;
                    }
                }
                reader.Close();
                if (isAbleToUpType)
                {
                    this.loaiKH.Ma_LKH = GetNextCustomerType(this.loaiKH.Ma_LKH);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                return false;
            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }

        public void UpdateType()
        {
            if (CheckPointToUpType())
            {
                try
                {
                    string sql = "update KHACHHANG set MaLKH = '" + this.LOAI_KH.Ma_LKH + "' where MaKH = '" + this.MaKH + "'";

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

        private string GetNextCustomerType(string type)
        {
            //if (type.Equals("bronze"))
            //{
            //    return "silver";
            //}
            //if (type.Equals("silver"))
            //{
            //    return "gold";
            //}
            //if (type.Equals("gold"))
            //{
            //    return "platinum";
            //}
            //return "platinum";
            try
            {
                Connect connect = new Connect();
                List<string> listMaLkh = new List<string>();
                string sql = "select MaLKH " +
                                "from LOAIKHACHHANG " +
                                "order by DiemLH ASC";
                connect.OpenConnection();
                SqlCommand command = connect.CreateSQLCmd(sql);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    listMaLkh.Add(reader.GetString(0));
                }
                reader.Close();
                if (listMaLkh.IndexOf(this.loaiKH.Ma_LKH) < listMaLkh.Count - 1)
                {
                    return listMaLkh[listMaLkh.IndexOf(this.loaiKH.Ma_LKH) + 1];
                }
                else
                {
                    return listMaLkh[listMaLkh.Count - 1];
                }
                connect.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
                return "";
            }
        }
    }
}
