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
    public partial class employee : UserControl
    {
        private RFID myRFID;
        Staff staff1;
        List<Staff> tempLst = new List<Staff>();
        List<string> lstRFID = new List<string>();
        public employee()
        {
            InitializeComponent();
            tooltip();
            textBox3.Enabled = false;
            string[] method = new string[] { "Name", "RFID" };
            foreach (string s in method)
            {
                comboBox2.Items.Add(s);
                //

            }
            retrieveData();
            retrieveShopData();
           

        }
        private void retrieveShopData()
        {
            string sql1 = "select count(*) from shop";
            string sql2 = "select * from shop";
            string[,] querryResult = DBConnection.ExecuteQuery(sql1, sql2, 3);
            if(querryResult!=null)
            {
                for (int i = 0; i <querryResult.GetLength(0);i++ )
                {
                    cbShopNo.Items.Add(querryResult[i, 0]);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbShow.Items.Clear();
            retrieveData();
            if (comboBox2.GetItemText(this.comboBox2.SelectedItem)=="Name")
            {

                foreach (Staff a in tempLst)
                {
                    if (a.Name.Replace(" ",string.Empty) == textBox3.Text)
                    {
                        string[] values = a.ToString().Split('-');
                        foreach (string value in values)
                        {
                            if (value.Trim() == "")
							{
								continue;
							}
                               
                            lbShow.Items.Add(value.Trim());
							
						}
						break;
					}
                  

                }

            }
            else if (comboBox2.GetItemText(this.comboBox2.SelectedItem) == "RFID")
            {

                foreach (Staff a in tempLst)
                {
                    if(a.RFIDNO.Replace(" ",string.Empty)== textBox3.Text)
                    {
                        string[] values = a.ToString().Split('-');
                        foreach (string value in values)
                        {
                            if (value.Trim() == "")
							{
								continue;
							}
                            lbShow.Items.Add(value.Trim());
						
						}
						break;
					}

					
				}
            }
        }
        private void RFID_Reader(object sender, RFIDTagEventArgs e)
        {
         
            try
            {
				//retrieveData();
				//foreach (Staff a in tempLst)
				//{
				//    if (e.Tag == a.RFIDNO.Replace(" ", string.Empty))
				//    {

				//        textBox3.Text = e.Tag.Replace(" ",string.Empty);

				//        break;
				//    }
				//    else
				//    {
				//        MessageBox.Show("NOT FOUND");
				//        textBox3.Clear();
				//        break;
				//    }
				//}
				textBox3.Text = e.Tag;
            }
            catch (Exception E) { }
            finally { myRFID.Close(); }

        }

        public void searchRFID()
        {

            try
            {
                myRFID = new RFID();
                myRFID.Tag += RFID_Reader;
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
        }
        //
        private void retrieveData()
        {

            try
            {
                tempLst.Clear();
                string sql1 = "select count(*) from employee";
                string sql2 = "select * from employee";
                string[,] querryResult = DBConnection.ExecuteQuery(sql1, sql2, 11);
                if (querryResult != null)
                {
                    for (int i = 0; i < querryResult.GetLength(0); i++)
                    {
                        
                        string name = Convert.ToString(querryResult[i, 1]);
                        string dob = Convert.ToString(querryResult[i, 3]);
                        string rfid = Convert.ToString(querryResult[i, 6].Replace(" ", string.Empty));
                        int empNo = Convert.ToInt32(querryResult[i, 0]);
                        string role = Convert.ToString(querryResult[i, 5]);
                        int shopNo = Convert.ToInt32(querryResult[i,9]);
                        int manNo = 0;
                       if(querryResult[i,8]=="")
                        {
                            manNo = 0;
                        }
                       else
                        {
                            manNo = int.Parse(querryResult[i,8]);
                        }
                        
                        staff1 = new Staff(name, dob, rfid, empNo, role, shopNo, 0);
                       // lbShow.Items.Add(name + dob + rfid + empNo);
                        tempLst.Add(staff1);

                    }
                }
            }
            catch (Exception E)
            {

            }
        }
        private void RFID_GET(object sender, RFIDTagEventArgs e)
        {
			lstRFID.Clear();
            tbRFID.Text = "";
			lbShow.Items.Clear();
            string sql1 = "select * from participant";
            string sql2 = " select * from employee";
            string getRowEmployee = "select count(RFIDNO) from employee";
            string getRowParticipant = "select count(RFIDNO) from participant";

			string[,] querryResulty = DBConnection.ExecuteQuery(getRowParticipant, sql1, 4);
			string[,] querryResultz = DBConnection.ExecuteQuery(getRowEmployee, sql2, 11);
			if (querryResultz != null)
			{
				for (int i = 0; i < querryResultz.GetLength(0); i++)
				{
					lstRFID.Add(querryResultz[i, 6].Replace(" ",string.Empty));

				}

			}
		
			if (querryResulty != null)
			{
				for (int i = 0; i < querryResulty.GetLength(0); i++)
				{
					lstRFID.Add(querryResulty[i, 0].Replace(" ",string.Empty));
				
				}
			}
			if (lstRFID == null)
			{
				tbRFID.Text = e.Tag;
			}
			else
			{
				if (check(lstRFID, e.Tag) == false)
				{
					tbRFID.Text = e.Tag;
				}
				else
				{
					MessageBox.Show("RFID has been used!");

				}
			}

			myRFID.Close();
			//try
   //         {
   //             if (lstRFID == null)

   //             {
   //                 tbRFID.Text = e.Tag;
   //             }
   //             else
   //             {
   //                 if(check(lstRFID,e.Tag) == false)
			//		{
			//			tbRFID.Text = e.Tag;
			//		}
			//		else
			//		{
			//			MessageBox.Show("RFID has been used!");
					
			//		}
   //             }
   //         }
   //         catch (Exception E)
   //         {
   //             MessageBox.Show(E.ToString());
   //         }
   //         finally
   //         {
   //             myRFID.Close();
   //         }
        }

		private bool check(List<string>lst,string i)
		{
			foreach(string s in lst)
			{
				if (s == i)
				{
					return true;
				}
			}
			return false;
		}


            public void StartUpGet()
		 {
            try
            {
                myRFID = new RFID();

                myRFID.Tag += RFID_GET;

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

        }//
        private void bttShow_Click(object sender, EventArgs e)
        {
            lbShow.Items.Clear();        
            retrieveData();          
            foreach (Staff a in tempLst)
            {
                string[] values = a.ToString().Split('-');
                foreach (string value in values)
                {
                    if (value.Trim() == "")
                        continue;
                    lbShow.Items.Add(value.Trim());
                }
            }
           
            
        }
        

        private void btGetRFID_Click(object sender, EventArgs e)
        {
             StartUpGet();		
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.GetItemText(this.comboBox2.SelectedItem) == "RFID")
            {
                textBox3.Enabled = false;
				buttonScan.Enabled = true;
            
            }
            else
            {
                textBox3.Enabled = true;
				buttonScan.Enabled = false;
			}
        }

   

        private void Create_Click_1(object sender, EventArgs e)
        {
			//int n = 0;
			//string password = tbPassword.Text;
			//var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password).ToString();
			//MessageBox.Show(hashedPassword);
			////string getMaxEmpNo = "select Max(EmployeeNo) from Employee";
			//string createShop = "INSERT INTO shop(shopno,shopname,shoptype) VALUES(" + Convert.ToInt32(cbShopNo.SelectedItem) + ",null,null)";
			//string getShop = "select * from shop";
			//string getRowShop = "select count(shopno) from shop";
			////int empNo = Convert.ToInt32(DBConnection.ExecuteScalar(getMaxEmpNo)) + 1;
			//string[,] shop = DBConnection.ExecuteQuery(getRowShop, getShop, 3);
			//string querryGetUserName = "select * from Employee";
			//string querryGetRow = "select count(*)from employee";
			//string[,] emp = DBConnection.ExecuteQuery(querryGetRow, querryGetUserName, 11);

			//if (emp != null)
			//{
			//	for (int i = 0; i < shop.GetLength(0); i++)
			//	{

			//		n=n +1;
			//		if (tbUserName.Text != emp[i, 10].Replace(" ",string.Empty))
			//		{
			//			if (cbShopNo.SelectedItem.ToString() == shop[i, 0])
			//			{
			//			string create = string.Format("INSERT INTO employee( FirstName, LastName, Password, Role, RFIDNo, EventNo,ManagerNo,ShopNo,UserName) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}') ON DUPLICATE KEY UPDATE EmployeeNo=EmployeeNo+1", tbFirstName.Text, tbLastName.Text, hashedPassword,tbRole.Text, tbRFID.Text, 1, 1, cbShopNo.SelectedItem.ToString(),tbUserName.Text);


			//			int nrOfInsertRow = DBConnection.ExecuteNonQuery(create);
			//			//int z = DBConnection.ExecuteNonQuery(create1);
			//			break;
			//			}

			//			else
			//			{
			//				int temp = DBConnection.ExecuteNonQuery(createShop);
			//			string create = string.Format("INSERT INTO employee( FirstName, LastName, Password, Role, RFIDNo, EventNo,ManagerNo,ShopNo,UserName) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}') ON DUPLICATE KEY UPDATE EmployeeNo=EmployeeNo+1", tbFirstName.Text, tbLastName.Text, hashedPassword,tbRole.Text, tbRFID.Text, 1, 1, cbShopNo.SelectedItem.ToString(), tbUserName.Text);
			//			int nrOfInsertRow = DBConnection.ExecuteNonQuery(create);

			//			break;
			//			}
			//		}
			//		else
			//		{
			//			MessageBox.Show("this user has been registered! please change");
			//			break;
			//		}

			//	}

			//	tbRFID.Clear();


			//}

			string firstname = tbFirstName.Text;
			string lastname = tbLastName.Text;
			int shopNo = Convert.ToInt32(cbShopNo.SelectedItem);
			string role = tbRole.Text;
			string rfidno = tbRFID.Text;
			string username = tbUserName.Text;
			string password = tbPassword.Text;
			string hashedPass = BCrypt.Net.BCrypt.HashPassword(password);
			string checkUserName = string.Format("select username from employee where username = '{0}'", username);
			string[,] checkUserNameResult = DBConnection.ExecuteQuery1(1, checkUserName, 1);
			if(checkUserNameResult == null)
			{
				string checkRfid = string.Format("select rfidno from employee where rfidno = '{0}'", rfidno);
				string[,] checkRfidResult = DBConnection.ExecuteQuery1(1, checkRfid, 1);
				string checkRfid2 = string.Format("select rfidno from participant where rfidno = '{0}'", rfidno);
				string[,] checkRfidResult2 = DBConnection.ExecuteQuery1(1, checkRfid2, 1);
				if(checkRfidResult == null && checkRfidResult2 == null)
				{
					string insertEmp = string.Format("insert into employee(firstname, lastname, password, role, rfidno, eventno, managerno, shopno, username) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", firstname, lastname, hashedPass, role, rfidno, 1, 2, shopNo, username);
					DBConnection.ExecuteNonQuery(insertEmp);
					MessageBox.Show("Added Successfully");
				}
				else
				{
					MessageBox.Show("Rfid exists");
				}
			}
			else
			{
				MessageBox.Show("User name exists");
			}
        }
        private void tooltip()
        {
            toolTip1.SetToolTip(btGetRFID, "Click here to get RFID!");
            toolTip1.SetToolTip(cbShopNo, "Choose a shop number where employee works");
        }

		private void buttonScan_Click(object sender, EventArgs e)
		{
		
			searchRFID();
		}

		private void employee_Load(object sender, EventArgs e)
		{
			buttonScan.Enabled = false;
		}
	}
}
