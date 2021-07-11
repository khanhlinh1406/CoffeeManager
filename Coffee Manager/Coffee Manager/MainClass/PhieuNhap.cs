using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public class PhieuNhap
    {
        string MaPN;
        List<NguyenLieu> DSNguyenLieu = new List<NguyenLieu>();
        List<int> DSSoLuong = new List<int>();
        DateTime NgNhap;
        int TriGia;
        NhaCungCap nhaCungCap;

        Connect Connection = new Connect();

        public PhieuNhap()
        {
            MaPN = "";
            TriGia = 0;
            NgNhap = DateTime.Now;
            nhaCungCap = new NhaCungCap();
        }
        public PhieuNhap(string MaPN, List<NguyenLieu> DSNguyenLieu, List<int>DSSoLuong,
            DateTime NgNhap, int TriGiam, NhaCungCap nhaCungCap)
        {
            this.MaPN = MaPN;
            this.DSNguyenLieu = DSNguyenLieu;
            this.DSSoLuong = DSSoLuong;
            this.NgNhap = NgNhap;
            this.TriGia = TriGia;
            this.nhaCungCap = nhaCungCap;
        }

        public PhieuNhap(List<NguyenLieu> DSNguyenLieu, List<int> DSSoLuong,
             DateTime NgNhap, int TriGia, NhaCungCap nhaCungCap)
        {
            CreateMaPN();
            this.DSNguyenLieu = DSNguyenLieu;
            this.DSSoLuong = DSSoLuong;
            this.NgNhap = NgNhap;
            this.TriGia = TriGia;
            this.nhaCungCap = nhaCungCap;
        }

        public void CreateMaPN()
        {
            try
            {
                Random random = new Random();
                string tmp = random.Next(0, 999999999).ToString();

                string find = "SELECT MaPN FROM PHIEUNHAP where MaPN = '" + tmp + "'";

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
                this.MaPN = tmp;
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
        public int TRI_GIA
        {
            get { return this.TriGia; }
            set { this.TriGia = value; }
        }
        public DateTime NG_NHAP
        {
            get { return this.NgNhap; }
            set { this.NgNhap = value; }
        }
        public List<int> DS_SOLUONG
        {
            get { return this.DSSoLuong; }
            set { this.DSSoLuong = value; }
        }
        public List<NguyenLieu> DS_NGUYENLIEU
        {
            get { return this.DSNguyenLieu; }
            set { this.DSNguyenLieu = value; }
        }
        public string MA_PN
        {
            get { return this.MaPN; }
            set { this.MaPN = value; }
        }

        public NhaCungCap NHA_CC
        {
            get { return this.nhaCungCap; }
            set { this.nhaCungCap = value; }
        }

        public void Add() 
        {
            try
            {
                string sql = "insert into PHIEUNHAP(MaPN, NgNhap,TriGia, MaNCC) values " +
                    "('" + this.MaPN + "', '" + this.NgNhap + "', '" + this.TriGia + "', '"+ this.NHA_CC.MA_NCC+"') ";
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
                string sql = "update PHIEUNHAP set TriGia = '" + this.TriGia + "', NgNhap = '" + this.NgNhap + "', MaNCC = '" + this.nhaCungCap.MA_NCC + "' where MaPN = '" + this.MaPN + "'";
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
                // delete data in CT_PHIEUNHAP
                string sql = "delete from CT_PHIEUNHAP where MaPN = '" + this.MaPN + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
                Connection.CloseConnection();

                // delete data in PHIEUNHAP
                sql = "delete from PHIEUNHAP where MaPN = '" + this.MaPN + "'";
                this.Connection.OpenConnection();
                command = this.Connection.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
                Connection.CloseConnection();

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
