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
        }

        private void LoadData()
        {
            try
            {

                string find = "SELECT A.MaNV, A.TenNV, A.NgSinh, A.SDT, A.NgVaoLam, C.TenCV, A.MaTK, B.MatKhau FROM NHANVIEN A, TAIKHOAN B, CHUCVU C WHERE A.MATK = B.MATK AND A.MaCV = C.MaCV";
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
     
      
        private void ComboBoxChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txtName.Text, txtPhone.Text, ComboBoxChucVu.ValueMember, matktxt.Text, guna2DateTimePicker1.Value, guna2DateTimePicker2.Value);
            nv.Add();

            User user = new User(matktxt.Text, passtxt.Text);
            user.AddUserToDatabase();
            LoadData();    
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(gridview.SelectedRows[0].Cells[0].Value.ToString(), txtName.Text, txtPhone.Text, ComboBoxChucVu.ValueMember, matktxt.Text, guna2DateTimePicker1.Value, guna2DateTimePicker2.Value);
            nv.Update();
            User user = new User(matktxt.Text, passtxt.Text);
            user.AddUserToDatabase();
            LoadData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(gridview.SelectedRows[0].Cells[0].Value.ToString(), txtName.Text, txtPhone.Text, ComboBoxChucVu.ValueMember, matktxt.Text, guna2DateTimePicker1.Value, guna2DateTimePicker2.Value);
            nv.Remove();
            User user = new User(matktxt.Text, passtxt.Text);
            user.DeleteUser();
            LoadData();
        }
    }
}
