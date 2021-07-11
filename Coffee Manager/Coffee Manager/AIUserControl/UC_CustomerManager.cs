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
    public partial class UC_CustomerManager : UserControl
    {
        Connect Connection = new Connect();
        public UC_CustomerManager()
        {
            InitializeComponent();
        }

        public void UC_CustomerManager_Load(object sender, EventArgs e)
        {
            btnExit.Visible = btnUpdate.Visible = btnRemove.Visible = false;
            dor.Value = DateTime.Now;
            point.Text = "";
            LoadData();
        }

        void LoadData()
        {
            try
            {

                string find = "SELECT * FROM KHACHHANG";
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
                string find = "SELECT * from KHACHHANG where TenKH LIKE '" + tbSearch.Text + "%'";
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
            btnExit.Visible = btnUpdate.Visible = btnRemove.Visible = true;
            btnAdd.Visible = false;

            txtName.Text = gridview.SelectedRows[0].Cells[1].Value.ToString();
            dob.Value = DateTime.Parse(gridview.SelectedRows[0].Cells[2].Value.ToString());
            txtPhone.Text = gridview.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text = gridview.SelectedRows[0].Cells[4].Value.ToString();
            dor.Value = DateTime.Parse(gridview.SelectedRows[0].Cells[5].Value.ToString());
            point.Text = gridview.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnExit.Visible = btnUpdate.Visible = btnRemove.Visible = false;

            txtName.Text = "";
            dob.Value = dor.Value = DateTime.Now;
            txtPhone.Text =
            txtAddress.Text = "";
            point.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //KhachHang add = new KhachHang(txtName.Text, dob.Value, txtPhone.Text, txtAddress.Text, dor.Value, 0);
            //add.Add();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //KhachHang update = new KhachHang(gridview.SelectedRows[0].Cells[0].Value.ToString(),txtName.Text, dob.Value, txtPhone.Text, txtAddress.Text, dor.Value, int.Parse(point.Text));
            //update.Update();
            LoadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //KhachHang remove = new KhachHang(gridview.SelectedRows[0].Cells[0].Value.ToString(),txtName.Text, dob.Value, txtPhone.Text, txtAddress.Text, dor.Value, int.Parse(point.Text));
            //remove.Remove();
            LoadData();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
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
