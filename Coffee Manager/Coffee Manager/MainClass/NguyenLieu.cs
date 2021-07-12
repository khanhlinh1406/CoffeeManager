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
        DonViTinh dvt;
        string MaNCC;


        Connect Connection = new Connect();

        public NguyenLieu()
        {
            MaNL = TenNL = "";
            dvt = new DonViTinh();
        }

        public NguyenLieu(string TenNL, DonViTinh dvt)
        {
            CreateMaNL();
            this.TenNL = TenNL;
            this.dvt = dvt;
        }

        public NguyenLieu(string MaNL, string TenNL, DonViTinh dvt)
        {
            this.MaNL = MaNL;
            this.TenNL = TenNL;
            this.dvt = dvt;
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

        public string MA_NCC 
        {
            get { return this.MaNCC; }
            set { this.MaNCC = value; }
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
                string sql = "insert into NGUYENLIEU(MaNL, TenNL, MaDVTNL) values " +
                    "('" + this.MaNL + "', N'" + this.TenNL + "', '" + this.dvt.MA_DVT + "') ";
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
                string sql = "update NGUYENLIEU set TenNL = N'" + this.TenNL + "', MaDVTNL = '" + this.dvt.MA_DVT + "' where MaNL = '" + this.MaNL + "'";
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
                string sql = "select * from CT_PHIEUNHAP where MaNL = '" + this.MaNL + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sql);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    MessageBox.Show("Nguyên liệu này không thể xoá được vì đã tồn tại trong phiếu nhập", "Xoá nguyên liệu", MessageBoxButtons.OK);
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
                string sql = "delete from NGUYENLIEU where MaNL = '"+this.MaNL+"'";
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
        
        public string FindMaNL()
        {
            try
            {
                string sCheckLogin = "SELECT MaNL FROM NGUYENLIEU WHERE TenNL = '" + this.TenNL + "'";
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

    }
}
