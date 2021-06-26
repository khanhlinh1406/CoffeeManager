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

                string find = "SELECT A.MaNV, A.TenNV, A.NgSinh, A.SDT, A.NgVaoLam, C.TenCV, A.MaTK, B.MatKhau FROM TAIKHOAN B join NHANVIEN A on B.MaTK = A.MaTK join CHUCVU C on A.MaCV = C.MaCV";
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
     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User(matktxt.Text, passtxt.Text);
            user.AddUserToDatabase();

            NhanVien nv = new NhanVien(txtName.Text, txtPhone.Text, ComboBoxChucVu.SelectedValue.ToString(), matktxt.Text, dob.Value, startingDate.Value);
            nv.Add();
            
            LoadData();    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(gridview.SelectedRows[0].Cells[0].Value.ToString(), txtName.Text, txtPhone.Text, ComboBoxChucVu.ValueMember, matktxt.Text, dob.Value, startingDate.Value);
            nv.Update();

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(gridview.SelectedRows[0].Cells[0].Value.ToString(), txtName.Text, txtPhone.Text, ComboBoxChucVu.SelectedValue.ToString(), matktxt.Text, dob.Value, startingDate.Value);
            nv.Remove();

            User user = new User(matktxt.Text, passtxt.Text);
            user.DeleteUser();

            LoadData();
        }

        private void gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = gridview.SelectedRows[0].Cells[1].Value.ToString();
            dob.Value = DateTime.Parse(gridview.SelectedRows[0].Cells[2].Value.ToString());
            txtPhone.Text = gridview.SelectedRows[0].Cells[3].Value.ToString();
            startingDate.Value = DateTime.Parse(gridview.SelectedRows[0].Cells[4].Value.ToString());

            matktxt.Text = gridview.SelectedRows[0].Cells[6].Value.ToString();
            passtxt.Text = gridview.SelectedRows[0].Cells[7].Value.ToString();

            matktxt.Enabled = passtxt.Enabled = false;



            var item = ComboBoxChucVu.Items.Cast<Object>()
                .Where(x => ComboBoxChucVu.GetItemText(x).Equals(gridview.SelectedRows[0].Cells[5].Value.ToString()))
                .FirstOrDefault();
            var index = ComboBoxChucVu.Items.IndexOf(item);
            ComboBoxChucVu.SelectedIndex = index;
        }
    }
}
