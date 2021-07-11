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
    public partial class UC_UpdateItems : UserControl
    {
        Connect Connection = new Connect();
        List<DonViTinh> listDVT = new List<DonViTinh>();
        string MaMon;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        public void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadListDVT();
        }

        void LoadListDVT()
        {
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
        void LoadData()
        {
            try
            {
                
                string find = "SELECT MaMon, TenMon, TenDVT, Gia FROM MON A JOIN DONVITINH B on A.MaDVT = B.MaDVT ";
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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string find = "SELECT MaMon, TenMon, TenDVT, Gia FROM MON A JOIN DONVITINH B on A.MaDVT = B.MaDVT " +
                    "where A.TenMon LIKE '"+tbSearch.Text+"%'";
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

       
        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbName.Text = gridview.SelectedRows[0].Cells[1].Value.ToString();
            tbPrice.Text = gridview.SelectedRows[0].Cells[3].Value.ToString();
            cbCalculationUnit.Text = gridview.SelectedRows[0].Cells[2].Value.ToString();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Mon update = new Mon(tbName.Text, int.Parse(tbPrice.Text), listDVT[index]);
            update.MA_MON = gridview.SelectedRows[0].Cells[0].Value.ToString();
            update.Update();
            LoadData();
        }

        int index;
        private void cbCalculationUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cbCalculationUnit.SelectedIndex;
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
    }
}
