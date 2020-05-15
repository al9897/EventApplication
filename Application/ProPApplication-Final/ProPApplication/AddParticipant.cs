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
    public partial class AddParticipant : UserControl
    {
        public AddParticipant()
        {
            InitializeComponent();
            lostRFID.Visible = false;
        }

        private void bttLost_Click(object sender, EventArgs e)
        {
            lostRFID.Visible = true;
            lostRFID.Dock = DockStyle.Fill;
            lostRFID.BringToFront();
        }

        private void AddParticipant_Load(object sender, EventArgs e)
        {

        }
    }
}
