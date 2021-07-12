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
            LoadListNhaCC();
            LoadDataGeneral();
            LoadListNL();
        }

        public void LoadDataGeneral()
        {
            try
            {

                string find = "SELECT MaPN, NgNhap, TriGia, B.TenNCC as NhaCungCap FROM PHIEUNHAP A join NHACUNGCAP B on A.MaNCC = B.MaNCC";
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
            cbNCC.Text = gridviewGeneral.SelectedRows[0].Cells[3].Value.ToString();
            isSeenDetail = true;
            btnSeen.Visible = true;
        }

        void LoadDataDetail(string MaPN)
        {
            try
            {
                
                string find = "SELECT NL.MaNL, NL.TenNL, CT.SoLuong, NL.MaDVTNL, DVT.TenDVTNL, CT.DonGia FROM NGUYENLIEU NL join CT_PHIEUNHAP CT on CT.MaNL = NL.MaNL join DVT_NGUYENLIEU DVT on NL.MaDVTNL = DVT.MaDVTNL where CT.MaPN = '"+MaPN+"'";
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

        void LoadListNhaCC()
        {
            try
            {
                this.Connection.OpenConnection();
                string find = "SELECT MaNCC, TenNCC from NHACUNGCAP";
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                adapter.Fill(data);
                cbNCC.DataSource = data.Tables[0];
                cbNCC.DisplayMember = "TenNCC";
                cbNCC.ValueMember = "MaNCC";
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
        void LoadListNL()
        {
            cbMaterial.Items.Clear();
            try
            {
                this.Connection.OpenConnection();
                string find = "SELECT NL.MaNL, NL.TenNL, DVT.MaDVTNL, DVT.TenDVTNL FROM NGUYENLIEU NL left JOIN DVT_NGUYENLIEU DVT ON NL.MaDVTNL = DVT.MaDVTNL";
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
            if (IsValidData()&& CheckValidNumber())
                gridviewDetails.Rows.Add(listNL[indexMaterial].MA_NL,listNL[indexMaterial].TEN_NL, listNL[indexMaterial].DVT.TEN_DVT, numeric.Value, int.Parse(tbPrice.Text), numeric.Value * int.Parse(tbPrice.Text));
        }


        int indexMaterial;

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexMaterial = cbMaterial.SelectedIndex;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidData() && CheckValidNumber())
            {
                gridviewDetails.SelectedRows[0].Cells[0].Value = listNL[indexMaterial].MA_NL;
                gridviewDetails.SelectedRows[0].Cells[1].Value = listNL[indexMaterial].TEN_NL;
                gridviewDetails.SelectedRows[0].Cells[2].Value = listNL[indexMaterial].DVT.TEN_DVT;
                gridviewDetails.SelectedRows[0].Cells[3].Value = numeric.Value;
                gridviewDetails.SelectedRows[0].Cells[4].Value = tbPrice.Text;
                gridviewDetails.SelectedRows[0].Cells[5].Value = numeric.Value * int.Parse(tbPrice.Text);

                btnUpdate.Enabled = btnRemoveDetail.Enabled = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xoá nguyên liệu này ra khỏi phiếu nhập?", "Xoá nguyên liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                gridviewDetails.Rows.RemoveAt(indexDetail);
                btnUpdate.Enabled = btnRemoveDetail.Enabled = false;

            }

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

        private void AddNewReceivedNote(int total)
        {
            List<NguyenLieu> listNguyenLieu = new List<NguyenLieu>();
            List<int> SL = new List<int>();

            PhieuNhap phieuNhap = new PhieuNhap();
            phieuNhap.TRI_GIA = total;
            phieuNhap.NG_NHAP = date.Value;
            phieuNhap.CreateMaPN();
            phieuNhap.NHA_CC = new NhaCungCap(cbNCC.SelectedValue.ToString(), cbNCC.Text.ToString(), "");

            phieuNhap.Add();

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
        private void UpdateOldReceivedNote(int total)
        {
            List<NguyenLieu> listNguyenLieu = new List<NguyenLieu>();

            PhieuNhap phieuNhap = new PhieuNhap();
            phieuNhap.MA_PN = gridviewGeneral.SelectedRows[0].Cells[0].Value.ToString();
            phieuNhap.NHA_CC = new NhaCungCap(cbNCC.SelectedValue.ToString(), cbNCC.Text.ToString(), "");

            try
            {
                string sql = "delete from CT_PHIEUNHAP where MaPN = '" + phieuNhap.MA_PN + "'";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sql);
                command.ExecuteNonQuery();
                Connection.CloseConnection();
            }
            catch (Exception err)
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
                         "('" + phieuNhap.MA_PN + "', '" + tmp.MA_NL + "', '" + int.Parse(gridviewDetails.Rows[rows].Cells[3].Value.ToString()) + "', '" + int.Parse(gridviewDetails.Rows[rows].Cells[4].Value.ToString()) + "') ";
                    this.Connection.OpenConnection();
                    SqlCommand command = this.Connection.CreateSQLCmd(sql);
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

                phieuNhap.NG_NHAP = date.Value;
                phieuNhap.TRI_GIA = total;
                phieuNhap.Update();
                
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            int total = 0;
            
            for (int rows = 0; rows < gridviewDetails.Rows.Count; rows++)
                total += int.Parse(gridviewDetails.Rows[rows].Cells[5].Value.ToString());

            if (isSeenDetail == false)
            {

                //add new
                AddNewReceivedNote(total);

            }
            else
            {
                // update
                UpdateOldReceivedNote(total);
               
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
            var result = MessageBox.Show("Bạn có muốn xoá phiếu nhập này?", "Xoá phiếu nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                btnSeen.Visible = false;
                PhieuNhap phieuNhap = new PhieuNhap();
                phieuNhap.MA_PN = gridviewGeneral.SelectedRows[0].Cells[0].Value.ToString();

                LoadDataGeneral();
                gridviewDetails.Rows.Clear();
            }
        }

        private void numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        bool IsValidData()
        {
            if (cbNCC.Text != ""
                && cbMaterial.Text != ""
                && tbPrice.Text != ""
                && numeric.Text != "")
                return true;

            MessageBox.Show("Dữ liệu không hợp lệ, trường dữ liệu bị trống", "Sai dữ liệu", MessageBoxButtons.OK);
            return false;
        }

        bool CheckValidNumber()
        {

            if (int.TryParse(tbPrice.Text, out int n) && int.TryParse(numeric.Text, out int m))
                return true;

            if (int.TryParse(tbPrice.Text, out int a))
                MessageBox.Show("Dữ liệu không hợp lệ, đơn giá phải là số", "Sai dữ liệu", MessageBoxButtons.OK);

            if (int.TryParse(numeric.Text, out int b))
                MessageBox.Show("Dữ liệu không hợp lệ, số lượng phải là số", "Sai dữ liệu", MessageBoxButtons.OK);

            if (numeric.Value == 0)
                MessageBox.Show("Dữ liệu không hợp lệ, số lượng phải khác 0", "Sai dữ liệu", MessageBoxButtons.OK);
            return false;

        }



    }
}
