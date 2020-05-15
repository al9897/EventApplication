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
	public partial class AddParticipant : UserControl
	{
		private RFID myRFID;
		List<Participant> tempLst = new List<Participant>();
		Staff st;
		string s;
		List<string> lstRFID = new List<string>();
		public AddParticipant()
		{

			InitializeComponent();
			lostRFID.Visible = false;
			//tbNewRFID.Enabled = false;
		}

		private void bttLost_Click(object sender, EventArgs e)
		{
			lostRFID.Visible = true;
			lostRFID.Dock = DockStyle.Fill;
			lostRFID.BringToFront();
		}
		private bool checkNull()
		{
			bool check = true;
			if (tbNewPhone.Text == "" || tbxNewName.Text == "" || tbNewRFID.Text == "" || tbMail.Text == "")
				check = false;
			return check;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			bool check = checkNull();
			//bool check1 = checkDOB();
			try
			{
				if (check)
				{
					string email = tbMail.Text;
					string checkmail = string.Format("select email from visitor where email = '{0}'", email);
					string[,] emailCheckResult = DBConnection.ExecuteQuery1(1, checkmail, 1);
					if(emailCheckResult == null)
					{
						//decimal newAccountNo = 1;
						string getDataVisitorQuerry = "select * from visitor";
						string getRowVisitorQuerry = "select Count(*) from visitor";
						string[,] visitorResult = DBConnection.ExecuteQuery(getRowVisitorQuerry, getDataVisitorQuerry, 10);

						if (visitorResult != null)
						{
							for (int i = 0; i < visitorResult.GetLength(0); i++)
							{
								if (visitorResult[i, 5] != tbMail.Text)
								{


									string createVisitorQuerry = string.Format("Insert into Visitor(firstname,email,phonenumber) value('{0}','{1}','{2}')", tbxNewName.Text, tbMail.Text, tbNewPhone.Text);
									int nrOfRowVisitorInsert = DBConnection.ExecuteNonQuery(createVisitorQuerry);
									break;

								}
								else
								{
									MessageBox.Show("this email has been registered!!!!");
									break;
								}

							}
						}
						else if (visitorResult == null)
						{

							string createVisitorQuerry = string.Format("Insert into Visitor(firstname,email,phonenumber) value('{0}','{1}','{2}')", tbxNewName.Text, tbMail.Text, tbNewPhone.Text);
							int nrOfRowVisitor = DBConnection.ExecuteNonQuery(createVisitorQuerry);
						}
						string getVisitorNumber = string.Format("select visitorNo from visitor where email = '{0}'", tbMail.Text);
						string[,] visitorNo = DBConnection.ExecuteQuery1(1, getVisitorNumber, 1);
						int visitorNoFound = Convert.ToInt32(visitorNo[0, 0]);
						string inserteventAccount = string.Format("insert into eventaccount(visitorno, ticketpaidmethod, campingspotno, ticketprice) values('{0}', '{1}', '{2}', '{3}')", visitorNoFound, "E", 0, 65);
						DBConnection.ExecuteNonQuery(inserteventAccount);
						string getDataEventAccount = String.Format("select AccountNo from eventaccount Where visitorNo ={0}", visitorNoFound);
						string[,] eventAccountResult = DBConnection.ExecuteQuery1(1, getDataEventAccount, 1);
						//if (eventAccountResult != null)
						//{

						//	string createEventAccountQuerry = string.Format("INSERT INTO eventaccount(TicketPaidMethod,TicketPrice,VisitorNo,CampingSpotNo) VALUES ('{0}','{1}','{2}','{3}')", 'E', 65, visitorNo[0, 0],0);
						//	int nrOfRowEventAccountInsert = DBConnection.ExecuteNonQuery(createEventAccountQuerry);
						//}
						//else if (eventAccountResult == null)
						//{
						//	//newAccountNo = 1;
						//	string createEventAccountQuerry = string.Format("INSERT INTO eventaccount(TicketPaidMethod,TicketPrice,VisitorNo,CampingSpotNo) VALUES ('{0}','{1}','{2}','{3}')", 'E', 65, visitorNo[0, 0], 0);
						//	int nrOfRowEventAccountInsert = DBConnection.ExecuteNonQuery(createEventAccountQuerry);
						//}
						//char checkinstatus = 'T';
						//string createParticipantQuerry = string.Format("INSERT INTO participant(AccountNo,RFIDNo,EventNo,CheckInStatus) VALUES ('{0}','{1}','{2}','{3}')",0, tbNewRFID.Text, 1, checkinstatus);
						//int nrOfRowParticipantQuerry = DBConnection.ExecuteNonQuery(createParticipantQuerry);
						string rfid = tbNewRFID.Text;
						int accountNoFound = Convert.ToInt32(eventAccountResult[0, 0]);
						string insertParticipant = string.Format("insert into participant(rfidno, accountno, eventno, checkinstatus) values('{0}', '{1}', '{2}', '{3}')", rfid, accountNoFound, 1, "T");
						DBConnection.ExecuteNonQuery(insertParticipant);
						MessageBox.Show("Added Successfully");
					}
					else
					{
						MessageBox.Show("Email exists");
					}
				}


			}
			catch (System.FormatException E)
			{
				MessageBox.Show(E.Message);

			}
			finally
			{
				//myRFID.Close();
			}
		}


		private void RFID_Create(object sender, RFIDTagEventArgs e)
		{
			lstRFID.Clear();
			tbNewRFID.Text = e.Tag;
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
					if (tbNewRFID.Text == s)
					{
						MessageBox.Show("this card has been used!!!");
						tbNewRFID.Clear();
						break;
					}

				}


			}
			myRFID.Close();
		}
		//
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
		private void bttScan_Click(object sender, EventArgs e)
		{


			StartUpCreate();



		}
		private void RFID_Reader(object sender, RFIDTagEventArgs e)
		{
			if (e.Tag != "")
			{
				// Participant s;
				string sql1 = "select * from participant where RFIDNo = '" + e.Tag + "'";
				string[,] querryResult = DBConnection.ExecuteQuery1(1, sql1, 4);
				if (querryResult != null)
				{
					string sql2 = "select * from eventaccount where AccountNo = '" + Convert.ToInt32(querryResult[0, 1]) + "'";
					string[,] querryResult2 = DBConnection.ExecuteQuery1(1, sql2, 8);
					if (querryResult2 != null)
					{
						string sql3 = "select * from visitor where VisitorNo = '" + Convert.ToInt32(querryResult2[0, 7]) + "'";
						string[,] querryResult3 = DBConnection.ExecuteQuery1(1, sql3, 10);
						if (querryResult3 != null)
						{

							tbxRegisteredId.Text = e.Tag + "";
							tbxRegisteredName.Text = Convert.ToString(querryResult3[0, 3]) + " " + Convert.ToString(querryResult3[0, 4]);
						
							tbPhone.Text = Convert.ToString(querryResult3[0, 7]);
							tbxRegisteredAccNo.Text = Convert.ToString(querryResult[0, 1]);
							
							myRFID.Close();
						}

					}
					else
					{
						MessageBox.Show("Wrong RFID");
					}
				}
				else
				{
					MessageBox.Show("Cannot find!");
				}

				//staff1 = myEvent.findStaffByRFID(e.Tag);
				//if (staff1 != null)
				//{
				//    this.Visible = false;
				//    myRFID.Close();
				//}
				//else
				//{
				//    MessageBox.Show("Wrong RIFD!");
				//}
			}
			myRFID.Close();
		}

		private void bttCheckIn_Click(object sender, EventArgs e)
		{
			try
			{
				string sql1 = "UPDATE participant SET 'CheckInStatus'='y' WHERE rfidno = '" + tbxRegisteredId.Text + "'";
			}
			catch (System.FormatException E)
			{
				MessageBox.Show("Wrong input");
			}
		}

		//private void bttSearchCode_Click(object sender, EventArgs e)
		//{

		//        StartUpCheck();

		//}
		public void StartUpCheck()
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
		private void RFID_CheckOut(object sender, RFIDTagEventArgs e)
		{
			if (e.Tag != "")
			{
				textBox2.Text = e.Tag;
			}
			myRFID.Close();
		}
		public void StartUpCheckOut()
		{
			try
			{
				myRFID = new RFID();

				myRFID.Tag += RFID_CheckOut;

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

		private void bttCheckOut_Click(object sender, EventArgs e)
		{
			try
			{
				string sql1 = "UPDATE participant SET 'CheckInStatus'='n' WHERE rfidno = '" + tbxRegisteredId.Text + "'";
			}
			catch (System.FormatException E)
			{
				MessageBox.Show("Wrong input");
			}
		}
		
		//    private bool checkDOB()
		//    {
		//        bool check = true;
		//        string[] arrTemp = tbDOBNew.Text.Split('/', '-');

		//if (Convert.ToInt32(arrTemp[0]) < 1900 || Convert.ToInt32(arrTemp[0]) > 2018)
		//{

		//	check = false;
		//}
		//else if (Convert.ToInt32(arrTemp[1]) < 1 || Convert.ToInt32(arrTemp[1]) > 12)
		//{

		//	check = false;
		//}
		//else if (Convert.ToInt32(arrTemp[1]) < 1 || Convert.ToInt32(arrTemp[1]) > 31)
		//{

		//	check = false;
		//}

		//else if(tbDOB.Text==""){ check = false; }


		//        return check;
		//    }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void bttSearchCode_Click_1(object sender, EventArgs e)
		{
			StartUpCreate();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string sql1 = string.Format("select visitorNo from eventAccount where accountNo = '{0}'",textBox1.Text);
			string[,] querryResult = DBConnection.ExecuteQuery1(1, sql1, 1);
			if (querryResult != null)
			{
				string sql2 = string.Format("select * from visitor where visitorNo ='{0}'",Convert.ToInt32(querryResult[0, 0]));			
				string[,] querryResult2 = DBConnection.ExecuteQuery1(1, sql2, 9);
				if (querryResult2 != null)
				{

					tbxRegisteredName.Text = Convert.ToString(querryResult2[0, 3]) + " " + Convert.ToString(querryResult2[0, 4]);
					
					tbPhone.Text = Convert.ToString(querryResult2[0, 7]);
					tbxRegisteredAccNo.Text = Convert.ToString(querryResult2[0, 0]);
				}


				else
				{
					MessageBox.Show("Wrong ID");
				}

				}
				else
				{
					MessageBox.Show("Wrong ID");
				}
			}

		private void btUpdate_Click(object sender, EventArgs e)
		{
			if (tbxRegisteredId.Text != "")
			{
				string update = string.Format("Insert into participant(RFIDNo,AccountNo,EventNo,CheckInStatus) Values('{0}','{1}','{2}','{3}')",tbxRegisteredId.Text,Convert.ToInt32(tbxRegisteredAccNo.Text),1,"T");
				int i = DBConnection.ExecuteNonQuery(update);
			}
		}

		private void bttCheckOut_Click_1(object sender, EventArgs e)
		{


			string query1 = string.Format("select RFIDNo from Participant where RFIDNo = '{0}'", textBox2.Text);		
			string[,] result = DBConnection.ExecuteQuery1(1, query1, 1);
			if (result != null)
			{
				string query2 = string.Format("select OrderNo from ordernumber where RFIDNo ='{0}'", result[0, 0]);
				string getRows1 = "select count(*) from ordernumber";
				string[,] result1 = DBConnection.ExecuteQuery(getRows1, query2, 1);
				if (result1 != null)
				{
					
					for (int i = 0; i < result1.GetLength(0); i++)
					{
						string query3 = string.Format("select borrowingstatus from order_line_item where orderno={0} and borrowingstatus='{1}'", result1[i, 0],"B");
						string[,] result2 = DBConnection.ExecuteQuery1(1, query3, 2);
						if (result2 != null)
						{

							MessageBox.Show("Please return all devices you borrowed before you leave");
						}
						else
						{
							string update1 = string.Format("Update order_line_item set borrowingstatus = '{0}'Where orderNo = '{1}'", 'N', result1[i, 0]);
							string update = string.Format("Update participant set checkInstatus = '{0}'Where RFIDNo = '{1}'", 'F', textBox2.Text);
							string select = string.Format("select AccountNo from participant where RFIDNo='{0}'", textBox2.Text);
							string[,] selectResult = DBConnection.ExecuteQuery1(1, select, 1);
							string update2 = string.Format("update eventaccount set balance='{0}'where accountNo='{1}'", 0, selectResult[0, 0]);
							 DBConnection.ExecuteNonQuery(update1);
							 DBConnection.ExecuteNonQuery(update);
							 DBConnection.ExecuteNonQuery(update2);


							MessageBox.Show("Check Out Successfully!The remaining amount of money in the account has been returned");

						}
							
							
						}

					}

				}

			}
		

		

		private void button3_Click(object sender, EventArgs e)
		{
			StartUpCheckOut();
		}
	}

	
	}


