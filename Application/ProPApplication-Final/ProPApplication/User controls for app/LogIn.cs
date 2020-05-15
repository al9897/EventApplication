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
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
			
			
			

		}


		public Staff staff1 = null;
        public int checkRole = 0;
        public string employeeName;
        public string employeeRole;
		public string employeeRFID;
		public string userName;
        public int employeeNo;
        public int shopNo;
		Form1 mainForm;
	     RFID myRFID=null;
        private void bttLogin_Click(object sender, EventArgs e)
        {
			
            string userName = tbLogin.Text;
            string password = tbPassword.Text;
            //hash Password
            //check userName, might change to one query for whole 
            string sqlVerifyUserName = string.Format("select * from employee where username = '{0}'", userName);
            string[,] checkUserName = DBConnection.ExecuteQuery1(1, sqlVerifyUserName, 11);
            if (checkUserName != null)
            {
                if(BCrypt.Net.BCrypt.Verify(password, checkUserName[0,4]))
                {
                    if (checkUserName != null)
                    {
                        if (checkUserName[0, 8] == "")
                        {
                            staff1 = new Staff(checkUserName[0, 1], checkUserName[0, 3].ToString(), checkUserName[0, 6], Convert.ToInt32(checkUserName[0, 0]), checkUserName[0, 5], Convert.ToInt32(checkUserName[0, 9]), 0);
                        }
                        else
                        {
                            staff1 = new Staff(checkUserName[0, 1], checkUserName[0, 3].ToString(), checkUserName[0, 6], Convert.ToInt32(checkUserName[0, 0]), checkUserName[0, 5], Convert.ToInt32(checkUserName[0, 9]), Convert.ToInt32(checkUserName[0, 8]));
                        }
                        this.Visible = false;
                        employeeName = checkUserName[0, 1] + " " + checkUserName[0, 2];
                        employeeRole = staff1.Role;
                        employeeNo = staff1.EmployeeNo;
                        shopNo = staff1.ShopNo;
						employeeRFID = staff1.RFIDNO;						
						
                        if (employeeRole == "Manager")
                        {
                            checkRole = 1;
                        }
                        mainForm = (Form1)this.Parent;
                        mainForm.checkLoginStatus = 1;
						
						
					}
					//myRFID.Close();
				}
                else
                {
                    MessageBox.Show("Incorrect user name or password");
                }

				myRFID.Close();
			}
            else
            {
                MessageBox.Show("Incorrect user name or password");
            }
			
        }
        private void RFID_Reader(object sender, RFIDTagEventArgs e)
        {
            if (e.Tag != null)
            {
                //MessageBox.Show(e.Tag);
                string userName = tbLogin.Text;
                string password = tbPassword.Text;
				string RFID = e.Tag;
               // string sql1 = "select count(*) from employee";
                string sql2 = string.Format("select * from employee where RFIDNo = '{0}'", RFID );
                string[,] querryResult = DBConnection.ExecuteQuery1(1, sql2, 11);
                if (querryResult != null)
                {
                    staff1 = new Staff(querryResult[0, 1], querryResult[0, 3].ToString(), Convert.ToString(querryResult[0, 6]), Convert.ToInt32(querryResult[0, 0]), querryResult[0, 5], Convert.ToInt32(querryResult[0, 9]),0);
                    this.Visible = false;
                    employeeName = querryResult[0, 1] + " " + querryResult[0, 2];
                    employeeRole = querryResult[0,5]+"";
                    employeeNo = staff1.EmployeeNo;
                    shopNo = staff1.ShopNo;
					employeeRFID = staff1.RFIDNO;
					if (employeeRole == "manager")
                    {
                        checkRole = 1;
                    }
				//	tbLogin.Clear();
					
					mainForm = (Form1)this.Parent;
                    mainForm.checkLoginStatus = 1;
					myRFID.Close();

				}
                else
                {
                    MessageBox.Show("Wrong RFID");
                }
				
			}
			//myRFID.Close();
		}
         public void StartUp()
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
		
        private void LogIn_Load(object sender, EventArgs e)
        {
			StartUp();
			//myRFID.Close();

		}
		//public void logInAgain()
		//{
		//	StartUp();
		//}

	
	}
}
