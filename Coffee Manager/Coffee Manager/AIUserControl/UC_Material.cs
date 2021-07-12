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
    public partial class UC_Material : UserControl
    {
        Connect Connection = new Connect();
        List<DonViTinh> listDVT = new List<DonViTinh>();
        
        public UC_Material()
        {
            InitializeComponent();
            btnExit.Visible = btnUpdate.Visible = btnRemove.Visible = false;
        }

        public void UC_Material_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadListDVT();
        }

        void LoadData()
        {
            try
            {
                string find = "SELECT MaNL, TenNL, TenDVTNL FROM NGUYENLIEU A JOIN DVT_NGUYENLIEU B on A.MaDVTNL = B.MaDVTNL ";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                gridview.DataSource = dataSet.Tables[0];
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

        void LoadListDVT()
        {
            try
            {
                this.Connection.OpenConnection();
                string find = "SELECT MaDVTNL, TenDVTNL from DVT_NGUYENLIEU";
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                adapter.Fill(data);
                cbCalculationUnit.DataSource = data.Tables[0];
                cbCalculationUnit.DisplayMember = "TenDVTNL";
                cbCalculationUnit.ValueMember = "MaDVTNL";
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

        private void bAddItem_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                NguyenLieu nguyenLieu = new NguyenLieu(tbItemName.Text, new DonViTinh(cbCalculationUnit.SelectedValue.ToString(), cbCalculationUnit.Text.ToString()));
                nguyenLieu.Add();

                tbItemName.Text = "";
                LoadData();
            }
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                NguyenLieu nguyenLieu = new NguyenLieu(gridview.SelectedRows[0].Cells[0].Value.ToString(),
                    tbItemName.Text, new DonViTinh(cbCalculationUnit.SelectedValue.ToString(), cbCalculationUnit.Text.ToString()));
                nguyenLieu.Update();

                btnExit_Click(sender, e);
                LoadData();
            }
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbItemName.Text = gridview.SelectedRows[0].Cells[1].Value.ToString();
            cbCalculationUnit.Text = gridview.SelectedRows[0].Cells[2].Value.ToString();

            btnAddItem.Visible = false;
            btnExit.Visible = btnUpdate.Visible = btnRemove.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn nguyên liệu món này?", "Xoá nguyên liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                NguyenLieu nguyenLieu = new NguyenLieu(gridview.SelectedRows[0].Cells[0].Value.ToString(),
                    tbItemName.Text, new DonViTinh(cbCalculationUnit.SelectedValue.ToString(), cbCalculationUnit.Text.ToString()));
                nguyenLieu.Remove();

                btnExit_Click(sender, e);
                LoadData();
            }
        }

        private bool IsValidData()
        {
            if (tbItemName.Text != "" && cbCalculationUnit.Text != "")
                return true;

            MessageBox.Show("Dữ liệu không hợp lệ, trường dữ liệu bị trống", "Sai dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit.Visible = btnUpdate.Visible = btnRemove.Visible = false;
            btnAddItem.Visible = true;

            tbItemName.Text = cbCalculationUnit.Text = "";
        }
    }
}
