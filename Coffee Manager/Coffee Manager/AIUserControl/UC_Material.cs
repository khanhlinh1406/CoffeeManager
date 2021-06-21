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
                string find = "SELECT MaNL, TenNL, TenDVT FROM NGUYENLIEU A JOIN DONVITINH B on A.MaDVT = B.MaDVT ";
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
            cbCalculationUnit.Items.Clear();
            try
            {
                string find = "SELECT MaDVT, TenDVT FROM DONVITINH";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    DonViTinh tmp = new DonViTinh(reader.GetString(0), reader.GetString(1));
                    listDVT.Add(tmp);
                    cbCalculationUnit.Items.Add(tmp.TEN_DVT);
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

        private void bAddItem_Click(object sender, EventArgs e)
        {
            NguyenLieu nguyenLieu = new NguyenLieu(tbItemName.Text, listDVT[index]);
            nguyenLieu.Add();
            LoadData();
        }

        int index;

        private void cbCalculationUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cbCalculationUnit.SelectedIndex;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NguyenLieu nguyenLieu = new NguyenLieu(gridview.SelectedRows[0].Cells[0].Value.ToString(),
                tbItemName.Text, listDVT[index]);
            nguyenLieu.Update();
            LoadData();
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbItemName.Text = gridview.SelectedRows[0].Cells[1].Value.ToString();
            cbCalculationUnit.Text = gridview.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            NguyenLieu nguyenLieu = new NguyenLieu(gridview.SelectedRows[0].Cells[0].Value.ToString(),
                tbItemName.Text, listDVT[index]);
            nguyenLieu.Remove();
            LoadData();
        }
    }
}
