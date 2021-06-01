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
        bool isSeen = false;
        
        public UC_ReceivedNote()
        {
            InitializeComponent();
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
            isSeen = false;
        }

        void LoadDataDetail(string MaPN)
        {
            try
            {
                
                string find = "SELECT MaNL, TenNL, SoLuong, MaDVT, TenDVT, TriGia FROM NGUYENLIEU NL, DONVITINH DVT, CT_PHIEUNHAP CT WHERE CT.MaNL = NL.MaNL and CT.MaDVT = DVT.MaDVT and PN.MaPN = '"+MaPN+"'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(find);

                SqlDataReader reader = command.ExecuteReader();

                List<NguyenLieu> listNL = new List<NguyenLieu>();
                List<int> listSL = new List<int>();
                gridviewDetails.Rows.Clear();

                while (reader.HasRows)
                {
                    
                    if (reader.Read() == false) break;
                    NguyenLieu tmp = new NguyenLieu(reader.GetString(0), reader.GetString(1), reader.GetInt32(5), new DonViTinh(reader.GetString(3), reader.GetString(4)));
                    listSL.Add(reader.GetInt32(2));
                    listNL.Add(tmp);
                    gridviewDetails.Rows.Add(tmp.TEN_NL, tmp.DVT.TEN_DVT, reader.GetInt32(2), tmp.TRI_GIA, tmp.TRI_GIA * reader.GetInt32(2));
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
            try
            {
                string find = "SELECT MaNL, TenNL, TriGia, TenDVT FROM NGUYENLIEU NL JOIN DONVITINH DVT ON NL.MaDVT = DVT.TenDVT";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {

                    if (reader.Read() == false) break;
                    NguyenLieu tmp = new NguyenLieu(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), new DonViTinh(reader.GetString(3), reader.GetString(4))) ;
                    listNL.Add(tmp);
                    cbMaterial.Items.Add(tmp.TEN_NL);
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
            gridviewDetails.Rows.Add(listNL[index].TEN_NL, listNL[index].DVT.TEN_DVT, numeric.Value, listNL[index].TRI_GIA, numeric.Value * listNL[index].TRI_GIA);
        }


        int index;

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cbMaterial.SelectedIndex;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            gridviewDetails.SelectedRows[0].Cells[0].Value = listNL[index].TEN_NL;
            gridviewDetails.SelectedRows[0].Cells[1].Value = listNL[index].DVT.TEN_DVT;
            gridviewDetails.SelectedRows[0].Cells[1].Value = numeric.Value;
            gridviewDetails.SelectedRows[0].Cells[1].Value = listNL[index].TRI_GIA;
            gridviewDetails.SelectedRows[0].Cells[1].Value = numeric.Value * listNL[index].TRI_GIA;
                //Add(listNL[index].TEN_NL, listNL[index].DVT.TEN_DVT, numeric.Value, listNL[index].TRI_GIA, numeric.Value * listNL[index].TRI_GIA);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            gridviewDetails.Rows.RemoveAt(index);
        }

        private void UC_ReceivedNote_Load(object sender, EventArgs e)
        {
            LoadDataGeneral();
            LoadListNL();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (isSeen)
            {
                //add new
            }    
            else
            {
                // update
            }
        }

        private void btnSeen_Click(object sender, EventArgs e)
        {
            isSeen = true;
        }
    }
}
