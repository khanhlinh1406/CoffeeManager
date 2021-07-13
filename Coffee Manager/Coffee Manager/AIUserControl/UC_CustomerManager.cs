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
        List<LoaiKhachHang> listMembership = new List<LoaiKhachHang>();
        public UC_CustomerManager()
        {
            InitializeComponent();
        }

        public void UC_CustomerManager_Load(object sender, EventArgs e)
        {
            btnExit.Enabled = btnUpdate.Enabled = btnRemove.Enabled = false;
            dor.Value = DateTime.Now;
            point.Text = "";
            LoadData();
        }

        void LoadData()
        {
            try
            {
                string find = "SELECT MaKH, TenKH, NgSinh, SoDT, DiaChi, NgDK, diem, LoaiKH FROM KHACHHANG KH join LOAIKHACHHANG L on KH.MaLKH = L.MaLKH";
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

        void CreateNewCustomerMembership(KhachHang khachHang)
        {
            LoaiKhachHang tmp;
            listMembership.Clear();
            try
            {
                this.Connection.OpenConnection();
                string find = "SELECT * from LOAIKHACHHANG where DiemLH = 0";
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    tmp = new LoaiKhachHang(reader.GetString(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetInt32(4));
                    khachHang.LOAI_KH.Ma_LKH = tmp.Ma_LKH;
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



        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string find = "SELECT MaKH, TenKH, NgSinh, SoDT, DiaChi, NgDK, diem, LoaiKH FROM KHACHHANG KH join LOAIKHACHHANG L on KH.MaLKH = L.MaLKH where TenKH LIKE '" + tbSearch.Text + "%'";
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
            btnExit.Enabled = btnUpdate.Enabled = btnRemove.Enabled = true;
            btnAdd.Enabled = false;

            txtName.Text = gridview.SelectedRows[0].Cells[1].Value.ToString();
            dob.Value = DateTime.Parse(gridview.SelectedRows[0].Cells[2].Value.ToString());
            txtPhone.Text = gridview.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text = gridview.SelectedRows[0].Cells[4].Value.ToString();
            dor.Value = DateTime.Parse(gridview.SelectedRows[0].Cells[5].Value.ToString());
            point.Text = gridview.SelectedRows[0].Cells[6].Value.ToString();
            membership.Text = gridview.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnExit.Enabled = btnUpdate.Enabled = btnRemove.Enabled = false;

            txtName.Text = "";
            dob.Value = dor.Value = DateTime.Now;
            txtPhone.Text =
            txtAddress.Text = "";
            point.Text = "0";
            membership.Text = "Loại thành viên";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData() && CompareDate())
            {
                KhachHang add = new KhachHang(txtName.Text, dob.Value, txtPhone.Text, txtAddress.Text, dor.Value, 0, new LoaiKhachHang());
                CreateNewCustomerMembership(add);
                add.Add();
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidData() && CompareDate())
            {
                KhachHang update = new KhachHang(gridview.SelectedRows[0].Cells[0].Value.ToString(), txtName.Text, dob.Value, txtPhone.Text, txtAddress.Text, dor.Value, int.Parse(point.Text));
                update.Update();
                LoadData();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xoá khách hàng này ra khỏi danh sách?", "Xoá khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                KhachHang remove = new KhachHang(gridview.SelectedRows[0].Cells[0].Value.ToString(), txtName.Text, dob.Value, txtPhone.Text, txtAddress.Text, dor.Value, int.Parse(point.Text));
                remove.Remove();
                LoadData();
            }
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

        bool IsValidData()
        {
            if (txtName.Text != "" &&
                txtPhone.Text != "" &&
                txtPhone.Text != "")
                return true;
            MessageBox.Show("Dữ liệu không hợp lệ, trường dữ liệu bị trống", "Sai dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        bool CompareDate()
        {
            if (dob.Value < dor.Value)
                return true;
            MessageBox.Show("Dữ liệu không hợp lệ, ngày sinh phải trước ngày đăng kí", "Sai dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            //gridview.Update();
            LoadData();
        }
    }
}
