using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;
namespace ProPApplication
{
    public partial class Food : UserControl
    {
        public Food()
        {
            InitializeComponent();
            mainForm = Form.ActiveForm;
            this.tabpagePizza1 = tabPagePizza;
            this.tabpageSnack1 = tabPageSnack;
            this.foodCbAllShop = cbShop;
            this.labelQuantity = lbAddQuantity;
            this.tbQuantity = tbAddQuantity;
            managerFoodShopList = new List<Shop>();
            myTimer.Start();
        }

		//Favorite food 
		private RFID myRFID;
		private string RFIDNoGlobal;
        public List<Shop> managerFoodShopList;
        Form mainForm;
        public Shop myShop;
        public Shop managerShop;
        public Staff myStaff;
        //created to be accessed in main form;
        public TabPage tabpagePizza1;
        public TabPage tabpageSnack1;
        public ComboBox foodCbAllShop;
        public Label labelQuantity;
        public TextBox tbQuantity;
        int invoiceOrderNo = 0;

        private void ShowToListBox()
        {
            lbOrder.Items.Clear();
            string header = "Item number      Name      Quantity      Price";
            lbOrder.Items.Add(header);
            if (myStaff.Role == "manager")
            {
                foreach (Item search in managerShop.ItemToSell)
                {
                    if (search.SellingQuantity != 0)
                    {
                        lbOrder.Items.Add(search);
                    }
                }
            }
            else
            {
                foreach (Item search in myShop.ItemToSell)
                {
                    if (search.SellingQuantity != 0)
                    {
                        lbOrder.Items.Add(search);
                    }
                }
            }
        }

        private void lbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOrder.SelectedItem != null)
            {
                FoodType selectedItem = (FoodType)lbOrder.SelectedItem;
                if (myStaff.Role != "manager")
                {
                    myShop.findItem(selectedItem.ItemNo).RemoveSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                }
                else
                {
                    managerShop.findItem(selectedItem.ItemNo).RemoveSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                }
                this.ShowToListBox();
            }
        }

        private void WriteInvoice(string fileName)
        {
            decimal total = 0;
            using (FileStream fsWrite = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fsWrite))
                {
                    sw.WriteLine("Order Number: {0}", invoiceOrderNo);
                    sw.WriteLine("*********************************************************");
                    sw.WriteLine("Item number              Name          Quantity      Price");
                    if (myStaff.Role != "manager")
                    {
                        foreach (Item search in myShop.ItemToSell)
                        {
                            if (search.SellingQuantity != 0)
                            {
                                sw.WriteLine(search);
                                total += search.SellingQuantity * search.Price;
                            }
                        }
                        sw.WriteLine("*********************************************************");
                        sw.WriteLine("                                      Total: {0}", total);
                        sw.WriteLine("Seller: {0}", myStaff.Name);
                    }
                    else
                    {
                        foreach (Item search in managerShop.ItemToSell)
                        {
                            if (search.SellingQuantity != 0)
                            {
                                sw.WriteLine(search);
                                total += search.SellingQuantity * search.Price;
                            }

                        }
                        sw.WriteLine("*********************************************************");
                        sw.WriteLine("                                      Total: {0}", total);
                        sw.WriteLine("Seller: {0}", myStaff.Name);
                    }
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string asterisk = string.Format("*************************************************");
            string total = "                                               Total: " + this.GetTotalPrice();
            string fileName = "Invoice//FoodReceipt.txt";
            string getLatestOrderNo = "select max(orderno) from ordernumber";
            string[,] result1 = DBConnection.ExecuteQuery1(1, getLatestOrderNo, 1);
            invoiceOrderNo = Convert.ToInt32(result1[0, 0]) + 1;
            WriteInvoice(fileName);
            lbOrder.Items.Add(asterisk);
            lbOrder.Items.Add(total);
        }
        //Get total price for receipt
        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            if (myStaff.Role != "manager")
            {
                foreach (Item search in myShop.ItemToSell)
                {
                    if (search.SellingQuantity != 0)
                    {
                        totalPrice += search.SellingQuantity * search.Price;
                    }
                }
            }
            else
            {
                foreach (Item search in managerShop.ItemToSell)
                {
                    if (search.SellingQuantity != 0)
                    {
                        totalPrice += search.SellingQuantity * search.Price;
                    }
                }
            }
            return totalPrice;
        }
        //find shop for manager
        private Shop FindShop(int shopNo)
        {
            Shop tempShop = null;
            foreach (Shop search in this.managerFoodShopList)
            {
                if (search.ShopNo == shopNo)
                {
                    if (search.ShopType == "FoodShop")
                    {
                        tempShop = search;
                    }
                }
            }
            return tempShop;
        }
        // update quantity manager only



        private void UpdateQuantity(int itemNo, int amount)
        {
            managerShop.findItem(itemNo).Quantity += amount;
            string sql2 = string.Format("update item set quantity = {0} where itemno = {1} and shopno = {2}", managerShop.findItem(itemNo).Quantity, managerShop.findItem(itemNo).ItemNo, managerShop.ShopNo);
            DBConnection.ExecuteNonQuery(sql2);
            DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (myStaff.Role == "manager")
            {
                if (tbAddQuantity.Text != "")
                {
                    int amount = Convert.ToInt32(tbAddQuantity.Text);
                    this.UpdateQuantity(1, amount);
                }
                else
                {
                    managerShop.findItem(1).AddSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                myShop.findItem(1).AddSellingQuantity();
                DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (myStaff.Role == "manager")
            {
                if (tbAddQuantity.Text != "")
                {
                    int amount = Convert.ToInt32(tbAddQuantity.Text);
                    this.UpdateQuantity(2, amount);
                }
                else
                {
                    managerShop.findItem(2).AddSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                myShop.findItem(2).AddSellingQuantity();
                DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (myStaff.Role == "manager")
            {
                if (tbAddQuantity.Text != "")
                {
                    int amount = Convert.ToInt32(tbAddQuantity.Text);
                    this.UpdateQuantity(3, amount);
                }
                else
                {
                    managerShop.findItem(3).AddSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                myShop.findItem(3).AddSellingQuantity();
                DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (myStaff.Role == "manager")
            {
                if (tbAddQuantity.Text != "")
                {
                    int amount = Convert.ToInt32(tbAddQuantity.Text);
                    this.UpdateQuantity(4, amount);
                }
                else
                {
                    managerShop.findItem(4).AddSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                myShop.findItem(4).AddSellingQuantity();
                DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (myStaff.Role == "manager")
            {
                if (tbAddQuantity.Text != "")
                {
                    int amount = Convert.ToInt32(tbAddQuantity.Text);
                    this.UpdateQuantity(5, amount);
                }
                else
                {
                    managerShop.findItem(5).AddSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                myShop.findItem(5).AddSellingQuantity();
                DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (myStaff.Role == "manager")
            {
                if (tbAddQuantity.Text != "")
                {
                    int amount = Convert.ToInt32(tbAddQuantity.Text);
                    this.UpdateQuantity(6, amount);
                }
                else
                {
                    managerShop.findItem(6).AddSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                myShop.findItem(6).AddSellingQuantity();
                DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (myStaff.Role == "manager")
            {
                if (tbAddQuantity.Text != "")
                {
                    int amount = Convert.ToInt32(tbAddQuantity.Text);
                    this.UpdateQuantity(8, amount);
                }
                else
                {
                    managerShop.findItem(8).AddSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                myShop.findItem(8).AddSellingQuantity();
                DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (myStaff.Role == "manager")
            {
                if (tbAddQuantity.Text != "")
                {
                    int amount = Convert.ToInt32(tbAddQuantity.Text);
                    this.UpdateQuantity(9, amount);
                }
                else
                {
                    managerShop.findItem(9).AddSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                myShop.findItem(9).AddSellingQuantity();
                DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (myStaff.Role == "manager")
            {
                if (tbAddQuantity.Text != "")
                {
                    int amount = Convert.ToInt32(tbAddQuantity.Text);
                    this.UpdateQuantity(10, amount);
                }
                else
                {
                    managerShop.findItem(10).AddSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                myShop.findItem(10).AddSellingQuantity();
                DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (myStaff.Role == "manager")
            {
                if (tbAddQuantity.Text != "")
                {
                    int amount = Convert.ToInt32(tbAddQuantity.Text);
                    this.UpdateQuantity(11, amount);
                }
                else
                {
                    managerShop.findItem(11).AddSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                myShop.findItem(11).AddSellingQuantity();
                DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (myStaff.Role == "manager")
            {
                if (tbAddQuantity.Text != "")
                {
                    int amount = Convert.ToInt32(tbAddQuantity.Text);
                    this.UpdateQuantity(12, amount);
                }
                else
                {
                    managerShop.findItem(12).AddSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                myShop.findItem(12).AddSellingQuantity();
                DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (myStaff.Role == "manager")
            {
                if (tbAddQuantity.Text != "")
                {
                    int amount = Convert.ToInt32(tbAddQuantity.Text);
                    this.UpdateQuantity(7, amount);
                }
                else
                {
                    managerShop.findItem(7).AddSellingQuantity();
                    DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                myShop.findItem(7).AddSellingQuantity();
                DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }
		
		private void RFID_Reader(object sender, RFIDTagEventArgs e)
		{
			if (e.Tag != null)
			{
				string querryCheckRFID = string.Format("select RFIDNo from Participant where RFIDNo='{0}'", e.Tag);
				string[,] checkRFIDResult = DBConnection.ExecuteQuery1(1, querryCheckRFID, 1);				
				if (checkRFIDResult != null)
				{
					RFIDNoGlobal = e.Tag;
				
					myRFID.Close();
				}
				else
				{
					MessageBox.Show("WrongRFID! Try Again");
				}

			}
			
			myRFID.Close();
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
		private void btnCheckRFID_Click(object sender, EventArgs e)
        {
			tbCheckRFID.Clear();
			StartUp();
			tbCheckRFID.Text = RFIDNoGlobal;
			//Get RFID
			if (tbCheckRFID.Text != "")
			{
				//Get max orderNo
				int orderNo;
				string[,] result1;
				string RFIDNo = RFIDNoGlobal;
				string time = Convert.ToString(DateTime.Now);
				decimal total = this.GetTotalPrice();
				string sqlInsert = string.Format("insert into ordernumber(purchasedtime, total, employeeno, rfidno) values('{0}', {1}, {2}, '{3}')", time, total, myStaff.EmployeeNo, RFIDNo);
				string getLatestOrderNo = "select max(orderno) from ordernumber";
				DBConnection.ExecuteNonQuery(sqlInsert);
				result1 = DBConnection.ExecuteQuery1(1, getLatestOrderNo, 1);
				orderNo = Convert.ToInt32(result1[0, 0]);
				//Buyer Balance
				string findBuyerAccount = string.Format("select accountno, balance from eventaccount where accountno = (select accountno from participant where rfidno = '{0}')", RFIDNo);
				string[,] buyerInfo = DBConnection.ExecuteQuery1(1, findBuyerAccount, 2);
				decimal updateBalance = Convert.ToDecimal(buyerInfo[0, 1]) - total;
				string updateBuyerBalance = string.Format("update eventaccount set balance = {0} where accountno = {1}", updateBalance, Convert.ToInt32(buyerInfo[0, 0]));
				DBConnection.ExecuteNonQuery(updateBuyerBalance);

				//line item update
				if (myStaff.Role != "manager")
				{
					foreach (Item search in myShop.GetItemList())
					{
						if (search.SellingQuantity != 0)
						{
							string sql1 = string.Format("insert into order_line_item(orderno, quantity, price, borrowingstatus, shopno, itemno) values({0}, {1}, {2}, '{3}', {4}, {5})", orderNo, search.SellingQuantity, search.SellingQuantity * search.Price, "N", myShop.ShopNo, search.ItemNo);
							string sql2 = string.Format("update item set quantity = {0} where itemno = {1} and shopno = {2}", search.Quantity, search.ItemNo, myShop.ShopNo);
							DBConnection.ExecuteNonQuery(sql1);
							DBConnection.ExecuteNonQuery(sql2);
							search.FinishSelling();
						}
					}
				}
				else
				{
					foreach (Item search in managerShop.GetItemList())
					{
						if (search.SellingQuantity != 0)
						{
							string sql1 = string.Format("insert into order_line_item(orderno, quantity, price, borrowingstatus, shopno, itemno) values({0}, {1}, {2}, '{3}', {4}, {5})", orderNo, search.SellingQuantity, search.SellingQuantity * search.Price, "N", managerShop.ShopNo, search.ItemNo);
							string sql2 = string.Format("update item set quantity = {0} where itemno = {1} and shopno = {2}", search.Quantity, search.ItemNo, managerShop.ShopNo);
							DBConnection.ExecuteNonQuery(sql1);
							DBConnection.ExecuteNonQuery(sql2);
							search.FinishSelling();
						}
					}
				}
				MessageBox.Show("Done!");
				lbOrder.Items.Clear();
				tbCheckRFID.Clear();
			}
			else
			{
				MessageBox.Show("Please input RFID first!");
			}
			
		}

        private void cbShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int shopNo = Convert.ToInt32(cbShop.SelectedItem);
            managerShop = this.FindShop(shopNo);
            DBConnection.UpdateLabel2(tabPagePizza, tabPageSnack, managerShop.GetItemList());
        }


        //For chart
        private void ShowFoodStatistic()
        {
            foreach (Series s in chartFood.Series)
            {
                s.Points.Clear();
            }
            foreach (Series s in chartSnack.Series)
            {
                s.Points.Clear();
            }
            //pizza
            chartFood.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartFood.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            //snack
            chartSnack.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartSnack.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            int count = 1;
            for (int i = 1; i < 13; i++)
            {
                if (myStaff != null)
                {
                    if (myStaff.Role == "manager")
                    {
                        if (managerShop != null)
                        {
                            string sqlSum = string.Format("select sum(price * quantity) from order_line_item where itemno = {0} and shopno = {1}", i, managerShop.ShopNo);
                            decimal total = DBConnection.ExecuteScalar(sqlSum);
                            if (total == -1)
                            {
                                total = 0;
                            }
                            if (i < 7)
                            {
                                chartFood.Series["Food"].Points.AddXY(string.Format("Pizza{0}", i), total);
                            }
                            else
                            {
                                chartSnack.Series["Snack"].Points.AddXY(string.Format("Snack{0}", count), total);
                                count++;
                            }
                        }
                    }
                }
            }
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            if (myStaff != null)
            {
                this.ShowFoodStatistic();
            }

        }

	
	}
}
