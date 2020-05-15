using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    class Tent
    {
        private int campingSpotNo;
        private decimal price;
        private List<int> accountNo;
        private string paidInAdvance;
        public string PaidInAdvance { get { return this.paidInAdvance; } }
        public Tent(int campingSpotNo, decimal price, string paidInAdvance, List<int> accountNo)
        {
            this.campingSpotNo = campingSpotNo;
            this.price = price;
            this.accountNo = accountNo;
            this.paidInAdvance = paidInAdvance;
        }

        public string ShowInfo()
        {
            string show = "Camping spot number: " + this.campingSpotNo + " price: " + this.price + " paid in advance: " + this.paidInAdvance;
            string findHost = "select accountno from reservation where campingspotno = " + this.campingSpotNo;
            string findOther = "select accountno from eventaccount where campingspotno = " + this.campingSpotNo;
            string[,] result = DBConnection.ExecuteQuery1(1, findHost, 1);
            string findInfo = string.Format("select concat(firstname, ' ', lastname) from visitor where visitorno in (select visitorno from eventaccount where accountno = {0})", Convert.ToInt32(result[0,0]));
            string[,] result2 = DBConnection.ExecuteQuery1(1, findInfo, 1);
            show += " host account number: " + result[0,0] + " name: " + result2[0, 0];
            foreach (int search in this.accountNo)
            {
                if (search != Convert.ToInt32(result[0,0]))
                {
                    string findInfoOther = string.Format("select concat(firstname, ' ', lastname) from visitor where visitorno in (select visitorno from eventaccount where accountno = {0})", search);
                    string[,] result4 = DBConnection.ExecuteQuery1(1, findInfoOther, 1);
                    show += " invited person account number: " + search + " name: " + result4[0, 0];
                }
            }
            return show;
        }
    }
}
