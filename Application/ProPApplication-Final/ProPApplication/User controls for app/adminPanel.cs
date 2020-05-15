using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace ProPApplication
{
    public partial class adminPanel : UserControl
    {
        public adminPanel()
        {
            InitializeComponent();
            shopList = new List<Shop>();
            myTimer.Start();
        }

        //total tent rented

        public Staff myStaff;
        public List<Shop> shopList;
        
        private void ClearChart(Chart aChart)
        {
            foreach(Series s in aChart.Series)
            {
                s.Points.Clear();
            }
        }
        //Profit from all shop
        private void ShowProfit()
        {
            this.ClearChart(chartProfit);
            decimal foodShop = 0;
            decimal drinkShop = 0;
            decimal loanStand = 0;
            foreach(Shop search in shopList)
            {
                if(search.ShopType == "FoodShop")
                {
                    foodShop += search.GetProfit(search.ShopNo);
                }
                else if(search.ShopType == "DrinkShop")
                {
                    drinkShop += search.GetProfit(search.ShopNo);
                }
                else
                {
                    loanStand += search.GetProfit(search.ShopNo);
                }
            }
            decimal total = foodShop + drinkShop + loanStand;
            chartProfit.Series["profit"].Points.AddXY("FoodShop", foodShop);
            chartProfit.Series["profit"].Points.AddXY("DrinkShop", drinkShop);
            chartProfit.Series["profit"].Points.AddXY("LoanStand", loanStand);
            chartProfit.Series["profit"].Points.AddXY("Total", total);
        }
        //Check amount of visitor
        private void ShowVisitor()
        {
            this.ClearChart(chartVisitor);
            //visitor who has arrived to the event but check out during the event, however they still come back
            string sqlTotalVisitorComeToTheEvent = "select count(*) from participant";
            string sqlTotalVisitor = "select count(*) from eventaccount where ticketpaidmethod = 'O' or ticketpaidmethod = 'E'";
            string sqlTotalVisitorPresent = "select count(*) from participant where checkinstatus = 'T'";
            int totalVisitorComeToTheEvent = Convert.ToInt32(DBConnection.ExecuteScalar(sqlTotalVisitorComeToTheEvent));
            int totalVisitor = Convert.ToInt32(DBConnection.ExecuteScalar(sqlTotalVisitor));
            int totalVisitorPresent = Convert.ToInt32(DBConnection.ExecuteScalar(sqlTotalVisitorPresent));
            chartVisitor.Series["Visitor"].Points.AddXY("Total Visitor", totalVisitor);
            chartVisitor.Series["Visitor"].Points.AddXY("Total Visitor Come", totalVisitorComeToTheEvent);
            chartVisitor.Series["Visitor"].Points.AddXY("Total Visitor Present", totalVisitorPresent);
        }
        //Compare
        private void CompareVisitorBalance()
        {
            this.ClearChart(chartBalance);
            string sqlGetTotalBalance = "select sum(balance) from eventaccount where ticketpaidmethod = 'O' or ticketpaidmethod = 'E'";
            decimal visitorBalance = DBConnection.ExecuteScalar(sqlGetTotalBalance);
            decimal totalProfit = 0;
            foreach(Shop search in shopList)
            {
                totalProfit += search.GetProfit(search.ShopNo);
            }
            chartBalance.Series["Balance"].Points.AddXY("Visitor Balance", visitorBalance);
            chartBalance.Series["Balance"].Points.AddXY("Total money made", totalProfit);
        }

        //Show item statistic
        private void ShowItemStatistic()
        {
            this.ClearChart(chartItem);
            List<decimal> foodShopList = new List<decimal>();
            List<decimal> drinkShopList = new List<decimal>();
            List<decimal> borrowShopList = new List<decimal>();
            decimal totalFood = 0;
            decimal totalDrink = 0;
            decimal totalBorrow = 0;
            chartItem.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartItem.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            foreach (Shop search in shopList)
            {
                if (search.ShopType == "FoodShop")
                {
                    string sql = string.Format("select sum(quantity * price) from order_line_item where shopno = {0} group by shopno", search.ShopNo);
                    foodShopList.Add(DBConnection.ExecuteScalar(sql));
                }
                else if (search.ShopType == "DrinkShop")
                {
                    string sql = string.Format("select sum(quantity * price) from order_line_item where shopno = {0} group by shopno", search.ShopNo);
                    drinkShopList.Add(DBConnection.ExecuteScalar(sql));
                }
                else
                {
                    string sql = string.Format("select sum(quantity * price) from order_line_item where shopno = {0} group by shopno", search.ShopNo);
                    borrowShopList.Add(DBConnection.ExecuteScalar(sql));
                }
            }
            totalFood = foodShopList.Sum();
            totalDrink = drinkShopList.Sum();
            totalBorrow = borrowShopList.Sum();
            chartItem.Series["All"].Points.AddXY(string.Format("Food"), totalFood);
            chartItem.Series["All"].Points.AddXY(string.Format("Drink"), totalDrink);
            chartItem.Series["All"].Points.AddXY(string.Format("BorrowDevice"), totalBorrow);
            chartItem.Series["MostProfit"].Points.AddXY(string.Format("HighestShop"), foodShopList.Max());
            chartItem.Series["MostProfit"].Points.AddXY(string.Format("HighestShop"), drinkShopList.Max());
            chartItem.Series["MostProfit"].Points.AddXY(string.Format("HighestShop"), borrowShopList.Max());
        }

        private void ShowTent()
        {
            this.ClearChart(cTent);
            cTent.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            cTent.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            string sqlAllTent = "select count(*) from campingspot";
            int allTent = Convert.ToInt32(DBConnection.ExecuteScalar(sqlAllTent));
            string sqlTentTaken = "select count(*) from reservation";
            int tentTaken = Convert.ToInt32(DBConnection.ExecuteScalar(sqlTentTaken));
            cTent.Series["Tent"].Points.AddXY(string.Format("All tent"), allTent);
            cTent.Series["Tent"].Points.AddXY(string.Format("Tent Taken"), tentTaken);
        }

        private void ProgressBar()
        {
            string sqlTotalVisitor = "select count(*) from eventaccount where ticketpaidmethod = 'O' or ticketpaidmethod = 'E'";
            string sqlTotalVisitorPresent = "select count(*) from participant where checkinstatus = 'T'";
            decimal totalVisitor = DBConnection.ExecuteScalar(sqlTotalVisitor);
            decimal totalVisitorPresent = DBConnection.ExecuteScalar(sqlTotalVisitorPresent);
            decimal percentage = totalVisitorPresent / totalVisitor * 100;
            lbPercentage.Text = string.Format("{0:00}% (prensent visitors / total visitors)", percentage);
            pbVisitor.Minimum = 0;
            pbVisitor.Maximum = Convert.ToInt32(totalVisitor);
            pbVisitor.Value = Convert.ToInt32(totalVisitorPresent);
        }


        private void myTimer_Tick(object sender, EventArgs e)
        {

			if (myStaff != null)
			{
				this.ShowProfit();
				this.ShowVisitor();
				this.CompareVisitorBalance();
				this.ShowItemStatistic();
				this.ShowTent();
				this.ProgressBar();
			}

		}

		private void btnFile_Click(object sender, EventArgs e)
        {
			tbShowResult.Text = "";
			string fileName = "LogFile\\LogFile.txt";
            
            tbShowResult.Text = myStaff.ReadLogFile(fileName);
        }

	
	}
}
