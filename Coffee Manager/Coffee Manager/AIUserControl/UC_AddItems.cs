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

        }

        public void UC_AddItems_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadListDVT();
            LoadStatusComboBox();
        }

        void LoadListDVT()
        {
            try
            {
                this.Connection.OpenConnection();
                string find = "SELECT MaDVTM, TenDVTM from DVT_MON";
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                adapter.Fill(data);
                cbCalculationUnit.DataSource = data.Tables[0];
                cbCalculationUnit.DisplayMember = "TenDVTM";
                cbCalculationUnit.ValueMember = "MaDVTM";
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
            if (IsValidData() && CheckValidPrice())
            {
                Mon add = new Mon(tbItemName.Text, int.Parse(tbPrice.Text),
                    new DonViTinh(cbCalculationUnit.SelectedValue.ToString(), cbCalculationUnit.Text.ToString()),
                    new TinhTrang(cbStatusMon.SelectedValue.ToString(), cbStatusMon.Text.ToString()));

                add.Add();
                LoadData();
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

        private void LoadStatusComboBox()
        {
            try
            {
                this.Connection.OpenConnection();
                string find = "SELECT MaTT, TenTT from TINHTRANGMON";
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet data = new DataSet();
                adapter.Fill(data);
                cbStatusMon.DataSource = data.Tables[0];
                cbStatusMon.DisplayMember = "TenTT";
                cbStatusMon.ValueMember = "MaTT";
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

                string find = "SELECT MaMon, TenMon, TenDVTM, Gia, TenTT FROM DVT_MON B join MON A on A.MaDVTM = B.MaDVTM join TINHTRANGMON C on A.MaTT = C.MaTT";
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

        bool IsValidData()
        {


            if (cbCalculationUnit.Text != ""
                && cbStatusMon.Text != ""
                && tbItemName.Text != ""
                && tbPrice.Text != "")
                return true;

            MessageBox.Show("Dữ liệu không hợp lệ, trường dữ liệu bị trống", "Sai dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        bool CheckValidPrice()
        {
            bool isNumeric = int.TryParse(tbPrice.Text, out int n);
            if (isNumeric)
                return true;


            MessageBox.Show("Dữ liệu không hợp lệ, giá tiền phải là số", "Sai dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }


    }
}
