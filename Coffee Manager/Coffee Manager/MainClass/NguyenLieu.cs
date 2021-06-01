using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public class NguyenLieu
    {
        string MaNL;
        string TenNL;
        int TriGia;
        DonViTinh dvt;


        Connect Connection = new Connect();

        public NguyenLieu()
        {
            MaNL = TenNL = "";
            TriGia = 0;
            dvt = new DonViTinh();
        }

        public NguyenLieu(string TenNL, int TriGia, DonViTinh dvt)
        {
            CreateMaNL();
            this.TenNL = TenNL;
            this.TriGia = TriGia;
            this.dvt = dvt;
        }

        public NguyenLieu(string MaNL, string TenNL, int TriGia, DonViTinh dvt)
        {
            this.MaNL = MaNL;
            this.TenNL = TenNL;
            this.TriGia = TriGia;
            this.dvt = dvt;
        }

        public int TRI_GIA
        {
            get { return this.TriGia; }
            set { this.TriGia = value; }
        }
        public string TEN_NL
        {
            get { return this.TenNL; }
            set { this.TenNL = value; }
        }
        public string MA_NL
        {
            get { return this.MaNL; }
            set { this.MaNL = value; }
        }

        public DonViTinh DVT
        {
            get { return this.dvt; }
            set { this.dvt = value; }
        }

        public void CreateMaNL()
        {
            try
            {
                Random random = new Random();
                string tmp = random.Next(0, 999999999).ToString();

                string find = "SELECT MaNL FROM NGUYENLIEU where MaNL = '" + tmp + "'";

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
                this.MaNL = tmp;
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

        public void Add() {
            try
            {
                string sql = "insert into NGUYENLIEU(MaNL, TenNL, MaDVT, TriGia) values " +
                    "('" + this.MaNL + "', N'" + this.TenNL + "', '" + this.dvt.MA_DVT + "', '" + this.TriGia + "') ";
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
        public void Update() {
            try
            {
                string sql = "update NGUYENLIEU set TenNL = N'" + this.TenNL + "', MaDVT = '" + this.dvt.MA_DVT + "', TriGia = '" + this.TriGia + "' where MaNL = '" + this.MaNL + "'";
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
                string sql = "delete NGUYENLIEU where MaNL = '" + this.MaNL + "'";
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
