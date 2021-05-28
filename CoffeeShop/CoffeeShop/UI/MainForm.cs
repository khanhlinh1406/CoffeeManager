using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class MainForm : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton temp = new Bunifu.Framework.UI.BunifuFlatButton();
        LoginForm parent;
        Connect Connection;
        USER User = new USER();
       
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(LoginForm parent, string User)
        {
            this.User = new USER(User);
            this.User.ID = User;
            this.parent = parent;
            this.Connection = new Connect();
           
            InitializeComponent();

          
            temp = this.btnHome;
            //data.Read(this.User.ID);
            //this.dataGridViewTimetable.DoubleBuffered(true);
            //listWeb.ShowToListView(lvWeb);

            //this.theme = Properties.Settings.Default.Color;
            //SetColorAll(this.theme);

            //animation1.AnimationType = new AnimatorNS.AnimationType();
            //animation1.AnimationType = AnimatorNS.AnimationType.Particles;
        }
    }
}
