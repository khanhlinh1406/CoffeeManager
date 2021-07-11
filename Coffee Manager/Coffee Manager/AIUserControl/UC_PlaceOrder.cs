using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public partial class UC_PlaceOrder : UserControl
    {
        List<Mon> danhSachMon = new List<Mon> ();
        List<DonViTinh> danhSachDVT = new List<DonViTinh>();
        List<KhachHang> danhSachKhachHang = new List<KhachHang>();
        List<string> danhSachMaMon = new List<string>();
        List<int> danhSachSoLuong = new List<int>();
        NhanVien nhanVien = new NhanVien();
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

        void LoadListKhachHang()
        {
            try
            {
                string find = "SELECT * FROM KHACHHANG";
                this.connect.OpenConnection();
                SqlCommand command = this.connect.CreateSQLCmd(find);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    KhachHang tmp = new KhachHang(reader.GetString(0), reader.GetString(1),
                        reader.GetDateTime(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5),
                        reader.GetInt32(6));
                    danhSachKhachHang.Add(tmp);
                    cbxCustomer.Items.Add(tmp.TEN_KH + "-" + tmp.SO_DT);
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
            LoadMenu();
            LoadMenuToDataGridView("");
            LoadListDVT();
            LoadListKhachHang();
        }

        private void LoadMenuToDataGridView(string filter)
        {
            menuGridView.Rows.Clear();
            if (filter == "" || filter == "*")
            {
                for (int i = 0; i < danhSachMon.Count; i++)
                {
                    menuGridView.Rows.Add(danhSachMon[i].TEN_MON, danhSachMon[i].GIA);
                }
            }
            else
            {
                for (int i = 0; i < danhSachMon.Count; i++)
                {
                    if (danhSachMon[i].DVT.MA_DVT == findMaDVTFromTenDVT(filter))
                        menuGridView.Rows.Add(danhSachMon[i].TEN_MON, danhSachMon[i].GIA);
                }
            }
        }

        private void tbxOrderItemQuantity_ValueChanged(object sender, EventArgs e)
        {
            int tempCost = int.Parse(tbxOrderItemPrice.Text) * int.Parse(tbxOrderItemQuantity.Value.ToString());
            tbxOrderItemCost.Text = tempCost.ToString();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            bool isDuplicated = false;
            if (orderGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in orderGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString() == tbxOrderItemName.Text
                    && row.Cells[1].Value.ToString() == findTenDVTFromMaDVT(danhSachMon[menuGridView.CurrentRow.Index].DVT.MA_DVT))
                    {
                        row.Cells[2].Value = (int.Parse(tbxOrderItemQuantity.Value.ToString())
                            + int.Parse(row.Cells[2].Value.ToString())).ToString();
                        row.Cells[3].Value = (int.Parse((int.Parse(tbxOrderItemPrice.Text) * int.Parse(tbxOrderItemQuantity.Value.ToString())).ToString())
                            + int.Parse(row.Cells[3].Value.ToString())).ToString();
                        isDuplicated = true;
                        break;
                    }
                }
                if (!isDuplicated)
                {
                    orderGridView.Rows.Add(tbxOrderItemName.Text, findTenDVTFromMaDVT(danhSachMon[menuGridView.CurrentRow.Index].DVT.MA_DVT),
                       tbxOrderItemQuantity.Value.ToString(), tbxOrderItemCost.Text);
                    danhSachMaMon.Add(danhSachMon[menuGridView.CurrentRow.Index].MA_MON);
                }
            }
            else
            {
                orderGridView.Rows.Add(tbxOrderItemName.Text, findTenDVTFromMaDVT(danhSachMon[menuGridView.CurrentRow.Index].DVT.MA_DVT),
                tbxOrderItemQuantity.Value.ToString(), tbxOrderItemCost.Text);
                danhSachMaMon.Add(danhSachMon[menuGridView.CurrentRow.Index].MA_MON);
            }
            totalCost += int.Parse(tbxOrderItemCost.Text);
            lbTotalCost.Text = this.totalCost.ToString() + " VND";
            btnRemoveItem.Enabled = true;
        }

        private string findTenDVTFromMaDVT(string maDvt)
        {
            for (int i = 0; i < danhSachDVT.Count; i++)
            {
                if (danhSachDVT[i].MA_DVT == maDvt)
                {
                    return danhSachDVT[i].TEN_DVT;
                }
            }
            return "";
        }

        private string findMaDVTFromTenDVT(string name)
        {
            for (int i = 0; i < danhSachDVT.Count; i++)
            {
                if (danhSachDVT[i].TEN_DVT == name)
                {
                    return danhSachDVT[i].MA_DVT;
                }
            }
            return "";
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (orderGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in orderGridView.SelectedRows)
                {
                    totalCost -= int.Parse(row.Cells[3].Value.ToString());
                    lbTotalCost.Text = totalCost.ToString() + " VND";
                    orderGridView.Rows.Remove(row);
                }
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

        private void cbCalculationUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadMenuToDataGridView(cbCalculationUnit.Text);
        }

        private void tbxLookup_TextChanged(object sender, EventArgs e)
        {
            menuGridView.Rows.Clear();
            for (int i = 0; i < danhSachMon.Count; i++)
            {
                if (danhSachMon[i].TEN_MON.ToLower().Contains(tbxLookup.Text.ToLower()))
                {
                    menuGridView.Rows.Add(danhSachMon[i].TEN_MON, danhSachMon[i].GIA);
                }
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if (cbxCustomer.Text != "")
            {
                getSoLuongMoiMon();
                HoaDon hoaDon = new HoaDon();
                hoaDon.CreateMaKH();
                nhanVien.MA_TK = Dashboard.staffAccountId;
                nhanVien.FindNhanVienFromAccountId();
                hoaDon.MA_NV_LAP = nhanVien.MA_NV;
                hoaDon.NG_LAP = DateTime.Now;
                hoaDon.TRI_GIA = totalCost;
                hoaDon.DS_MON = danhSachMaMon;
                hoaDon.SO_LUONG = danhSachSoLuong;
                hoaDon.MA_KH = danhSachKhachHang[cbxCustomer.SelectedIndex].MA_KH;
                hoaDon.SaveHoaDon();
                hoaDon.SaveChiTietHoaDon();
                MessageBox.Show("Lưu hóa đơn thành công!");
                exportBillInPdf(hoaDon.MA_HD);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Không thể thực hiện");
            }
        }

        private void getSoLuongMoiMon()
        {
            foreach (DataGridViewRow row in orderGridView.Rows)
            {
                danhSachSoLuong.Add(int.Parse(row.Cells[2].Value.ToString()));
            }
        }

        private void exportBillInPdf(string MaHD)
        {
            if (orderGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "receipt.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        var document = new Document(PageSize.A6, 15, 15, 15, 15);
                        var writer = PdfWriter.GetInstance(document, stream);
                        document.Open();

                        string ARIALUNI_TFF = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "BaiJamjuree-Regular.TTF");
                        iTextSharp.text.pdf.BaseFont bfR = iTextSharp.text.pdf.BaseFont.CreateFont(ARIALUNI_TFF,
                          iTextSharp.text.pdf.BaseFont.IDENTITY_H,
                          iTextSharp.text.pdf.BaseFont.EMBEDDED);

                        iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bfR, 18, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0));
                        iTextSharp.text.Font subTitleFont = new iTextSharp.text.Font(bfR, 14, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0));
                        iTextSharp.text.Font boldTableFont = new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0));
                        iTextSharp.text.Font endingMessageFont = new iTextSharp.text.Font(bfR, 10, iTextSharp.text.Font.ITALIC, new iTextSharp.text.BaseColor(0, 0, 0));
                        iTextSharp.text.Font endingMessageFontBold = new iTextSharp.text.Font(bfR, 10, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0));
                        iTextSharp.text.Font bodyFont = new iTextSharp.text.Font(bfR, 10, iTextSharp.text.Font.NORMAL, new iTextSharp.text.BaseColor(0, 0, 0));
                        var header = new PdfPTable(1);
                        header.HorizontalAlignment = Element.ALIGN_CENTER;
                        header.SpacingBefore = 10;
                        header.SpacingAfter = 10;
                        header.DefaultCell.Border = 0;
                        PdfPCell cell = new PdfPCell(new Paragraph("HOÁ ĐƠN", titleFont));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.Border = 0;
                        header.AddCell(cell);
                        cell = new PdfPCell(new Paragraph("Thank you for choosing us!", endingMessageFont));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.Border = 0;
                        header.AddCell(cell);
                        header.AddCell(new Paragraph("\n", boldTableFont));
                        document.Add(header);

                        var people = new PdfPTable(1);
                        people.HorizontalAlignment = 0;
                        people.SpacingBefore = 10;
                        people.SpacingAfter = 10;
                        people.DefaultCell.Border = 0;
                        people.TotalWidth = document.PageSize.Width;
                        float[] widths = new float[] { document.PageSize.Width / 2};
                        people.SetWidths(widths);

                        people.AddCell(new Phrase(DateTime.Now.ToString(), bodyFont));
                        people.AddCell(new Phrase("Khách hàng: " + cbxCustomer.Text, bodyFont));
                        people.AddCell(new Phrase("Nhân viên: " + nhanVien.TEN_NV, bodyFont));
                        document.Add(people);
                        document.Add(new Paragraph("\n", boldTableFont));

                        document.Add(new Paragraph("Thông Tin Hoá Đơn", boldTableFont));
                        var orderInfoTable = new PdfPTable(2);
                        orderInfoTable.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                        orderInfoTable.SpacingBefore = 10;
                        orderInfoTable.SpacingAfter = 10;
                        orderInfoTable.DefaultCell.Border = 0;
                        orderInfoTable.TotalWidth = document.PageSize.Width;
                        widths = new float[] { document.PageSize.Width/2, document.PageSize.Width/2};
                        orderInfoTable.SetWidths(widths);

                        orderInfoTable.AddCell(new Phrase("Mã Hoá Đơn:", endingMessageFontBold));
                        orderInfoTable.AddCell(new Phrase(MaHD, bodyFont));
                        orderInfoTable.AddCell(new Phrase("Tổng Tiền:", endingMessageFontBold));
                        orderInfoTable.AddCell(new Phrase(totalCost.ToString() + " vnd", bodyFont));
                        document.Add(orderInfoTable);
                        document.Add(new Paragraph("\n", boldTableFont));

                        document.Add(new Paragraph("Chi Tiết", boldTableFont));
                        var orderDetailTable = new PdfPTable(3);
                        orderDetailTable.HorizontalAlignment = Element.ALIGN_LEFT;
                        orderDetailTable.SpacingBefore = 10;
                        orderDetailTable.SpacingAfter = 10;
                        orderDetailTable.DefaultCell.Border = 0;
                        widths = new float[] { document.PageSize.Width/3, document.PageSize.Width/4, document.PageSize.Width/3 };
                        orderDetailTable.SetTotalWidth(widths);
                        orderDetailTable.LockedWidth = true;

                        cell = new PdfPCell(new Phrase("Tên Món", endingMessageFontBold));
                        cell.HorizontalAlignment = Element.ALIGN_LEFT;
                        cell.Border = 0;
                        orderDetailTable.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Số Lượng", endingMessageFontBold));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.Border = 0;
                        orderDetailTable.AddCell(cell);
                        cell = new PdfPCell(new Phrase("Thành Tiền", endingMessageFontBold));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell.Border = 0;
                        orderDetailTable.AddCell(cell);

                        foreach (DataGridViewRow row in orderGridView.Rows)
                        {
                            PdfPCell cell1 = new PdfPCell(new Phrase(row.Cells[0].Value.ToString(), bodyFont));
                            PdfPCell cell2 = new PdfPCell(new Phrase(row.Cells[2].Value.ToString(), bodyFont));
                            PdfPCell cell3 = new PdfPCell(new Phrase(row.Cells[3].Value.ToString(), bodyFont));
                            cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell1.Border = 0;
                            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell2.Border = 0;
                            cell3.HorizontalAlignment = Element.ALIGN_RIGHT;
                            cell3.Border = 0;
                            orderDetailTable.AddCell(cell1);
                            orderDetailTable.AddCell(cell2);
                            orderDetailTable.AddCell(cell3);
                        }

                        document.Add(orderDetailTable);
                        document.Close();
                        stream.Close();
                    }
                    MessageBox.Show("Xuất hóa đơn thành công!", "Xuất hóa đơn");
                }
            }
        }

        private void tbxOrderItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
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
