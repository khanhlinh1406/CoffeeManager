using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Manager.AIUserControl
{
    public partial class UC_RemoveItem : UserControl
    {
        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "How to delete ?";
            DelLabel.ForeColor = Color.Blue;
        }

        private void DelLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
