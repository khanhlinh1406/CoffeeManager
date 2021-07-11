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
    public partial class UC_AddItems : UserControl
    {
         List<DonViTinh> listDVT = new List<DonViTinh>();
        Connect Connection = new Connect();
        public UC_AddItems()
        {
            InitializeComponent();
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

        private void bAddItem_Click(object sender, EventArgs e)
        {
            Mon add = new Mon(tbItemName.Text, int.Parse(tbPrice.Text), listDVT[index]);
            add.Add();
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
