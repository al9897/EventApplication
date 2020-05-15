using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace ProPApplication
{
    public partial class LostRFID : UserControl
    {
        List<string> lstRFID = new List<string>();
        RFID myRFID = new RFID();
        Visitor temp;
        public LostRFID()
        {
            InitializeComponent();
            tbFirstName.Enabled = false;
            tbDOB.Enabled = false;
            tbMail.Enabled = true;
            tbLost.Enabled = false;
            tbPhone.Enabled = false;
            textBox5.Enabled = false;
        }

		string oldRfidNoFound = "";
        public int lostRFID = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
     //       string querryNrRows = "select count(*) from participant";         
     //       string querryGet = "select * from participant where RFIDNo='"+tbLost.Text+"'";
     //       string[,] result = DBConnection.ExecuteQuery(querryNrRows, querryGet, 4);
     //       if(result!=null)
     //       {

     //           string dropFK = "ALTER TABLE `ordernumber` DROP FOREIGN KEY `ordernumber_ibfk_1`";
     //           int n = DBConnection.ExecuteNonQuery(dropFK);
                
     //           string querry = "UPDATE participant SET RFIDNo='" + textBox5.Text + "' WHERE RFIDNo= '" + result[0,0] + "'";
     //           int s = DBConnection.ExecuteNonQuery(querry);
     //           if(s>0)
     //           {
					//string enableConstraint1 = "ALTER TABLE ordernumber ADD CONSTRAINT `ordernumber_ibfk_1` FOREIGN KEY(RFIDNo) REFERENCES Participant(RFIDNo) ON DELETE SET NULL ";
					//int n4 = DBConnection.ExecuteNonQuery(enableConstraint1);
					//string querry1 = "UPDATE ordernumber SET RFIDNo='" + textBox5.Text + "' WHERE RFIDNo= '" + tbLost.Text + "'";
     //               int st = DBConnection.ExecuteNonQuery(querry1);                  
     //               MessageBox.Show("Success! New RFID is" + this.textBox5.Text);
     //               this.Visible = false;
     //           }
     //       }
            if(oldRfidNoFound != "")
			{
				string update = string.Format("update participant set rfidno = '{0}' where rfidno = '{1}'", textBox5.Text, oldRfidNoFound);
				DBConnection.ExecuteNonQuery(update);
				string updateorder = string.Format("update ordernumber set rfidno = '{0}' where rfidno = '{1}'", textBox5.Text, oldRfidNoFound);
				DBConnection.ExecuteNonQuery(updateorder);
				MessageBox.Show("successful");
			}

        }

        private void button2_Click(object sender, EventArgs e)
        {

            StartUpCreate();
        }
        public void StartUpCreate()
        {
            try
            {
                myRFID = new RFID();

                myRFID.Tag += RFID_Create;

                myRFID.Open();
            }
            catch (PhidgetException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch
            {
                MessageBox.Show("something else");
            }
            //finally { myRFID.Close(); }
        }//
        private void RFID_Create(object sender, RFIDTagEventArgs e)
        {
            lstRFID.Clear();
            textBox5.Text = e.Tag;
            if (e.Tag != "")
            {

                string sql1 = "select * from participant";
                string sql2 = " select * from employee";
                string getRowEmployee = "select count(RFIDNO) from employee";
                string getRowParticipant = "select count(RFIDNO) from participant";
                string[,] querryResulty = DBConnection.ExecuteQuery(getRowParticipant, sql1, 4);

                if (querryResulty != null)
                {
                    for (int i = 0; i < querryResulty.GetLength(0); i++)
                    {
                        lstRFID.Add(querryResulty[i, 0]);
                    }
                }
                string[,] querryResultz = DBConnection.ExecuteQuery(getRowEmployee, sql2, 11);
                if (querryResultz != null)
                {
                    for (int i = 0; i < querryResultz.GetLength(0); i++)
                    {
                        lstRFID.Add(querryResultz[i, 6]);
                    }
                }

                foreach (string s in lstRFID)
                {
                    if (textBox5.Text == s)
                    {
                        MessageBox.Show("this card has been used!!!");
                        textBox5.Clear();
                        break;
                    }

                }
                myRFID.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbMail.Text != "")
            {

				string sql1 = string.Format("select * from visitor where email = '{0}'", tbMail.Text);
				string[,] querryResult = DBConnection.ExecuteQuery1(1, sql1, 10);
				if (querryResult != null)
                {
					string sql2 = string.Format("select * from eventaccount where visitorNo ='{0}'", Convert.ToInt32(querryResult[0, 0]));
					string getRow2 = "select count(*) from eventaccount";
					string[,] querryResult2 = DBConnection.ExecuteQuery(getRow2, sql2, 9);
					if (querryResult2 != null)
                    {
						string sql3 = string.Format("select * from Participant where AccountNo ='{0}'", Convert.ToInt32(querryResult2[0, 0]));
						string[,] querryResult3 = DBConnection.ExecuteQuery1(1, sql3, 4);
						oldRfidNoFound = querryResult3[0, 0];
						if (querryResult3 != null)
                        {
                            tbPhone.Text = querryResult[0, 7];
                            tbFirstName.Text = querryResult[0, 3];
                            tbDOB.Text = querryResult[0, 4];
                            tbDOB.Text = querryResult[0, 5];
                            tbLost.Text = querryResult3[0, 0];
                         
                        }

                    }
                    else
                    {
                        MessageBox.Show("Wrong E-mail");
                    }
                }
                else
                {
                    MessageBox.Show("Cannot find!");
                }
            }
            }

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Visible = false;
		}
	}
}
