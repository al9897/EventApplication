using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProPApplication
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			panelMenu.Visible = false;
			adminPanel.Visible = false;
			food.Visible = false;
			drink.Visible = false;
			addParticipant.Visible = false;
			borrowDevice.Visible = false;
			rent.Visible = false;
			employee.Visible = false;
			shopPanel1.Visible = false;
			logIn1.Dock = DockStyle.Fill;
			logIn1.Location = new Point(56, 39);
			logIn1.Size = new Size(900, 486);
			this.panelShowInfo.Visible = false;			
			this.profile1.Visible = false;
			pictureBox3.Visible = true;
			pictureBox8.Visible = true;
			pictureBox2.Visible = true;
			pictureBox7.Visible = true;
			pictureBox5.Visible = true;
			pbxAdmin.Visible = true;
			pictureBox4.Visible = true;


		}

		//new Point(56,39);
		//new Size(900, 486);
		public int checkLoginStatus;
		public string RFID;
		public Shop myShop = null;

		private void pbxAdmin_Click(object sender, EventArgs e)
		{
			shopPanel1.Visible = false;
			adminPanel.Visible = true;
			food.Visible = false;
			drink.Visible = false;
			addParticipant.Visible = false;
			borrowDevice.Visible = false;
			employee.Visible = false;
			rent.Visible = false;
			adminPanel.Location = new Point(56, 39);
			adminPanel.Size = new Size(900, 486);
			this.Text = "Admin Panel";
			this.profile1.Visible = false;
			pictureBox2.BorderStyle = BorderStyle.None;
			pbxAdmin.BorderStyle = BorderStyle.Fixed3D;
			pictureBox4.BorderStyle = BorderStyle.None;
			pictureBox5.BorderStyle = BorderStyle.None;
			pictureBox3.BorderStyle = BorderStyle.None;
			pictureBox6.BorderStyle = BorderStyle.None;
			pictureBox7.BorderStyle = BorderStyle.None;
			pictureBox8.BorderStyle = BorderStyle.None;
			pictureBox1.BorderStyle = BorderStyle.None;


		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			shopPanel1.Visible = false;
			adminPanel.Visible = false;
			food.Visible = false;
			drink.Visible = false;
			addParticipant.Visible = false;
			borrowDevice.Visible = true;
			this.Text = "Device Shop";
			pictureBox2.BorderStyle = BorderStyle.Fixed3D;
			pbxAdmin.BorderStyle = BorderStyle.None;
			pictureBox4.BorderStyle = BorderStyle.None;
			pictureBox5.BorderStyle = BorderStyle.None;
			pictureBox3.BorderStyle = BorderStyle.None;
			pictureBox6.BorderStyle = BorderStyle.None;
			pictureBox7.BorderStyle = BorderStyle.None;
			pictureBox8.BorderStyle = BorderStyle.None;
			pictureBox1.BorderStyle = BorderStyle.None;
			borrowDevice.Location = new Point(56, 39);
			borrowDevice.Size = new Size(900, 486);
			employee.Visible = false;
			rent.Visible = false;
			this.profile1.Visible = false;

            if (logIn1.staff1.Role != "manager")
            {
                foreach (Shop s in borrowDevice.managerLoanShopList)
                {
                    if (s.ShopNo == borrowDevice.myShop.ShopNo)
                    {
                        borrowDevice.myShop = s;
                        borrowDevice.myShop.ItemToSell = s.ItemToSell;
                    }
                }
                if (borrowDevice.myShop.ShopType == "FoodShop")
                {
                    DBConnection.UpdateLabel2(food.tabpagePizza1, food.tabpageSnack1, borrowDevice.myShop.GetItemList());
                }
            }
        }

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			pictureBox2.BorderStyle = BorderStyle.None;
			pbxAdmin.BorderStyle = BorderStyle.None;
			pictureBox4.BorderStyle = BorderStyle.Fixed3D;
			pictureBox5.BorderStyle = BorderStyle.None;
			pictureBox3.BorderStyle = BorderStyle.None;
			pictureBox6.BorderStyle = BorderStyle.None;
			pictureBox7.BorderStyle = BorderStyle.None;
			pictureBox8.BorderStyle = BorderStyle.None;
			pictureBox1.BorderStyle = BorderStyle.None;

			shopPanel1.Visible = false;
			adminPanel.Visible = false;
			food.Visible = true;
			this.Text = "Food shop";
			food.Location = new Point(56, 39);
			food.Size = new Size(900, 486);
			drink.Visible = false;
			addParticipant.Visible = false;
			borrowDevice.Visible = false;
			employee.Visible = false;
			rent.Visible = false;
			this.profile1.Visible = false;

			if (logIn1.staff1.Role != "manager")
			{
                foreach(Shop s in food.managerFoodShopList)
                {
                    if(s.ShopNo == food.myShop.ShopNo)
                    {
                        food.myShop = s;
                        food.myShop.ItemToSell = s.ItemToSell;
                    }
                }
				if (food.myShop.ShopType == "FoodShop")
				{
					DBConnection.UpdateLabel2(food.tabpagePizza1, food.tabpageSnack1, food.myShop.GetItemList());
				}
				food.tbQuantity.Visible = false;
				food.labelQuantity.Visible = false;
				food.foodCbAllShop.Visible = false;
			}
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			pictureBox2.BorderStyle = BorderStyle.None;
			pbxAdmin.BorderStyle = BorderStyle.None;
			pictureBox4.BorderStyle = BorderStyle.None;
			pictureBox5.BorderStyle = BorderStyle.Fixed3D;
			pictureBox3.BorderStyle = BorderStyle.None;
			pictureBox6.BorderStyle = BorderStyle.None;
			pictureBox7.BorderStyle = BorderStyle.None;
			pictureBox8.BorderStyle = BorderStyle.None;
			pictureBox1.BorderStyle = BorderStyle.None;

			shopPanel1.Visible = false;
			adminPanel.Visible = false;
			food.Visible = false;
			drink.Visible = true;
			this.Text = "Drink shop";
			drink.Location = new Point(56, 39);
			drink.Size = new Size(900, 486);
			addParticipant.Visible = false;
			borrowDevice.Visible = false;
			employee.Visible = false;
			rent.Visible = false;
			this.profile1.Visible = false;

			if (logIn1.staff1.Role != "manager")
			{
                foreach(Shop s in drink.managerDrinkShopList)
                {
                    if(s.ShopNo == drink.myShop.ShopNo)
                    {
                        drink.myShop = s;
                        drink.myShop.ItemToSell = s.ItemToSell;
                    }
                }
				if (drink.myShop.ShopType == "DrinkShop")
				{
					DBConnection.UpdateLabel2(drink.tabPageSoftDrink1, drink.tabPageAlcohol1, drink.myShop.GetItemList());
				}
				drink.tbQuantity.Visible = false;
				drink.drinkCbAllShop.Visible = false;
				drink.labelQuantity.Visible = false;
			}
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			pictureBox2.BorderStyle = BorderStyle.None;
			pbxAdmin.BorderStyle = BorderStyle.None;
			pictureBox4.BorderStyle = BorderStyle.None;
			pictureBox5.BorderStyle = BorderStyle.None;
			pictureBox3.BorderStyle = BorderStyle.None;
			pictureBox6.BorderStyle = BorderStyle.Fixed3D;
			pictureBox7.BorderStyle = BorderStyle.None;
			pictureBox8.BorderStyle = BorderStyle.None;
			pictureBox1.BorderStyle = BorderStyle.None;

			shopPanel1.Visible = false;
			adminPanel.Visible = false;
			food.Visible = false;
			drink.Visible = false;
			this.profile1.Visible = false;

			addParticipant.Visible = true;
			this.Text = "Add Participant";
			addParticipant.Location = new Point(56, 39);
			addParticipant.Size = new Size(900, 486);
			borrowDevice.Visible = false;
			employee.Visible = false;
			rent.Visible = false;
		}

		//method to populate item in a shop list
		private void PopulateItemInAShopList(List<Shop> shopList)
		{
			foreach (Shop search in shopList)
			{
				string sql2 = "select * from item where shopno = " + search.ShopNo;
				string scalar = "select count(*) from item where shopno = " + search.ShopNo;
				string[,] result2 = DBConnection.ExecuteQuery(scalar, sql2, 6);
				if (result2 != null)
				{
					for (int i = 0; i < result2.GetLength(0); i++)
					{
						if (search.ShopType == "FoodShop")
						{
							search.AddItem(new FoodType(Convert.ToInt32(result2[i, 1]), result2[i, 3], Convert.ToInt32(result2[i, 4]), Convert.ToDecimal(result2[i, 2]), Convert.ToInt32(result2[i, 0]), result2[i, 5]));
						}
						else if (search.ShopType == "DrinkShop")
						{
							search.AddItem(new DrinkType(Convert.ToInt32(result2[i, 1]), result2[i, 3], Convert.ToInt32(result2[i, 4]), Convert.ToDecimal(result2[i, 2]), Convert.ToInt32(result2[i, 0]), result2[i, 5]));
						}
						else if (search.ShopType == "LoaningStand")
						{
							search.AddItem(new LoanType(Convert.ToInt32(result2[i, 1]), result2[i, 3], Convert.ToInt32(result2[i, 4]), Convert.ToDecimal(result2[i, 2]), Convert.ToInt32(result2[i, 0]), result2[i, 5]));
						}
					}
				}
			}
		}

		private void logIn1_VisibleChanged(object sender, EventArgs e)
		{
			
			if (logIn1.Visible == false)
			{
				//this.Text = logIn1.employeeRFID;
				//MessageBox.Show(logIn1.employeeRFID);
				
				this.panelShowInfo.Visible = true;
				panelMenu.Visible = true;
				adminPanel.Visible = true;
				adminPanel.Location = new Point(56, 39);
				adminPanel.Size = new Size(900, 486);
				//profile staff
				profile1.myStaff = logIn1.staff1;
				if(logIn1.staff1 != null)
				{
					profile1.name.Text = logIn1.staff1.Name;
					profile1.rfid.Text = logIn1.staff1.RFIDNO;
					profile1.Role.Text = logIn1.staff1.Role;
					lbWelcome.Text = "Welcome  "+logIn1.staff1.Name;


				}
				

				//retrieve data from db
				if (logIn1.staff1 != null)
				{
					//Admin Panel
					if (logIn1.staff1.Role == "manager")
					{
						adminPanel.myStaff = logIn1.staff1;
					}

					//tent
					rent.myStaff = logIn1.staff1;
					string sqlFindAllAvailableTent = "select campingspotno from campingspot c where not exists (select 1 from reservation where campingspotno = c.campingspotno)";
					string countAllAvailableTent = "select count(*) from campingspot c where not exists (select 1 from reservation where campingspotno = c.campingspotno)";
					string[,] allTent = DBConnection.ExecuteQuery(countAllAvailableTent, sqlFindAllAvailableTent, 1);
					//populate combo box
					if (allTent != null)
					{
						foreach (string search in allTent)
						{
							rent.comboBoxAllTentCheck.Items.Add(search);
						}
					}

					//GetAllShop
					shopPanel1.myStaff = logIn1.staff1;
					string getTotalRecords = "select count(*) from shop";
					string getAllShops = "select * from shop";
					string[,] allShop = DBConnection.ExecuteQuery(getTotalRecords, getAllShops, 3);

					//populate shop list
					for (int i = 0; i < allShop.GetLength(0); i++)
					{
						shopPanel1.comboBoxShop.Items.Add(allShop[i, 0]);
						//shop panel shop list
						shopPanel1.shopList.Add(new Shop(allShop[i, 1], Convert.ToInt32(allShop[i, 0]), allShop[i, 2]));
						//admin shop list
						adminPanel.shopList.Add(new Shop(allShop[i, 1], Convert.ToInt32(allShop[i, 0]), allShop[i, 2]));
						//here is for shop list in each different shop
						if (allShop[i, 2] == "FoodShop")
						{
							food.managerFoodShopList.Add(new Shop(allShop[i, 1], Convert.ToInt32(allShop[i, 0]), allShop[i, 2]));
							food.foodCbAllShop.Items.Add(allShop[i, 0]);
						}
						else if (allShop[i, 2] == "DrinkShop")
						{
							drink.managerDrinkShopList.Add(new Shop(allShop[i, 1], Convert.ToInt32(allShop[i, 0]), allShop[i, 2]));
							drink.drinkCbAllShop.Items.Add(allShop[i, 0]);
						}
						else if (allShop[i, 2] == "LoaningStand")
						{
							borrowDevice.managerLoanShopList.Add(new Shop(allShop[i, 1], Convert.ToInt32(allShop[i, 0]), allShop[i, 2]));
							borrowDevice.cbCheckAllShop.Items.Add(allShop[i, 0]);
						}
					}

					//populate item in shoplist
					PopulateItemInAShopList(food.managerFoodShopList);
					PopulateItemInAShopList(drink.managerDrinkShopList);
					PopulateItemInAShopList(borrowDevice.managerLoanShopList);

					//list for shop panel 
					string totalNumberOfEmployee = "select count(*) from employee";
					string getAllEmployee = "select * from employee";
					string[,] allEmployee = DBConnection.ExecuteQuery(totalNumberOfEmployee, getAllEmployee, 10);
					for (int i = 0; i < allEmployee.GetLength(0); i++)
					{
						if (allEmployee[i, 8] == "")
						{
							Staff tempStaff = new Staff(allEmployee[i, 1] + " " + allEmployee[i, 2], allEmployee[i, 3], allEmployee[i, 6], Convert.ToInt32(allEmployee[i, 0]), allEmployee[i, 5], Convert.ToInt32(allEmployee[i, 9]), 0);
							shopPanel1.employeeList.Add(tempStaff);
						}
						else
						{
							Staff tempStaff = new Staff(allEmployee[i, 1] + " " + allEmployee[i, 2], allEmployee[i, 3], allEmployee[i, 6], Convert.ToInt32(allEmployee[i, 0]), allEmployee[i, 5], Convert.ToInt32(allEmployee[i, 9]), Convert.ToInt32(allEmployee[i, 8]));
							shopPanel1.employeeList.Add(tempStaff);
						}
						shopPanel1.comboBoxEmployee.Items.Add(allEmployee[i, 0]);
					}

					//For employee and manager
					foreach (Shop search in shopPanel1.shopList)
					{
						if (logIn1.staff1.Role == "manager")
						{
							food.tbQuantity.Visible = true;
							drink.tbQuantity.Visible = true;
							borrowDevice.tbCheckAddQuantity.Visible = true;
							food.labelQuantity.Visible = true;
							drink.labelQuantity.Visible = true;
							borrowDevice.labelCheckAddQuantity.Visible = true;
							managerLogIn();
						// the manager can access every shop in the event.
						if (search.ShopType == "FoodShop")
							{
								myShop = search;
								food.myShop = search;
								food.myStaff = logIn1.staff1;
							}
							else if (search.ShopType == "DrinkShop")
							{
								myShop = search;
								drink.myShop = search;
								drink.myStaff = logIn1.staff1;
							}
							else if (search.ShopType == "LoaningStand")
							{
								myShop = search;
								borrowDevice.myShop = search;
								borrowDevice.myStaff = logIn1.staff1;
							}
						}
						else
						{
							//specific shop depending on individual employee
							if (search.ShopNo == logIn1.staff1.ShopNo)
							{
								if (search.ShopType == "FoodShop")
								{
									otherLogin();
									HideUser();
									food.labelQuantity.Visible = false;
									food.tbQuantity.Visible = false;
									food.foodCbAllShop.Visible = true;
									pictureBox4.Visible = true;
									food.Location = new Point(56, 39);
									food.Size = new Size(900, 486);
									food.Visible = true;
									adminPanel.Visible = false;
									myShop = search;
									food.myShop = search;
									food.myStaff = logIn1.staff1;

								}
								else if (search.ShopType == "DrinkShop")
								{
									otherLogin();
									HideUser();
									drink.labelQuantity.Visible = false;
									drink.tbQuantity.Visible = false;
									drink.drinkCbAllShop.Visible = true;
									pictureBox5.Visible = true;
									drink.Location = new Point(56, 39);
									drink.Size = new Size(900, 486);
									drink.Visible = true;	
									myShop = search;
									drink.myShop = search;
									drink.myStaff = logIn1.staff1;
									food.myStaff = logIn1.staff1;
								}

								else if (search.ShopType == "LoaningStand")
								{
									//borrowDevice.Visible = true;
									otherLogin();
									HideUser();
									borrowDevice.labelCheckAddQuantity.Visible = false;
									borrowDevice.tbCheckAddQuantity.Visible = false;
									borrowDevice.cbCheckAllShop.Visible = true;
									borrowDevice.Location = new Point(56, 39);
									borrowDevice.Size = new Size(900, 486);									
									borrowDevice.Visible = true;								
									pictureBox2.Visible = true;
									myShop = search;
									borrowDevice.myShop = search;
									borrowDevice.myStaff = logIn1.staff1;


								}
							}
						}
					}
					
					//Showing panel for each individual
					//    if(myShop.ShopType == "FoodShop")
					//    {
					//        pictureBox5.Visible = false;
					//        pictureBox3.Visible = false;
					//    }
					//    else if(myShop.ShopType == "DrinkShop")
					//    {
					//        pictureBox4.Visible = false;
					//        pictureBox3.Visible = false;
					//    }
					//    else
					//    {
					//        pictureBox4.Visible = false;
					//        pictureBox5.Visible = false;
					//    }
				}
			}
		}

		private void managerLogIn()
		{
			pictureBox3.Visible = true;
			pictureBox8.Visible = true;
			pictureBox2.Visible = true;
			pictureBox7.Visible = true;
			pictureBox5.Visible = true;
			pbxAdmin.Visible = true;
			pictureBox4.Visible = true;
			adminPanel.Visible = true;
		}
		private void HideUser()
		{
			shopPanel1.Visible = false;
			adminPanel.Visible = false;
			food.Visible = false;
			drink.Visible = false;
			addParticipant.Visible = false;
			borrowDevice.Visible = false;
			employee.Visible = false;
			profile1.Visible = false;
		}
		private void otherLogin()
		{
			pictureBox3.Visible = false;
			pictureBox8.Visible = false;
			pictureBox2.Visible = false;
			pictureBox7.Visible = false;
			pictureBox5.Visible = false;
			pbxAdmin.Visible = false;
			pictureBox4.Visible = false;
		}
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			pictureBox2.BorderStyle = BorderStyle.None;
			pbxAdmin.BorderStyle = BorderStyle.None;
			pictureBox4.BorderStyle = BorderStyle.None;
			pictureBox5.BorderStyle = BorderStyle.None;
			pictureBox3.BorderStyle = BorderStyle.Fixed3D;
			pictureBox6.BorderStyle = BorderStyle.None;
			pictureBox7.BorderStyle = BorderStyle.None;
			pictureBox8.BorderStyle = BorderStyle.None;
			pictureBox1.BorderStyle = BorderStyle.None;

			shopPanel1.Visible = false;
			adminPanel.Visible = false;
			food.Visible = false;
			drink.Visible = false;
			addParticipant.Visible = false;
			borrowDevice.Visible = false;
			employee.Visible = false;
			rent.Visible = true;
			this.Text = "Rent";
			rent.Location = new Point(56, 39);
			rent.Size = new Size(900, 486);
			this.profile1.Visible = false;
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			pictureBox2.BorderStyle = BorderStyle.None;
			pbxAdmin.BorderStyle = BorderStyle.None;
			pictureBox4.BorderStyle = BorderStyle.None;
			pictureBox5.BorderStyle = BorderStyle.None;
			pictureBox3.BorderStyle = BorderStyle.None;
			pictureBox6.BorderStyle = BorderStyle.None;
			pictureBox7.BorderStyle = BorderStyle.Fixed3D;
			pictureBox8.BorderStyle = BorderStyle.None;
			pictureBox1.BorderStyle = BorderStyle.None;

			shopPanel1.Visible = false;
			adminPanel.Visible = false;
			food.Visible = false;
			drink.Visible = false;
			addParticipant.Visible = false;
			borrowDevice.Visible = false;
			employee.Visible = true;
			this.Text = "Employee";
			rent.Visible = false;
			employee.Location = new Point(56, 39);
			employee.Size = new Size(900, 486);
			this.profile1.Visible = false;
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			adminPanel.Visible = false;
			food.Visible = false;
			drink.Visible = false;
			addParticipant.Visible = false;
			borrowDevice.Visible = false;
			employee.Visible = false;
			rent.Visible = false;
			shopPanel1.Visible = true;
			shopPanel1.Location = new Point(56, 39);
			shopPanel1.Size = new Size(900, 486);
			this.profile1.Visible = false;
			this.Text = "ShopPanel";
			pictureBox2.BorderStyle = BorderStyle.None;
			pbxAdmin.BorderStyle = BorderStyle.None;
			pictureBox4.BorderStyle = BorderStyle.None;
			pictureBox5.BorderStyle = BorderStyle.None;
			pictureBox3.BorderStyle = BorderStyle.None;
			pictureBox6.BorderStyle = BorderStyle.None;
			pictureBox7.BorderStyle = BorderStyle.None;
			pictureBox8.BorderStyle = BorderStyle.Fixed3D;
			pictureBox1.BorderStyle = BorderStyle.None;

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Text = "Welcome!";
			
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//logIn1.logInAgain();
			
			adminPanel.ResetText();
			this.panelShowInfo.Visible = false;
			this.panelMenu.Visible = false;
			this.profile1.Visible = false;
			logIn1.Visible = true;
			logIn1.Dock = DockStyle.Fill;
			logIn1.Location = new Point(56, 39);
			logIn1.Size = new Size(900, 486);
			logIn1.staff1 = null;
			logIn1.StartUp();
			profile1.getUserAndPass();
			//logIn1.StartUp();

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			pictureBox2.BorderStyle = BorderStyle.None;
			pbxAdmin.BorderStyle = BorderStyle.None;
			pictureBox4.BorderStyle = BorderStyle.None;
			pictureBox5.BorderStyle = BorderStyle.None;
			pictureBox3.BorderStyle = BorderStyle.None;
			pictureBox6.BorderStyle = BorderStyle.None;
			pictureBox7.BorderStyle = BorderStyle.None;
			pictureBox8.BorderStyle = BorderStyle.None;
			pictureBox1.BorderStyle = BorderStyle.Fixed3D;
			adminPanel.Visible = false;
			food.Visible = false;
			drink.Visible = false;
			addParticipant.Visible = false;
			borrowDevice.Visible = false;
			employee.Visible = false;
			rent.Visible = false;
			shopPanel1.Visible = false;
			profile1.Location = new Point(56, 39);
			profile1.Size = new Size(900, 486);
			this.profile1.Visible = true;
			this.Text = "Profile";
		}
	}
}
