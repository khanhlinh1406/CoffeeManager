using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manager
{
    public partial class Dashboard : Form
    {
        public static string staffAccountId = "";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Dashboard_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String userType, string accountid)
        {
            InitializeComponent();
            staffAccountId = accountid;

            if(userType == "Staff")
            {
                panelStaffFunction.BringToFront();
                panelStaffFunction.Show();
                panel1.Hide();

                //btnPlaceOrder.Show();

                //panelShop.Hide();
                //btnAddItem.Hide();
                //btnUpdateItem.Hide();
                //btnRemoveItem.Hide();

                //panelReport.Hide();
                //btnMaterial.Hide();
                //btnReceivedNote.Hide();


                //btnMonthly.Hide();
                //btnBeverage.Show();

                //btnStaff.Hide();
                //btnCustomer.Show();
            }
            else if(userType == "Admin")
            {
                panel1.BringToFront();
                panel1.Show();
                panelStaffFunction.Hide();
                //btnPlaceOrder.Hide();

                //btnAddItem.Show();
                //btnUpdateItem.Show();
                //btnRemoveItem.Show();

                //btnMaterial.Show();
                //btnReceivedNote.Show();

                //btnMonthly.Show();
                //btnBeverage.Show();

                //btnStaff.Show();
                //btnCustomer.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();
            uC_AddItems1.UC_AddItems_Load(sender, e);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Welcome1.Visible = true;
            uC_AddItems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItem1.Visible = false;
            uC_Material1.Visible = false;
            uC_ReceivedNote1.Visible = false;
            uC_MonthlyStatistics2.Visible = false;
            uC_BeverageStatistics2.Visible = false;
            uC_StaffManager1.Visible = false;
            uC_CustomerManager1.Visible = false;
            uC_Setting1.Visible = false;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
            uC_UpdateItems1.UC_UpdateItems_Load(sender, e);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
            uC_RemoveItem1.UC_RemoveItem_Load(sender, e);
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            uC_Material1.Visible = true;
            uC_Material1.BringToFront();
            uC_Material1.UC_Material_Load(sender, e);
        }

        private void btnReceivedNote_Click(object sender, EventArgs e)
        {
            uC_ReceivedNote1.Visible = true;
            uC_ReceivedNote1.BringToFront();
            uC_ReceivedNote1.UC_ReceivedNote_Load(sender, e);
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            uC_MonthlyStatistics2.Visible = true;
            uC_MonthlyStatistics2.BringToFront();
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            uC_BeverageStatistics2.Visible = true;
            uC_BeverageStatistics2.BringToFront();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            uC_StaffManager1.Visible = true;
            uC_StaffManager1.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            uC_CustomerManager1.Visible = true;
            uC_CustomerManager1.BringToFront();
        }

        private void btnBeverageStaff_Click(object sender, EventArgs e)
        {
            uC_BeverageStatistics2.Visible = true;
            uC_BeverageStatistics2.BringToFront();
        }

        private void btnCustomerStaff_Click(object sender, EventArgs e)
        {
            uC_CustomerManager1.Visible = true;
            uC_CustomerManager1.BringToFront();
        }

        private void btnExitStaff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOutStaff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            uC_Setting1.Visible = true;
            uC_Setting1.BringToFront();
            uC_Setting1.UC_Setting_Load(sender, e);
        }
    }
}
