using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coffee_Manager
{
    public partial class UC_ReceivedNote : UserControl
    {
        Connect Connection = new Connect();
        List<NguyenLieu> listNL = new List<NguyenLieu>();
        bool isSeenDetail = false;
        
        public UC_ReceivedNote()
        {
            InitializeComponent();
            date.Value = DateTime.Now;
            btnSeen.Visible = false;
            btnRemoveDetail.Enabled = btnUpdate.Enabled = false;
        }

        public void UC_ReceivedNote_Load(object sender, EventArgs e)
        {
            LoadDataGeneral();
            LoadListNL();
        }

        public void LoadDataGeneral()
        {
            try
            {

                string find = "SELECT * FROM PHIEUNHAP";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                gridviewGeneral.DataSource = dataSet.Tables[0];
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

        private void gridviewGeneral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            LoadDataDetail(gridviewGeneral.SelectedRows[0].Cells[0].Value.ToString());
            date.Value = DateTime.Parse(gridviewGeneral.SelectedRows[0].Cells[1].Value.ToString());
            isSeenDetail = true;
            btnSeen.Visible = true;
        }

        void LoadDataDetail(string MaPN)
        {
            try
            {
                
                string find = "SELECT NL.MaNL, NL.TenNL, CT.SoLuong, NL.MaDVT, DVT.TenDVT, CT.DonGia FROM NGUYENLIEU NL join CT_PHIEUNHAP CT on CT.MaNL = NL.MaNL join DONVITINH DVT on NL.MaDVT = DVT.MaDVT where CT.MaPN = '"+MaPN+"'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(find);

                SqlDataReader reader = command.ExecuteReader();

                List<NguyenLieu> listNL = new List<NguyenLieu>();
                               gridviewDetails.Rows.Clear();

                while (reader.HasRows)
                {
                    
                    if (reader.Read() == false) break;
                    NguyenLieu tmp = new NguyenLieu(reader.GetString(0), reader.GetString(1), new DonViTinh(reader.GetString(3), reader.GetString(4)));
                    listNL.Add(tmp);
                    
                    gridviewDetails.Rows.Add(tmp.MA_NL, tmp.TEN_NL, tmp.DVT.TEN_DVT, reader.GetInt32(2), reader.GetInt32(5), reader.GetInt32(5) * reader.GetInt32(2));
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

        void LoadListNL()
        {
            cbMaterial.Items.Clear();
            try
            {
                this.Connection.OpenConnection();
                string find = "SELECT NL.MaNL, NL.TenNL, DVT.MaDVT, DVT.TenDVT FROM NGUYENLIEU NL left JOIN DONVITINH DVT ON NL.MaDVT = DVT.MaDVT";
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {

                    if (reader.Read() == false) break;
                    NguyenLieu tmp = new NguyenLieu(reader.GetString(0), reader.GetString(1), new DonViTinh(reader.GetString(2), reader.GetString(3))) ;
                    
                    listNL.Add(tmp);
                    
                    string listContent = tmp.TEN_NL + " (" + tmp.DVT.TEN_DVT + ")";
                    cbMaterial.Items.Add(listContent);
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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gridviewDetails.Rows.Add(listNL[indexMaterial].MA_NL,listNL[indexMaterial].TEN_NL, listNL[indexMaterial].DVT.TEN_DVT, numeric.Value, int.Parse(tbPrice.Text), numeric.Value * int.Parse(tbPrice.Text));
        }


        int indexMaterial;

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexMaterial = cbMaterial.SelectedIndex;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            gridviewDetails.SelectedRows[0].Cells[0].Value = listNL[indexMaterial].MA_NL;
            gridviewDetails.SelectedRows[0].Cells[1].Value = listNL[indexMaterial].TEN_NL;
            gridviewDetails.SelectedRows[0].Cells[2].Value = listNL[indexMaterial].DVT.TEN_DVT;
            gridviewDetails.SelectedRows[0].Cells[3].Value = numeric.Value;
            gridviewDetails.SelectedRows[0].Cells[4].Value = tbPrice.Text;
            gridviewDetails.SelectedRows[0].Cells[5].Value = numeric.Value * int.Parse(tbPrice.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            gridviewDetails.Rows.RemoveAt(indexDetail);
            
        }

      
        private void btnSeen_Click(object sender, EventArgs e)
        {
            btnSeen.Visible = false;
            isSeenDetail = false;
            cbMaterial.Text = null;
            numeric.Value = 0;
            tbPrice.Text = "";
            gridviewDetails.Rows.Clear();
            LoadDataGeneral();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            int total = 0;
            
            for (int rows = 0; rows < gridviewDetails.Rows.Count; rows++)
                total += int.Parse(gridviewDetails.Rows[rows].Cells[5].Value.ToString());

            if (isSeenDetail == false)
            {
               
                //add new
                List<NguyenLieu> listNguyenLieu = new List<NguyenLieu>();
                List<int> SL = new List<int>();



                PhieuNhap phieuNhap = new PhieuNhap();
                phieuNhap.TRI_GIA = total;
                phieuNhap.NG_NHAP = date.Value;
                phieuNhap.CreateMaPN();

                phieuNhap.Add();

                for (int rows = 0; rows < gridviewDetails.Rows.Count ; rows++)
                {
                    NguyenLieu tmp = new NguyenLieu();
                    tmp.TEN_NL = gridviewDetails.Rows[rows].Cells[1].Value.ToString();
                    tmp.MA_NL = gridviewDetails.Rows[rows].Cells[0].Value.ToString();

                    try
                    {
                        string sql = "insert into CT_PHIEUNHAP(MaPN, MaNL, SoLuong, DonGia) values " +
                            "('" + phieuNhap.MA_PN + "', '" + tmp.MA_NL + "', '" + int.Parse(gridviewDetails.Rows[rows].Cells[3].Value.ToString()) + "', '"+int.Parse(tbPrice.Text)+"') ";
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
            else
            {
                // update
               
                List<NguyenLieu> listNguyenLieu = new List<NguyenLieu>();
               
                PhieuNhap phieuNhap = new PhieuNhap();
                phieuNhap.MA_PN = gridviewGeneral.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    string sql = "delete from CT_PHIEUNHAP where MaPN = '" + phieuNhap.MA_PN + "'";
                    this.Connection.OpenConnection();
                    SqlCommand command = this.Connection.CreateSQLCmd(sql);
                    command.ExecuteNonQuery();
                    Connection.CloseConnection();
                }catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                for (int rows = 0; rows < gridviewDetails.Rows.Count; rows++)
                {
                    NguyenLieu tmp = new NguyenLieu();
                    tmp.TEN_NL = gridviewDetails.Rows[rows].Cells[1].Value.ToString();
                    tmp.MA_NL = gridviewDetails.Rows[rows].Cells[0].Value.ToString();

                    try
                    {
                        string sql = "insert into CT_PHIEUNHAP(MaPN, MaNL, SoLuong, DonGia) values " +
                             "('" + phieuNhap.MA_PN + "', '" + tmp.MA_NL + "', '" + int.Parse(gridviewDetails.Rows[rows].Cells[3].Value.ToString()) + "', '" + int.Parse(tbPrice.Text) + "') ";
                        this.Connection.OpenConnection();
                        SqlCommand command = this.Connection.CreateSQLCmd(sql);
                        command.ExecuteNonQuery();
                        Connection.CloseConnection();

                        sql = "update PHIEUNHAP set TriGia = '"+total+"'where MaPN = '"+ phieuNhap.MA_PN+"'";
                        this.Connection.OpenConnection();
                        command = this.Connection.CreateSQLCmd(sql);
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

            btnSeen.Visible = false;
            isSeenDetail = false;

            btnRemoveDetail.Enabled = btnUpdate.Enabled = false;
            cbMaterial.Text = tbPrice.Text =null;
            numeric.Value = 0;

            gridviewDetails.Rows.Clear();

            LoadDataGeneral();
        }

        int indexDetail;
        private void gridviewDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemoveDetail.Enabled = btnUpdate.Enabled = true;
            cbMaterial.Text = gridviewDetails.SelectedRows[0].Cells[1].Value.ToString() + " (" +
                gridviewDetails.SelectedRows[0].Cells[2].Value.ToString() +")";
            numeric.Value = int.Parse(gridviewDetails.SelectedRows[0].Cells[3].Value.ToString());
            tbPrice.Text = gridviewDetails.SelectedRows[0].Cells[4].Value.ToString();
            indexDetail = gridviewDetails.SelectedRows[0].Index;
        }

        private void btnRemoveGeneral_Click(object sender, EventArgs e)
        {
            btnSeen.Visible = false;
            PhieuNhap phieuNhap = new PhieuNhap();
            phieuNhap.MA_PN = gridviewGeneral.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                // delete data in CT_PHIEUNHAP
                string sql = "delete from CT_PHIEUNHAP where MaPN = '" + phieuNhap.MA_PN + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
                Connection.CloseConnection();

                // delete data in PHIEUNHAP
                sql = "delete from PHIEUNHAP where MaPN = '" + phieuNhap.MA_PN + "'";
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
                LoadDataGeneral();
                gridviewDetails.Rows.Clear();
            }
        }

       
    }
}
