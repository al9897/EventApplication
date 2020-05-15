using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace ProPApplication
{
    public partial class BorrowDevice : UserControl
    {
        public BorrowDevice()
        {
            InitializeComponent();
			
			managerLoanShopList = new List<Shop>();
            this.checkPanel = panel1;
            this.labelCheck = label7;
            this.labelCheckAddQuantity = label12;
            this.tbCheckAddQuantity = tbAddQuantity;
            this.cbCheckAllShop = cbAllShop;
            timer1.Start();

        }
		private RFID myRFID;
		private string RFIDNoGlobal;
		string currentRFIDNo;
        public List<Shop> managerLoanShopList;
        public Shop myShop;
        public Shop managerShop;
        public Staff myStaff;
        public Panel checkPanel;
        public Label labelCheck;
        public Label labelCheckAddQuantity;
        public TextBox tbCheckAddQuantity;
        public ComboBox cbCheckAllShop;
        //this is for when customer return device;
        List<Item> tempList;
        int invoiceOrderNo = 0;

        private Shop FindShop(int shopNo)
        {
            Shop tempShop = null;
            foreach (Shop search in this.managerLoanShopList)
            {
                if (search.ShopNo == shopNo)
                {
                    if (search.ShopType == "LoaningStand")
                    {
                        tempShop = search;
                    }
                }
            }
            return tempShop;
        }

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

        private void UpdateQuantity(int itemNo, int amount)
        {
            managerShop.findItem(itemNo).Quantity += amount;
            string sql2 = string.Format("update item set quantity = {0} where itemno = {1} and shopno = {2}", managerShop.findItem(itemNo).Quantity, managerShop.findItem(itemNo).ItemNo, managerShop.ShopNo);
            DBConnection.ExecuteNonQuery(sql2);
            DBConnection.UpdateLabel1(panel1, managerShop.GetItemList());
        }

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
                    if (managerShop.findItem(1) is LoanType loan1)
                    {
                        loan1.IsBorrowing();
                    }
                    managerShop.findItem(1).AddSellingQuantity();
                    DBConnection.UpdateLabel1(panel1, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                if (myShop.findItem(1) is LoanType loan1)
                {
                    loan1.IsBorrowing();
                }
                myShop.findItem(1).AddSellingQuantity();
                DBConnection.UpdateLabel1(panel1, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
                    if (managerShop.findItem(2) is LoanType loan1)
                    {
                        loan1.IsBorrowing();
                    }
                    managerShop.findItem(2).AddSellingQuantity();
                    DBConnection.UpdateLabel1(panel1, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                if (myShop.findItem(2) is LoanType loan1)
                {
                    loan1.IsBorrowing();
                }
                myShop.findItem(2).AddSellingQuantity();
                DBConnection.UpdateLabel1(panel1, myShop.GetItemList());
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
                    if (managerShop.findItem(3) is LoanType loan1)
                    {
                        loan1.IsBorrowing();
                    }
                    managerShop.findItem(3).AddSellingQuantity();
                    DBConnection.UpdateLabel1(panel1, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                if (myShop.findItem(3) is LoanType loan1)
                {
                    loan1.IsBorrowing();
                }
                myShop.findItem(3).AddSellingQuantity();
                DBConnection.UpdateLabel1(panel1, myShop.GetItemList());
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
                    if (managerShop.findItem(4) is LoanType loan1)
                    {
                        loan1.IsBorrowing();
                    }
                    managerShop.findItem(4).AddSellingQuantity();
                    DBConnection.UpdateLabel1(panel1, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                if (myShop.findItem(4) is LoanType loan1)
                {
                    loan1.IsBorrowing();
                }
                myShop.findItem(4).AddSellingQuantity();
                DBConnection.UpdateLabel1(panel1, myShop.GetItemList());
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
                    if (managerShop.findItem(5) is LoanType loan1)
                    {
                        loan1.IsBorrowing();
                    }
                    managerShop.findItem(5).AddSellingQuantity();
                    DBConnection.UpdateLabel1(panel1, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                if (myShop.findItem(5) is LoanType loan1)
                {
                    loan1.IsBorrowing();
                }
                myShop.findItem(5).AddSellingQuantity();
                DBConnection.UpdateLabel1(panel1, myShop.GetItemList());
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
                    if (managerShop.findItem(6) is LoanType loan1)
                    {
                        loan1.IsBorrowing();
                    }
                    managerShop.findItem(6).AddSellingQuantity();
                    DBConnection.UpdateLabel1(panel1, managerShop.GetItemList());
                    this.ShowToListBox();
                }
            }
            else
            {
                if (myShop.findItem(6) is LoanType loan1)
                {
                    loan1.IsBorrowing();
                }
                myShop.findItem(6).AddSellingQuantity();
                DBConnection.UpdateLabel1(panel1, myShop.GetItemList());
                this.ShowToListBox();
            }
            tbAddQuantity.Text = "";
        }

        private void cbAllShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int shopNo = Convert.ToInt32(cbAllShop.SelectedItem);
            managerShop = this.FindShop(shopNo);
            DBConnection.UpdateLabel1(panel1, managerShop.GetItemList());
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
		private void btnScanRfid_Click(object sender, EventArgs e)
        {
			textBox2.Clear();
			RFIDNoGlobal = "";
			StartUp();
			textBox2.Text = RFIDNoGlobal;
			//Get RFID
			if (textBox2.Text != "")
			{
				//max orderno
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
				//user balance
				string findBuyerAccount = string.Format("select accountno, balance from eventaccount where accountno = (select accountno from participant where rfidno = '{0}')", RFIDNo);
				string[,] buyerInfo = DBConnection.ExecuteQuery1(1, findBuyerAccount, 2);
				decimal updateBalance = Convert.ToDecimal(buyerInfo[0, 1]) - total;
				string updateBuyerBalance = string.Format("update eventaccount set balance = {0} where accountno = {1}", updateBalance, Convert.ToInt32(buyerInfo[0, 0]));
				DBConnection.ExecuteNonQuery(updateBuyerBalance);
				//
				if (myStaff.Role != "manager")
				{
					foreach (Item search in myShop.GetItemList())
					{
						if (search.SellingQuantity != 0)
						{
							if (search is LoanType loan1)
							{
								string sql1 = string.Format("insert into order_line_item(orderno, quantity, price, borrowingstatus, shopno, itemno) values({0}, {1}, {2}, '{3}', {4}, {5})", orderNo, search.SellingQuantity, search.SellingQuantity * search.Price, loan1.LoaningStatus, myShop.ShopNo, search.ItemNo);
								string sql2 = string.Format("update item set quantity = {0} where itemno = {1} and shopno = {2}", search.Quantity, search.ItemNo, myShop.ShopNo);
								DBConnection.ExecuteNonQuery(sql1);
								DBConnection.ExecuteNonQuery(sql2);
								search.FinishSelling();
							}
						}
					}
				}
				else
				{
					foreach (Item search in managerShop.GetItemList())
					{
						if (search.SellingQuantity != 0)
						{
							if (search is LoanType loan1)
							{
								string sql1 = string.Format("insert into order_line_item(orderno, quantity, price, borrowingstatus, shopno, itemno) values({0}, {1}, {2}, '{3}', {4}, {5})", orderNo, search.SellingQuantity, search.SellingQuantity * search.Price, loan1.LoaningStatus, managerShop.ShopNo, search.ItemNo);
								string sql2 = string.Format("update item set quantity = {0} where itemno = {1} and shopno = {2}", search.Quantity, search.ItemNo, managerShop.ShopNo);
								DBConnection.ExecuteNonQuery(sql1);
								DBConnection.ExecuteNonQuery(sql2);
								search.FinishSelling();
								MessageBox.Show(search.Quantity.ToString());
							}
						}
					}
				}
				MessageBox.Show("Done!");
				lbOrder.Items.Clear();
				textBox2.Clear();
			}
			else
			{
				MessageBox.Show("Scan RFID First");
			}
           
        }

        private void lbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOrder.SelectedItem != null)
            {
                LoanType selectedItem = (LoanType)lbOrder.SelectedItem;
                if (myStaff.Role != "manager")
                {
                    if (myShop.findItem(selectedItem.ItemNo) is LoanType loan1)
                    {
                        loan1.ReturnLoaningItem();
                    }
                    myShop.findItem(selectedItem.ItemNo).RemoveSellingQuantity();
                    DBConnection.UpdateLabel1(panel1, myShop.GetItemList());
                }
                else
                {
                    if (managerShop.findItem(selectedItem.ItemNo) is LoanType loan1)
                    {
                        loan1.ReturnLoaningItem();
                    }
                    managerShop.findItem(selectedItem.ItemNo).RemoveSellingQuantity();
                    DBConnection.UpdateLabel1(panel1, managerShop.GetItemList());
                }
                this.ShowToListBox();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string asterisk = string.Format("***************************************");
            string total = "                                      Total: " + this.GetTotalPrice();
            string fileName = "Invoice//LoaningReceipt.txt";
            string getLatestOrderNo = "select max(orderno) from ordernumber";
            string[,] result1 = DBConnection.ExecuteQuery1(1, getLatestOrderNo, 1);
            invoiceOrderNo = Convert.ToInt32(result1[0, 0]) + 1;
            WriteInvoice(fileName);
            lbOrder.Items.Add(asterisk);
            lbOrder.Items.Add(total);
        }

        private void btnFindByRfid_Click(object sender, EventArgs e)
        {
		
			StartUp();
			//textBox2.Text = RFIDNoGlobal;
			
			
				lbFindBorrowingDevice.Items.Clear();
				tempList = new List<Item>();
				string rfidNo = RFIDNoGlobal;
				string countLine = string.Format("select count(*) from order_line_item where orderno in (select orderno from ordernumber where rfidno = '{0}') and borrowingstatus = 'B'", rfidNo);
				string findLine = string.Format("select shopno, itemno, quantity, orderno from order_line_item where orderno in (select orderno from ordernumber where rfidno = '{0}') and borrowingstatus = 'B' group by shopno, itemno", rfidNo);
				string[,] result1 = DBConnection.ExecuteQuery(countLine, findLine, 4);
				if (result1 != null)
				{
					for (int i = 0; i < result1.GetLength(0); i++)
					{
						string findItem = string.Format("select * from item where itemno = {0} and shopno = {1}", Convert.ToInt32(result1[i, 1]), Convert.ToInt32(result1[i, 0]));
						string[,] result2 = DBConnection.ExecuteQuery1(1, findItem, 6);
						tempList.Add(new LoanType(Convert.ToInt32(result2[0, 1]), result2[0, 3], Convert.ToInt32(result1[i, 2]), Convert.ToDecimal(result2[0, 2]), Convert.ToInt32(result2[0, 0]), result2[0, 5], Convert.ToInt32(result1[i, 3])));
					}
					foreach (Item search in tempList)
					{
						if (search is LoanType loan1)
						{
							while (search.Quantity > 0)
							{
								search.AddSellingQuantity();
							}
							lbFindBorrowingDevice.Items.Add(search);
						}
					}
					currentRFIDNo = rfidNo;
				}
				else
				{
					MessageBox.Show("All items have been returned");
				}

			
			

		}

        private void lbFindBorrowingDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFindBorrowingDevice.SelectedItem != null)
            {
                LoanType temp = (LoanType)lbFindBorrowingDevice.SelectedItem;
                foreach (Item search in tempList)
                {
                    if (temp.ShopNo == search.ShopNo || temp.ItemNo == search.ItemNo)
                    {
                        if (search is LoanType loan1)
                        {
                            //using method in loantype to return, not optimize but will do for now, using templist as above avoid intefere with managershop list as well as my shop
                            string findCurrentQuantity = string.Format("select quantity from item where itemno = {0} and shopno = {1}", search.ItemNo, search.ShopNo);
                            string[,] resul1 = DBConnection.ExecuteQuery1(1, findCurrentQuantity, 1);
                            int updateQuantity = Convert.ToInt32(resul1[0, 0]) + 1;
                            if (myStaff.Role != "manager")
                            {
                                myShop.findItem(search.ItemNo).AddQuantity(1);
                                DBConnection.UpdateLabel1(panel1, myShop.GetItemList());
                            }
                            else
                            {
                                managerShop.findItem(search.ItemNo).AddQuantity(1);
                                DBConnection.UpdateLabel1(panel1, myShop.GetItemList());
                            }
                            string updateQuantitySQL = string.Format("update item set quantity = {0} where shopno = {1} and itemno = {2}", updateQuantity, search.ShopNo, search.ItemNo);
                            DBConnection.ExecuteNonQuery(updateQuantitySQL);
                            search.RemoveSellingQuantity();
                            //A: returned
                            if (search.SellingQuantity == 0)
                            {
                                string sqlUpdateStatus = string.Format("update order_line_item set borrowingstatus = 'A' where orderno in (select orderno from ordernumber where rfidno = '{0}')", currentRFIDNo);
                                DBConnection.ExecuteNonQuery(sqlUpdateStatus);
                            }
                        }
                    }
                }
                lbFindBorrowingDevice.Items.Clear();
                foreach (Item search in tempList)
                {
                    if (search.SellingQuantity != 0)
                    {
                        lbFindBorrowingDevice.Items.Add(search);
                    }
                }
                if (myStaff.Role == "manager")
                {
                    DBConnection.UpdateLabel1(panel1, managerShop.GetItemList());
                }
                else
                {
                    DBConnection.UpdateLabel1(panel1, myShop.GetItemList());
                }
            }
        }

        private void btnFindAllBorrowingDevice_Click(object sender, EventArgs e)
        {
            string countAll = "select count(*) from ordernumber where orderno in (select orderno from order_line_item where borrowingstatus = 'B')";
            string findAllRfidNo = "select rfidno from ordernumber where orderno in (select orderno from order_line_item where borrowingstatus = 'B')";
            string[,] result1 = DBConnection.ExecuteQuery(countAll, findAllRfidNo, 1);
            if (result1 != null)
            {
                foreach (string find in result1)
                {
                    lbFindBorrowingDevice.Items.Add(find);
                }
            }
            else
            {
                MessageBox.Show("Everyone return their loaning items");
            }
        }

        //Chart
        private void BorrowDeviceChart()
        {
            foreach (Series s in cBorrowDevice.Series)
            {
                s.Points.Clear();
            }
            cBorrowDevice.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            cBorrowDevice.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            for (int i = 1; i < 7; i++)
            {
                if (myStaff != null)
                {
                    if (myStaff.Role == "manager")
                    {
                        if (managerShop != null)
                        {
                            string sqlSum = string.Format("select sum(quantity) from order_line_item where itemno = {0} and shopno = {1}", i, managerShop.ShopNo);
                            decimal total = DBConnection.ExecuteScalar(sqlSum);
                            string sqlGetName = string.Format("select itemname from item where itemno = {0} and shopno = {1}", i, managerShop.ShopNo);
                            string[,] itemName = DBConnection.ExecuteQuery1(1, sqlGetName, 1);
                            if (total == -1)
                            {
                                total = 0;
                            }
                            if (i < 7)
                            {
                                cBorrowDevice.Series["BorrowDevice"].Points.AddXY(itemName[0, 0], total);
                            }
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myStaff != null)
            {
                this.BorrowDeviceChart();
            }

        }
    }
}
