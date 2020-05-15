using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProPApplication
{
    public partial class LogIn : UserControl
    {
        string username = "abc";
        string password = "1";
        public LogIn()
        {
            InitializeComponent();
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            if(tbxNameLogin.Text==username && tbxPassLogin.Text == password)
            {
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
          
        }
    }
}
