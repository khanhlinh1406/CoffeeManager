using Coffee_Manager.Class;
using Coffee_Manager.MainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manager.AIUserControl
{
    public partial class UC_Setting : UserControl
    {
        List<ChucVu> listChucVu = new List<ChucVu>();
        List<int> listCountCV = new List<int>();
        List<DonViTinh> listDVT = new List<DonViTinh>();
        List<LoaiKhachHang> listLoaiKH = new List<LoaiKhachHang>();
        List<int> listCountLoaiKH = new List<int>();
        Boolean IsEditingCustomer = false, IsAddingCustomer = false;
        Boolean IsEditingStore = false, IsAddingStore = false;

        Connect Connection = new Connect();

        ResourceManager rm = new ResourceManager("string", Assembly.GetExecutingAssembly());

        public UC_Setting()
        {
            InitializeComponent();
        }

        public void UC_Setting_Load(object sender, EventArgs e)
        {
            LoadUnit();
            LoadRoll();
            LoadCustomer();
        }

        private void tabSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabSetting.SelectedIndex == 0)
            {
                LoadUnit();
                LoadRoll();
            }
            else if (tabSetting.SelectedIndex == 1)
            {
                LoadCustomer();
            }

        }

        #region Customer

        private void LoadCustomer()
        {

            listViewLoaiKH.Rows.Clear();
            try
            {
                string sQuery = "select l.MaLKH, l.LoaiKH, l.PTgiam, l.PTramHD, l.DiemLH, count(MaKH) as sl " +
                                "from LOAIKHACHHANG l, KHACHHANG kh " +
                                "where l.MaLKH = kh.MaLKH " +
                                "group by l.MaLKH, l.LoaiKH, l.DiemLH, l.PTgiam, l.PTramHD union " +
                                "select l.MaLKH, l.LoaiKH, l.DiemLH, l.PTgiam, l.PTramHD, '0' as sl " +
                                "from LOAIKHACHHANG l " +
                                "where l.MaLKH not in (select MaLKH from KHACHHANG) ";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sQuery);
                SqlDataReader reader = command.ExecuteReader();
                int count = 1;
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;


                    listViewLoaiKH.Rows.Add(
                        count.ToString(),
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetDouble(2).ToString(),
                        reader.GetDouble(3).ToString(),
                        reader.GetDouble(4).ToString(),
                        reader.GetInt32(5).ToString()
                        );

                    listLoaiKH.Add(new LoaiKhachHang(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetDouble(2),
                        reader.GetDouble(3),
                        (int) reader.GetDouble(4)
                        ));
                    listCountLoaiKH.Add(reader.GetInt32(5));

                    count++;
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

        private void listViewLoaiKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listViewLoaiKH.SelectedRows.Count > 2)
                return;
            if (listViewLoaiKH.Rows.Count < 2)
                return;
            DataGridViewRow item = listViewLoaiKH.SelectedRows[0];
            tbxRankId.Text = item.Cells[1].Value.ToString();
            tbx_RankName.Text = item.Cells[2].Value.ToString();
            tbxBonusPer.Text = item.Cells[3].Value.ToString();
            tbxRankDiscountPer.Text = item.Cells[4].Value.ToString();
            tbxRankPoint.Text = item.Cells[5].Value.ToString();
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            if (tbxRankId.Text == "" ||
                tbx_RankName.Text == "" ||
                tbxBonusPer.Text == "" ||
                tbxRankDiscountPer.Text == "" ||
                tbxRankPoint.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            } 
            if (IsEditingCustomer)
            {
                try
                {
                    IsEditingCustomer = false;
                    LoaiKhachHang loaiKH = new LoaiKhachHang(
                        tbxRankId.Text,
                        tbx_RankName.Text,
                        double.Parse(tbxRankPoint.Text),
                        double.Parse(tbxRankDiscountPer.Text),
                        int.Parse(tbxRankPoint.Text));
                    if (loaiKH.CheckMaLKH())
                    {
                        IsEditingCustomer = true;
                        MessageBox.Show("Mã loại đã tồn tại!");
                        tbxRankId.Focus();
                        return;
                    }
                    else 
                        loaiKH.Update();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show("Định dạng không đúng, vui lòng nhập lại!");
                }
            }
            if (IsAddingCustomer)
            {
                try
                {
                    IsAddingCustomer = false;
                    LoaiKhachHang loaiKH = new LoaiKhachHang(
                        tbxRankId.Text,
                        tbx_RankName.Text,
                        double.Parse(tbxRankPoint.Text),
                        double.Parse(tbxRankDiscountPer.Text),
                        int.Parse(tbxRankPoint.Text));
                    if (loaiKH.CheckMaLKH())
                    {
                        IsAddingCustomer = true;
                        MessageBox.Show("Mã loại đã tồn tại!");
                        tbxRankId.Focus();
                        return;
                    }
                    else
                        loaiKH.Add();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show("Định dạng không đúng, vui lòng nhập lại!");
                }
            }

            tbxRankId.Enabled = false;
            tbxRankId.Text = "";
            tbx_RankName.Enabled = false;
            tbx_RankName.Text = "";
            tbxRankPoint.Enabled = false;
            tbxRankPoint.Text = "";
            tbxRankDiscountPer.Enabled = false;
            tbxRankDiscountPer.Text = "";
            tbxRankPoint.Enabled = false;
            tbxRankPoint.Text = "";

            LoadCustomer();
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            if (tbxRankId.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 loại khách hàng cần chỉnh sửa");
            }
            else
            {
                IsEditingCustomer = true;
                tbxRankId.Enabled = true;
                tbx_RankName.Enabled = true;
                tbxRankPoint.Enabled = true;
                tbxRankDiscountPer.Enabled = true;
                tbxRankPoint.Enabled = true;
                btnCustomerSave.Visible = true;
                btnCustomerCancel.Visible = true;
                btnCustomerEdit.Visible = false;
                btnCustomerDelete.Visible = false;
                btnCustomerAdd.Visible = false;

                tbxRankId.Focus();
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (tbxRankId.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 loại khách hàng cần xóa");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa, mọi thay đổi sẽ không thể hoàn tác?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (listViewLoaiKH.SelectedRows[0].Cells[6].Value.ToString() != "0")
                        {
                            MessageBox.Show("Không thể xóa loại khách hàng khi đang có khách hàng thuộc loại khách hàng này!");
                            return;
                        }
                        LoaiKhachHang loaiKH = new LoaiKhachHang(
                            tbxRankId.Text,
                            tbx_RankName.Text,
                            double.Parse(tbxRankPoint.Text),
                            double.Parse(tbxRankDiscountPer.Text),
                            int.Parse(tbxRankPoint.Text));
                        loaiKH.Delete();
                    }
                    catch (InvalidCastException ex)
                    {
                        MessageBox.Show("Định dạng không đúng, vui lòng nhập lại!");
                    }
                }
            }
        }

        private void btnCustomerCancel_Click(object sender, EventArgs e)
        {
            if (IsEditingCustomer || IsAddingCustomer)
            {
                if (MessageBox.Show("Mọi thay đổi hay thêm mới sẽ không được lưu, tiếp tục?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    IsAddingCustomer = false;
                    IsEditingCustomer = false;
                    tbxRankId.Enabled = false;
                    tbxRankId.Text = "";
                    tbx_RankName.Enabled = false;
                    tbx_RankName.Text = "";
                    tbxRankPoint.Enabled = false;
                    tbxRankPoint.Text = "";
                    tbxRankDiscountPer.Enabled = false;
                    tbxRankDiscountPer.Text = "";
                    tbxRankPoint.Enabled = false;
                    tbxRankPoint.Text = "";
                    btnCustomerSave.Visible = false;
                    btnCustomerCancel.Visible = false;
                    btnCustomerEdit.Visible = true;
                    btnCustomerDelete.Visible = true;
                }
            }
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            IsAddingCustomer = true;

            tbxRankId.Enabled = true;
            tbxRankId.Text = "";

            tbx_RankName.Enabled = true;
            tbx_RankName.Text = "";

            tbxBonusPer.Enabled = true;
            tbxBonusPer.Text = "";

            tbxRankDiscountPer.Enabled = true;
            tbxRankDiscountPer.Text = "";

            tbxRankPoint.Enabled = true;
            tbxRankPoint.Text = "";

            btnCustomerSave.Visible = true;
            btnCustomerCancel.Visible = true;
            btnCustomerEdit.Visible = false;
            btnCustomerDelete.Visible = false;
            btnCustomerAdd.Visible = false;

            tbxRankId.Focus();
        }

        #endregion

        #region Store

        private void LoadRoll()
        {
            listViewRoll.Rows.Clear();
            try
            {
                string sQueryDVT = "select cv.MaCV, cv.TenCV, count(nv.MaNV) as sl from CHUCVU cv, NHANVIEN nv where cv.MaCV = nv.MaCV group by cv.MaCV, cv.TenCV union select cv.MaCV, cv.TenCV, '0' as sl from CHUCVU cv where cv.MaCV not in (select MaCV from NHANVIEN)";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sQueryDVT);
                SqlDataReader reader = command.ExecuteReader();
                int count = 1;
                while (reader.HasRows)
                {


                    if (reader.Read() == false) break;

                    listViewRoll.Rows.Add(
                        count.ToString(), 
                        reader.GetString(0), 
                        reader.GetString(1),
                        reader.GetInt32(2).ToString());

                    listChucVu.Add(new ChucVu(
                        reader.GetString(0),
                        reader.GetString(1))
                        );
                    listCountCV.Add(reader.GetInt32(2));

                    count++;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
            finally
            {

                this.Connection.CloseConnection();
            }
        }

        private void LoadUnit()
        {
            listViewDVT.Rows.Clear();
            try
            {
                string sQueryDVT = "select MaDVTM as Ma, TenDVTM Ten, 'Mon' as kind from DVT_MON union select MaDVTNL as Ma, TenDVTNL as Ten, 'NguyenLieu' as kind from DVT_NGUYENLIEU";
                this.Connection.OpenConnection();
                SqlCommand command = this.Connection.CreateSQLCmd(sQueryDVT);
                SqlDataReader reader = command.ExecuteReader();
                int count = 1;
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;

                    listViewDVT.Rows.Add(
                        count.ToString(), 
                        reader.GetString(0),
                        reader.GetString(1), 
                        reader.GetString(2));

                    listDVT.Add(new DonViTinh(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2))
                        );
                    count++;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng liên hệ đội ngũ phát triển!");
            }
            finally
            {

                this.Connection.CloseConnection();
            }
        }

        private void btnSaveStore_Click(object sender, EventArgs e)
        {
            if (tbxIdStore.Text == "" ||
                tbxNameStore.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
            if (IsEditingStore)
            {
                if (lbIdStore.Text == "Mã đơn vị tính")
                {
                    try
                    {
                        IsEditingStore = false;
                        DonViTinh dvt = new DonViTinh(
                            tbxIdStore.Text,
                            tbxNameStore.Text);
                        if (dvt.CheckMaDVT(tbxType.Text))
                        {
                            IsEditingStore = true;
                            MessageBox.Show("Mã đơn vị tính đã tồn tại!");
                            tbxIdStore.Focus();
                            return;
                        } else 
                            dvt.Update(tbxType.Text);
                    }
                    catch (InvalidCastException ex)
                    {
                        MessageBox.Show("Định dạng không đúng, vui lòng nhập lại!");
                    }
                }
                else if (lbIdStore.Text == "Mã chức vụ")
                {
                    try
                    {
                        IsEditingStore = false;
                        ChucVu cv = new ChucVu(
                            tbxIdStore.Text,
                            tbxNameStore.Text);
                        if (cv.CheckMaCV())
                        {
                            IsEditingStore = true;
                            MessageBox.Show("Mã chức vụ đã tồn tại!");
                            tbxIdStore.Focus();
                            return;
                        }
                        else
                            cv.Update();
                    }
                    catch (InvalidCastException ex)
                    {
                        MessageBox.Show("Định dạng không đúng, vui lòng nhập lại!");
                    }
                }
            }
            if (IsAddingStore)
            {
                if (lbIdStore.Text == "Mã đơn vị tính")
                {
                    try
                    {
                        IsAddingStore = false;
                        DonViTinh dvt = new DonViTinh(
                            tbxIdStore.Text,
                            tbxNameStore.Text);
                        if (dvt.CheckMaDVT(tbxType.Text))
                        {
                            IsAddingStore = true;
                            MessageBox.Show("Mã đơn vị tính đã tồn tại!");
                            tbxIdStore.Focus();
                            return;
                        }
                        else
                            dvt.Add(tbxType.Text);
                    }
                    catch (InvalidCastException ex)
                    {
                        MessageBox.Show("Định dạng không đúng, vui lòng nhập lại!");
                    }
                }
                else if (lbIdStore.Text == "Mã chức vụ")
                {
                    try
                    {
                        IsAddingStore = false;
                        ChucVu cv = new ChucVu(
                            tbxIdStore.Text,
                            tbxNameStore.Text);
                        if (cv.CheckMaCV())
                        {
                            IsAddingStore = true;
                            MessageBox.Show("Mã chức vụ đã tồn tại!");
                            tbxIdStore.Focus();
                            return;
                        }
                        else
                            cv.Add();
                    }
                    catch (InvalidCastException ex)
                    {
                        MessageBox.Show("Định dạng không đúng, vui lòng nhập lại!");
                    }
                }
            }

            lbIdStore.Text = "Mã";
            lbNameStore.Text = "Tên";

            tbxIdStore.Enabled = false;
            tbxIdStore.Text = "";
            tbxNameStore.Enabled = false;
            tbxNameStore.Text = "";
            tbxType.Enabled = false;

            btnAddCV.Visible = true;
            btnAddDVT.Visible = true;
            btnDeleteStore.Visible = true;
            btnEditStore.Visible = true;
            btnSaveStore.Visible = false;
            btnCancelStore.Visible = false;

            LoadRoll();
            LoadUnit();
        }

        private void btnCancelStore_Click(object sender, EventArgs e)
        {
            if (IsEditingStore || IsAddingStore)
            {
                if (MessageBox.Show("Mọi thay đổi hay thêm mới sẽ không được lưu, tiếp tục?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    IsAddingStore = false;
                    IsEditingStore = false;
                    lbIdStore.Text = "Mã";
                    lbNameStore.Text = "Tên";

                    tbxIdStore.Enabled = false;
                    tbxIdStore.Text = "";
                    tbxNameStore.Enabled = false;
                    tbxNameStore.Text = "";
                    tbxType.Enabled = false;

                    btnAddCV.Visible = true;
                    btnAddDVT.Visible = true;
                    btnDeleteStore.Visible = true;
                    btnEditStore.Visible = true;
                    btnSaveStore.Visible = false;
                    btnCancelStore.Visible = false;
                }
            }
        }

        private void btnEditStore_Click(object sender, EventArgs e)
        {
            if (tbxIdStore.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 loại đơn vị tính hoặc chức vụ cần chỉnh sửa");
            }
            else
            {
                IsEditingStore = true;

                tbxIdStore.Enabled = true;
                tbxNameStore.Enabled = true;
                tbxType.Enabled = true;

                btnAddCV.Visible = false;
                btnAddDVT.Visible = false;
                btnDeleteStore.Visible = false;
                btnEditStore.Visible = false;
                btnSaveStore.Visible = true;
                btnCancelStore.Visible = true;

                tbxIdStore.Focus();
            }
        }

        private void btnDeleteStore_Click(object sender, EventArgs e)
        {
            if (tbxIdStore.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 loại khách hàng cần xóa");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa, mọi thay đổi sẽ không thể hoàn tác?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (lbIdStore.Text == "Mã chức vụ")
                    {
                        
                        try
                        {
                            if (int.Parse(listViewRoll.SelectedRows[0].Cells[3].Value.ToString()) != 0)
                            {
                                MessageBox.Show("Không thể xóa chức vụ khi đang có nhân việc thuộc chức vụ này!");
                                return;
                            }    
                                ChucVu cv = new ChucVu(
                               tbxIdStore.Text,
                               tbxNameStore.Text);
                            cv.Delete();
                        }
                        catch (InvalidCastException ex)
                        {
                            MessageBox.Show("Định dạng không đúng, vui lòng nhập lại!");
                        }

                        LoadRoll();
                    }
                    else if (lbIdStore.Text == "Mã đơn vị tính")
                    {
                        try
                        {
                            DonViTinh dvt = new DonViTinh(
                               tbxIdStore.Text,
                               tbxNameStore.Text);
                            dvt.Delete(listViewDVT.SelectedRows[0].Cells[3].Value.ToString());
                        }
                        catch (InvalidCastException ex)
                        {
                            MessageBox.Show("Định dạng không đúng, vui lòng nhập lại!");
                        }

                        LoadUnit();
                    }

                }
            }
        }

        private void listViewDVT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listViewDVT.SelectedRows.Count > 2)
                return;
            if (listViewDVT.Rows.Count < 2)
                return;
            DataGridViewRow item = listViewDVT.SelectedRows[0];

            lbIdStore.Text = "Mã đơn vị tính";
            lbNameStore.Text = "Tên đơn vị tính";

            tbxIdStore.Text = item.Cells[1].Value.ToString();
            tbxNameStore.Text = item.Cells[2].Value.ToString();
        }

        private void listViewRoll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listViewRoll.SelectedRows.Count > 2)
                return;
            if (listViewRoll.Rows.Count < 2)
                return;
            DataGridViewRow item = listViewRoll.SelectedRows[0];

            lbIdStore.Text = "Mã chức vụ";
            lbNameStore.Text = "Tên chức vụ";

            tbxIdStore.Text = item.Cells[1].Value.ToString();
            tbxNameStore.Text = item.Cells[2].Value.ToString();
        }

        private void btnAddCV_Click(object sender, EventArgs e)
        {
            IsAddingStore = true;

            lbIdStore.Text = "Mã chức vụ";
            lbNameStore.Text = "Tên chức vụ";

            tbxIdStore.Enabled = true;
            tbxIdStore.Text = "";
            tbxNameStore.Enabled = true;
            tbxNameStore.Text = "";

            btnAddCV.Visible = false;
            btnAddDVT.Visible = false;
            btnDeleteStore.Visible = false;
            btnEditStore.Visible = false;
            btnSaveStore.Visible = true;
            btnCancelStore.Visible = true;

            tbxIdStore.Focus();
        }

        private void btnAddDVT_Click(object sender, EventArgs e)
        {
            IsAddingStore = true;

            lbIdStore.Text = "Mã đơn vị tính";
            lbNameStore.Text = "Tên đơn vị tính";

            tbxIdStore.Enabled = true;
            tbxIdStore.Text = "";
            tbxNameStore.Enabled = true;
            tbxNameStore.Text = "";
            tbxType.Enabled = true;
            tbxType.Text = "";

            btnAddCV.Visible = false;
            btnAddDVT.Visible = false;
            btnDeleteStore.Visible = false;
            btnEditStore.Visible = false;
            btnSaveStore.Visible = true;
            btnCancelStore.Visible = true;

            tbxIdStore.Focus();
        }

        #endregion
    }
}
