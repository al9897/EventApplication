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
    public partial class LostRFID : UserControl
    {
        public LostRFID()
        {
            InitializeComponent();
        }

        public int lostRFID = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
