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
    public partial class UC_PlaceOrder : UserControl
    {
        List<Mon> danhSachMon = new List<Mon> ();
        List<DonViTinh> danhSachDVT = new List<DonViTinh>();
        int totalCost = 0;
        Connect connect = new Connect();

        public UC_PlaceOrder()
        {
            InitializeComponent();
            cbCalculationUnit.Items.Add("*");
        }

        private void LoadMenu()
        {
            try
            {
                string sql = "select * from MON";
                connect.OpenConnection();
                SqlCommand command = connect.CreateSQLCmd(sql);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    DonViTinh dvt = new DonViTinh(reader.GetString(2));
                    Mon mon = new Mon(reader.GetString(0), reader.GetString(1), reader.GetInt32(3), dvt);
                    danhSachMon.Add(mon);
                }
                reader.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
            finally
            {
                this.connect.CloseConnection();
            }
        }

        void LoadListDVT()
        {
            try
            {
                string find = "SELECT MaDVT, TenDVT FROM DONVITINH";
                this.connect.OpenConnection();
                SqlCommand command = this.connect.CreateSQLCmd(find);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {

                    if (reader.Read() == false) break;
                    DonViTinh tmp = new DonViTinh(reader.GetString(0), reader.GetString(1));
                    danhSachDVT.Add(tmp);
                    cbCalculationUnit.Items.Add(tmp.TEN_DVT);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");

            }
            finally
            {
                this.connect.CloseConnection();
            }
        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {
            LoadMenuToDataGridView();
            LoadListDVT();
        }

        private void LoadMenuToDataGridView()
        {
            LoadMenu();
            for (int i = 0; i < danhSachMon.Count; i++)
            {
                menuGridView.Rows.Add(danhSachMon[i].TEN_MON, danhSachMon[i].GIA);
            }
        }

        private void tbxOrderItemQuantity_ValueChanged(object sender, EventArgs e)
        {
            int tempCost = int.Parse(tbxOrderItemPrice.Text) * int.Parse(tbxOrderItemQuantity.Value.ToString());
            tbxOrderItemCost.Text = tempCost.ToString();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            orderGridView.Rows.Add(tbxOrderItemName.Text, findTenDVTFromList(),
                tbxOrderItemQuantity.Value.ToString(), tbxOrderItemCost.Text);
            totalCost += int.Parse(tbxOrderItemCost.Text);
            lbTotalCost.Text = this.totalCost.ToString() + " VND";
            btnRemoveItem.Enabled = true;
        }

        private string findTenDVTFromList()
        {
            for (int i = 0; i < danhSachDVT.Count; i++)
            {
                if (danhSachDVT[i].MA_DVT == danhSachMon[menuGridView.CurrentRow.Index].DVT.MA_DVT)
                {
                    return danhSachDVT[i].TEN_DVT;
                }
            }
            return "";
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (orderGridView.SelectedRows.Count > 0)
            {
                totalCost -= int.Parse(orderGridView.SelectedRows[0].Cells[3].Value.ToString());
                lbTotalCost.Text = totalCost.ToString() + " VND";
                orderGridView.Rows.Remove(orderGridView.SelectedRows[0]);
            }
        }

        private void orderGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (orderGridView.Rows.Count == 0)
            {
                btnRemoveItem.Enabled = false;
            }
        }

        private void menuGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxOrderItemName.Text = menuGridView.SelectedRows[0].Cells[0].Value.ToString();
            tbxOrderItemPrice.Text = menuGridView.SelectedRows[0].Cells[1].Value.ToString();
            int tempCost = int.Parse(tbxOrderItemPrice.Text) * int.Parse(tbxOrderItemQuantity.Value.ToString());
            tbxOrderItemCost.Text = tempCost.ToString();
            btnAddToCart.Enabled = true;
        }
    }
}
