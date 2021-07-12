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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_StaffManager_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCBChucVu();
            guna2Button1.Enabled = false;
            update_savebtn.Enabled = false;
            btnExit.Enabled = false;
        }

        private void LoadData()
        {
            try
            {

                string find = "SELECT A.MaNV, A.TenNV, A.NgSinh, A.DiaChi, A.SDT, A.NgVaoLam, C.TenCV, A.MaTK, B.MatKhau FROM TAIKHOAN B join NHANVIEN A on B.MaTK = A.MaTK join CHUCVU C on A.MaCV = C.MaCV";
                this.Connection.OpenConnection();                                                                           
                SqlCommand command = this.Connection.CreateSQLCmd(find);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                gridview.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
               

            }
            finally
            {
                this.Connection.CloseConnection();
            }
        }
        public void LoadCBChucVu()
        {
            this.Connection.OpenConnection();
            string find = "SELECT MaCV, TenCV from CHUCVU";
            SqlCommand command = this.Connection.CreateSQLCmd(find);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            ComboBoxChucVu.DataSource = data.Tables[0];
            ComboBoxChucVu.DisplayMember = "TenCV";
            ComboBoxChucVu.ValueMember = "MaCV";
        }
     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(diachi_txt.Text)
                || string.IsNullOrWhiteSpace(matktxt.Text) || string.IsNullOrWhiteSpace(passtxt.Text))
            {
                MessageBox.Show("Chưa cung cấp đủ thông tin nhân viên. Hãy kiểm tra lại");
            }
            else
            {
                User user = new User(matktxt.Text, passtxt.Text);
                user.AddUserToDatabase();

                NhanVien nv = new NhanVien(txtName.Text, txtPhone.Text, ComboBoxChucVu.SelectedValue.ToString(), matktxt.Text, diachi_txt.Text, dob.Value, startingDate.Value);
                nv.Add();
                LoadData();
                MessageBox.Show("Thêm nhân viên thành công");
            } 
        }

      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //NhanVien nv = new NhanVien(txtName.Text, txtPhone.Text, ComboBoxChucVu.SelectedValue.ToString(), matktxt.Text, diachi_txt.Text, dob.Value, startingDate.Value);
            NhanVien nv = new NhanVien();
            nv.MA_NV = gridview.SelectedRows[0].Cells[0].Value.ToString();
            nv.Remove();
            User user = new User(matktxt.Text, passtxt.Text);
            user.DeleteUser();
           
            MessageBox.Show("Xóa nhân viên thành công");
            LoadData();
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExit.Enabled = true;
            btnAdd.Enabled = false;
            guna2Button1.Enabled = true;
            update_savebtn.Enabled = true;
            txtName.Text = gridview.SelectedRows[0].Cells[1].Value.ToString();
            dob.Value = DateTime.Parse(gridview.SelectedRows[0].Cells[2].Value.ToString());
            txtPhone.Text = gridview.SelectedRows[0].Cells[4].Value.ToString();
            startingDate.Value = DateTime.Parse(gridview.SelectedRows[0].Cells[5].Value.ToString());
           diachi_txt.Text = gridview.SelectedRows[0].Cells[3].Value.ToString();

            matktxt.Text = gridview.SelectedRows[0].Cells[7].Value.ToString();
           // matktxt.ReadOnly = true;
            passtxt.Text = gridview.SelectedRows[0].Cells[8].Value.ToString();

            matktxt.Enabled =  false;



            var item = ComboBoxChucVu.Items.Cast<Object>()
                .Where(x => ComboBoxChucVu.GetItemText(x).Equals(gridview.SelectedRows[0].Cells[6].Value.ToString()))
                .FirstOrDefault();
            var index = ComboBoxChucVu.Items.IndexOf(item);
            ComboBoxChucVu.SelectedIndex = index;
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(diachi_txt.Text)
               || string.IsNullOrWhiteSpace(matktxt.Text) || string.IsNullOrWhiteSpace(passtxt.Text))
            {
                MessageBox.Show("Chưa cung cấp đủ thông tin nhân viên. Hãy kiểm tra lại");
            }
            else
            {
                NhanVien nv = new NhanVien(gridview.SelectedRows[0].Cells[0].Value.ToString(), txtName.Text, txtPhone.Text, diachi_txt.Text, ComboBoxChucVu.SelectedValue.ToString(), matktxt.Text, dob.Value, startingDate.Value);

                User user = new User(matktxt.Text, passtxt.Text);
                user.updatePass();
                nv.Update();

                LoadData();
                MessageBox.Show("Cập nhật nhân viên thành công");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnExit.Enabled = false;
            txtName.Text = "";
            dob.Value = DateTime.Now;
            txtPhone.Text = "";
            startingDate.Value = DateTime.Now;
            diachi_txt.Text = "";

            matktxt.Text = "";
            // matktxt.ReadOnly = true;
            passtxt.Text = "";
            guna2Button1.Enabled = false;
            update_savebtn.Enabled = false;
            matktxt.Enabled = true;
        }
    }
}
