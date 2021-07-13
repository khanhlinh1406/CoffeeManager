using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public class LoaiKhachHang
    {
        string MaLKH;
        string TenLoaiKh;
        double PhTramHd;
        double PhTramGiam;
        int DiemLH;
        Connect connect = new Connect();

        public LoaiKhachHang() {}

        public LoaiKhachHang(string MaLkh) 
        {
            this.MaLKH = MaLkh;
            LoadLoaiKHFromMaLKH();
        }

        public LoaiKhachHang(string maLKH, string tenLoaiKh, double phTramHd, double phTramGiam, int diemLH)
        {
            MaLKH = maLKH;
            TenLoaiKh = tenLoaiKh;
            PhTramHd = phTramHd;
            PhTramGiam = phTramGiam;
            DiemLH = diemLH;
        }

        public string Ma_LKH
        {
            get { return this.MaLKH; }
            set { this.MaLKH = value; }
        }

        public string TEN_LKH
        {
            get { return this.TenLoaiKh; }
            set { this.TenLoaiKh = value; }
        }

        public double PTRAM_HD
        {
            get { return this.PhTramHd; }
            set { this.PhTramHd = value; }
        }

        public double PTRAM_GIAM
        {
            get { return this.PhTramGiam; }
            set { this.PhTramGiam = value; }
        }

        public int DIEM_LH
        {
            get { return this.DiemLH; }
            set { this.DiemLH = value; }
        }


        public void LoadLoaiKHFromMaLKH()
        {
            try
            {
                string query = "SELECT LoaiKH, PTramHD, PTgiam, DiemLH FROM LOAIKHACHHANG WHERE MaLKH = '" + this.MaLKH + "'";
                this.connect.OpenConnection();
                SqlCommand command = this.connect.CreateSQLCmd(query);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    this.TenLoaiKh = reader.GetString(0);
                    this.PhTramHd = reader.GetDouble(1);
                    this.PhTramGiam = reader.GetDouble(2);
                    this.DiemLH = reader.GetInt32(3);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");

            }
            finally
            {
                this.connect.CloseConnection();
            }
        }

        public void Add()
        {
            try
            {
                string sQuery = "insert into LOAIKHACHHANG values('" +
                        MaLKH + "', N'" + TenLoaiKh + "', " + PhTramHd +
                        ", " + PhTramGiam + ", " + DiemLH + ")";
                this.connect.OpenConnection();
                SqlCommand command = this.connect.CreateSQLCmd(sQuery);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
            finally
            {
                this.connect.CloseConnection();
            }
        }

        public void Update()
        {
            try
            {
                string sQuery = "update LOAIKHACHHANG set LoaiKH = N'" + TenLoaiKh + "', PTramHD = "
                    + PhTramGiam + ", PTgiam = " + PhTramHd + ", DiemLH = " + DiemLH + " where MaLKH = '"
                    + MaLKH + "'";
                this.connect.OpenConnection();
                SqlCommand command = this.connect.CreateSQLCmd(sQuery);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
            finally
            {
                this.connect.CloseConnection();
            }

        }
        public void Delete()
        {
            try
            {
                string sQuery = "delete LOAIKHACHHANG where MaLKH = '" + MaLKH + "'";
                this.connect.OpenConnection();
                SqlCommand command = this.connect.CreateSQLCmd(sQuery);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
            finally
            {
                this.connect.CloseConnection();
            }
        }

        public bool CheckMaLKH()
        {
            try
            {
                string sQuery = "select MaLKH from LOAIKHACHHANG where MaLKH = '" +
                                MaLKH + "'";
                this.connect.OpenConnection();
                SqlCommand command = this.connect.CreateSQLCmd(sQuery);
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
                this.connect.CloseConnection();
            }
        }
    }
}
