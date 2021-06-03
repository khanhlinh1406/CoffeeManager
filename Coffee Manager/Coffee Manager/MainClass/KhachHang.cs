﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public class KhachHang
    {
        string MaKH;
        string TenKH;
        DateTime NgSinh;
        string SoDT;
        string DiaChi;
        DateTime NgDK;
        int Diem;

        Connect Connection = new Connect();

        public KhachHang()
        {
            MaKH = TenKH= SoDT = DiaChi = "";
            NgDK = NgSinh = DateTime.Now;
            Diem = 0;
        }

        public KhachHang(string MaKH,string TenKH, DateTime NgSinh, string SoDT, string DiaChi, DateTime NgDK, int Diem)
        {
            this.MaKH = MaKH;
            this.NgSinh = NgSinh;
            this.SoDT = SoDT;
            this.DiaChi = DiaChi;
            this.NgDK = NgDK;
            this.Diem = Diem;
            this.TenKH = TenKH;
        }

        public KhachHang( string TenKH, DateTime NgSinh, string SoDT, string DiaChi, DateTime NgDK, int Diem)
        {
            CreateMaKH();
            this.TenKH = TenKH;
            this.NgSinh = NgSinh;
            this.SoDT = SoDT;
            this.DiaChi = DiaChi;
            this.NgDK = NgDK;
            this.Diem = Diem;
        }

        public int DIEM
        {
            get { return this.Diem; }
            set { this.Diem = value; }
        }
        public string DIA_CHI
        {
            get { return this.DiaChi; }
            set { this.DiaChi = value; }
        }
        public string SO_DT
        {
            get { return this.SoDT; }
            set { this.SoDT = value; }
        }
        public DateTime NG_DK
        {
            get { return this.NgDK; }
            set { this.NgDK = value; }
        }
        public DateTime NG_SINH
        {
            get { return this.NgSinh; }
            set { this.NgSinh = value; }
        }
        public string MA_KH
        {
            get { return this.MaKH; }
            set { this.MaKH = value; }
        }
        public string TEN_KH
        {
            get { return this.TenKH; }
            set { this.TenKH = value; }
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
                    "('" + this.MaKH + "', N'" + this.TenKH + "', '" + this.NgSinh + "', '" + this.SoDT + "', N'"+this.DiaChi+"', '"+this.NgDK+"', '"+this.Diem+"') ";
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
                string sql = "update KHACHHANG set TenKH = N'" + this.TenKH + "', NgSinh = '" + this.NgSinh + "', " +
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
    }
}