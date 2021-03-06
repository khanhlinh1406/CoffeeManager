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
    public partial class UC_RemoveItem : UserControl
    {
        Connect Connection = new Connect();
        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        public void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DelLabel_Click(object sender, EventArgs e)
        {

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string find = "SELECT MaMon, TenMon, TenDVTM, Gia FROM MON A JOIN DVT_MON B on A.MaDVTM = B.MaDVTM " +
                    "where A.TenMon LIKE '" + tbSearch.Text + "%'";
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
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xoá món này ra khỏi menu?", "Xoá món", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Mon update = new Mon();
                update.MA_MON = gridview.SelectedRows[0].Cells[0].Value.ToString();
                update.Remove();
                LoadData();
            }
        }
    }
}
