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
    public partial class Rent : UserControl
    {
        public Rent()
        {
            InitializeComponent();
            this.comboBoxAllTentCheck = cbAllTent;
        }

        public Staff myStaff;
        public ComboBox comboBoxAllTentCheck;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string findRFID;
            int accountNo = 0;
            List<int> allPeople = new List<int>();
            if (rbRfidNo.Checked)
            {
                findRFID = "abc";
                string findAccount = string.Format("select accountno from participant where rfidno = '{0}'", findRFID);
                string[,] eventAccount = DBConnection.ExecuteQuery1(1, findAccount, 1);
                accountNo = Convert.ToInt32(eventAccount[0, 0]);
            }
            else
            {
                if (tbSearch.Text != null)
                {
                    //assume enter right account number
                    accountNo = Convert.ToInt32(tbSearch.Text);
                }
                else
                {
                    MessageBox.Show("Please enter account number");
                }
            }
            //tent execution 
            if (accountNo != 0)
            {
                string findTentNo = string.Format("select ifnull(campingspotno, 0) from eventaccount where accountno = {0}", accountNo);
                string[,] tentNo = DBConnection.ExecuteQuery1(1, findTentNo, 1);
                int tentNoFound = Convert.ToInt32(tentNo[0, 0]);
                if (tentNoFound != 0)
                {
                    //find host and reservation
                    string findTent = string.Format("select campingspotno, accountno, paidinadvance, total from reservation where campingspotno = {0}", tentNoFound);
                    string[,] tentInfo = DBConnection.ExecuteQuery1(1, findTent, 4);
                    int hostAccountNo = Convert.ToInt32(tentInfo[0, 1]);
                    //find all people in the same tent
                    string findAllPeople = string.Format("select accountno from eventaccount where campingspotno = {0}", Convert.ToInt32(tentInfo[0, 0]));
                    string countAllPeople = string.Format("select count(*) from eventaccount where campingspotno = {0}", Convert.ToInt32(tentInfo[0, 0]));
                    string[,] findAllAccount = DBConnection.ExecuteQuery(countAllPeople, findAllPeople, 1);
                    for (int i = 0; i < findAllAccount.GetLength(0); i++)
                    {
                        int showAccountNo = Convert.ToInt32(findAllAccount[i, 0]);
                        allPeople.Add(showAccountNo);
                        if (showAccountNo == hostAccountNo)
                        {
                            //move host to the first in the list
                            int save = allPeople[0];
                            allPeople[0] = allPeople[i];
                            allPeople[i] = save;
                        }
                    }
                    Tent myTent = new Tent(Convert.ToInt32(tentInfo[0, 0]), Convert.ToDecimal(tentInfo[0, 3]), tentInfo[0, 2], allPeople);
                    lbxTentInfo.Items.Add(myTent.ShowInfo());
                }
                else
                {
                    MessageBox.Show("You dont have tent");
                }
            }
            else
            {
                MessageBox.Show("Please enter account no or there is something wrong in the db");
            }
        }

        private decimal GetPrice(int campingSpotNo)
        {
            decimal price;
            string sqlGetPrice = "select price from campingspot where campingspotno = " + campingSpotNo;
            string[,] getPrice = DBConnection.ExecuteQuery1(1, sqlGetPrice, 1);
            price = Convert.ToDecimal(getPrice[0, 0]);
            return price;
        }

        private void btnRentNewTent_Click(object sender, EventArgs e)
        {
            string findRFID;
            int accountNo = 0;
            //find accountno
            if (rbRfidNo.Checked)
            {
                findRFID = "abc";
                string findAccount = string.Format("select accountno, ifnull(campingspotno, 0) from participant where rfidno = '{0}'", findRFID);
                string[,] eventAccount = DBConnection.ExecuteQuery1(1, findAccount, 1);
                if (Convert.ToInt32(eventAccount[0, 1]) != 0)
                {
                    accountNo = Convert.ToInt32(eventAccount[0, 0]);
                    int campingSpotNo = Convert.ToInt32(cbAllTent.SelectedItem);
                    // get price
                    decimal price = this.GetPrice(campingSpotNo) + 10;
                    // insert into table reservation and update in eventaccount
                    string insertData = string.Format("insert into reservation(total, paidinadvance, campingspotno, accountno) values({0}, 'E', {1}, {2})", price, campingSpotNo, accountNo);
                    string updateInEventAccount = string.Format("update eventaccount set campingspotno = {0} where accountno = {1}", campingSpotNo, accountNo);
                    DBConnection.ExecuteNonQuery(insertData);
                    DBConnection.ExecuteNonQuery(updateInEventAccount);
                }
                else
                {
                    MessageBox.Show("This person has already had a camping spot");
                }
            }
            else
            {
                if (tbSearch.Text != null)
                {
                    //assume enter right account number
                    accountNo = Convert.ToInt32(tbSearch.Text);
                    string sqlCheckTent = string.Format("select ifnull(campingspotno, 0) from eventaccount where accountno = {0}", accountNo);
                    string[,] checkTent = DBConnection.ExecuteQuery1(1, sqlCheckTent, 1);
                    if (Convert.ToInt32(checkTent[0, 0]) != 0)
                    {
                        MessageBox.Show("This person has already had a camping spot");
                    }
                    else
                    {
                        int campingSpotNo = Convert.ToInt32(cbAllTent.SelectedItem);
                        // get price
                        decimal price = this.GetPrice(campingSpotNo) + 10;
                        // insert into table reservation and update in eventaccount
                        string insertData = string.Format("insert into reservation(total, paidinadvance, campingspotno, accountno) values({0}, 'E', {1}, {2})", price, campingSpotNo, accountNo);
                        string updateInEventAccount = string.Format("update eventaccount set campingspotno = {0} where accountno = {1}", campingSpotNo, accountNo);
                        DBConnection.ExecuteNonQuery(insertData);
                        DBConnection.ExecuteNonQuery(updateInEventAccount);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter account number");
                }
            }
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            string rfid = "abc";
            //execute invite
            string checkReservation = string.Format("select campingspotno from reservation where accountno in (select accountno from eventaccount where accountno in (select accountno from participant where rfidno = '{0}'))", rfid);
            string[,] getTent = DBConnection.ExecuteQuery1(1, checkReservation, 1);
            if (getTent != null)
            {
                int inviteAccount = Convert.ToInt32(tbInvite.Text);
                string sqlUpdateInvite = string.Format("update eventaccount set campingspotno = {0} where accountno = {1}", Convert.ToInt32(getTent[0, 0]), inviteAccount);
                DBConnection.ExecuteNonQuery(sqlUpdateInvite);
            }
            else
            {
                MessageBox.Show("There is no reservation for this tent");
            }
        }
    }
}
