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

namespace ProPApplication.User_controls_for_app
{
	public partial class Profile : UserControl
	{
		
		Form1 mainform;
		public Staff myStaff;
		public Form1 Mainform { get => mainform; set => mainform = value; }
		private RFID myRFID;
		public Profile()
		{
			InitializeComponent();
			tbUserName.Enabled = false;
			tbRFIDNo.Enabled = false;
			textBox1.Enabled = false;
			//retrivedata();
			this.name = tbName;
			this.rfid = textBox1;
			this.Role = tbRole;
			this.username = tbUserName;
			this.password = tbPassWord;
		}
	
		public TextBox Role;
		public TextBox name;
		public TextBox rfid;
		public TextBox username;
		public TextBox password;
		//private void retrivedata()
		//{
		//	string sql1 = "select count(*) from employee";
		//	string sql2 = String.Format("select * from employee where rfidNo ={0}", Mainform.RFID);
		//	string[,] querryResult = DBConnection.ExecuteQuery(sql1, sql2, 11);
		//	if (querryResult != null)
		//	{
		//		tbName.Text = querryResult[0, 1] + querryResult[0, 2];
		//		tbRFIDNo.Text = querryResult[0, 6];
		//	}
		//}
		private void Profile_Load(object sender, EventArgs e)
		{
			getUserAndPass();
		}
		
		public void getUserAndPass()
		{
			string getUserName = string.Format("select username,password from Employee where RFIDNo='{0}'", textBox1.Text);
			string[,] getUserResult = DBConnection.ExecuteQuery1(1, getUserName, 2);
			this.tbUserName.Text = getUserResult[0,0];
			//this.tbPassWord.Text = getUserResult[0, 1];

		}
		private void button1_Click(object sender, EventArgs e)
		{
			 string hashedPassword = BCrypt.Net.BCrypt.HashPassword(tbPassWord.Text);
			if(tbPassWord.Text!=null && tbRFIDNo.Text!=null)
			{
				string update = string.Format("Update employee set RFIDNo ='{0}',password='{1}' where RFIDNo ='{2}' ", Convert.ToString(tbRFIDNo.Text), hashedPassword, textBox1.Text);
				DBConnection.ExecuteNonQuery(update);
			}
			else if(tbPassWord == null && tbRFIDNo.Text!=null)
			{
				string update = string.Format("Update employee set RFIDNo ='{0}'where RFIDNo ='{1}' ", Convert.ToString(tbRFIDNo.Text),textBox1.Text);

				DBConnection.ExecuteNonQuery(update);
			}
			else if (tbPassWord.Text!=null && tbRFIDNo.Text==null)
			{
				string update = string.Format("Update employee set password='{0}' where RFIDNo ='{1}' ", hashedPassword, textBox1.Text);

			}


		}

		private void btScan_Click(object sender, EventArgs e)
		{
			StartUp();
		}
		private void RFID_Reader(object sender, RFIDTagEventArgs e)
		{
			string rfidNo = e.Tag;
			if (e.Tag != null)
			{
				string querryCheckRFID = string.Format("select RFIDNo from Participant where RFIDNo='{0}'", rfidNo);
				string[,] checkRFIDResult = DBConnection.ExecuteQuery1(1, querryCheckRFID, 1);
				string querryCheckRFID1 = string.Format("select RFIDNo from Employee where RFIDNo='{0}'", rfidNo);
				string[,] checkRFIDResult1 = DBConnection.ExecuteQuery1(1, querryCheckRFID1, 1);
				if (checkRFIDResult == null && checkRFIDResult1==null)
				{
					this.tbRFIDNo.Text = e.Tag;

				}
				else
				{
					MessageBox.Show("RFID has been used");
				}
				myRFID.Close();
			}
			
			
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
	}
}
