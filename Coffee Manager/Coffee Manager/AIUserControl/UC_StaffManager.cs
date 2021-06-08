using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public partial class UC_StaffManager : UserControl
    {

        Connect Connection = new Connect();
        public UC_StaffManager()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {

                string find = "SELECT * FROM NHANVIEN";
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhanVien add = new NhanVien(txtName.Text, txtPhone.Text, txtAddress.Text, txtPosition.Text, txtAccount.Text, dob.Value, dow.Value);
            add.Add();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
