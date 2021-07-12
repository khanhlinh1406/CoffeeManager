using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public class Mon
    {
        string MaMon;
        string TenMon;
        int Gia;
        DonViTinh dvt;
        TinhTrang tinhTrang;

        Connect Connection = new Connect();
        
        public Mon()
        {
            MaMon = TenMon = "";
            Gia = 0;
            dvt = new DonViTinh();
            tinhTrang = new TinhTrang();
        }

        public Mon(string MaMon, string TenMon, int Gia, DonViTinh dvt, TinhTrang tinhTrang)
        {
            this.MaMon = MaMon;
            this.TenMon = TenMon;
            this.Gia = Gia;
            this.dvt = dvt;
            this.tinhTrang = tinhTrang;
        }

        public Mon(string TenMon, int Gia, DonViTinh dvt, TinhTrang tinhTrang)
        {
            CreateMaMon();
            this.TenMon = TenMon;
            this.dvt = dvt;
            this.Gia = Gia;
            this.tinhTrang = tinhTrang;
        }

        public string MA_MON
        {
            get { return this.MaMon; }
            set { this.MaMon = value; }
        }

        public string TEN_MON
        {
            get { return this.TenMon; }
            set { this.TenMon = value; }
        }

        public int GIA
        {
            get { return this.Gia; }
            set { this.Gia = value; }
        }

        public DonViTinh DVT
        {
            get { return this.dvt; }
            set { this.dvt = value; }
        }

        public TinhTrang TINH_TRANG
        {
            get { return this.tinhTrang; }
            set { this.tinhTrang = value; }
        }


        public void CreateMaMon()
        {
            try
            {
                Random random = new Random();
                string tmp = random.Next(0, 999999999).ToString();

                string find = "SELECT MaMon FROM MON where MaMon = '"+tmp+"'";

                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    while (reader.GetString(0) == tmp )
                    {
                        tmp = random.Next(0, 999999999).ToString();
                    }
                    
                }
                this.MaMon = tmp;
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
                string sql = "insert into MON(MaMon, TenMon, MaDVTM, Gia, MaTT) values " +
                    "('" + this.MaMon + "', N'" + this.TenMon + "', '" + this.dvt.MA_DVT + "', '" + this.Gia + "', '"+ this.tinhTrang.MA_TT+"') ";
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
                string sql = "update MON set TenMon = N'" + this.TenMon + "', MaDVTM = '" + this.dvt.MA_DVT + "', Gia = '" + this.Gia + "', MaTT = '"+ this.TINH_TRANG.MA_TT+"' where MaMon = '" + this.MaMon + "'";
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
                string sql = "select * from CT_HOADON where MaMon = '" + this.MaMon + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sql);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    MessageBox.Show("Món này không thể xoá được vì đã tồn tại trong hoá đơn", "Xoá món", MessageBoxButtons.OK);
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
                string sql = "delete MON where MaMon = '" + this.MaMon + "'";
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

        public string FindMaMon()
        {
            try
            {
                string sCheckLogin = "SELECT MaMon FROM NGUYENLIEU WHERE TenMon = '" + this.TenMon + "'";
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

    //public void Remove() { }

