using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    class Staff: Participant
    {
        private int shopNo;
        private int employeeNo;
        private string role;
        private decimal totalMoneyMade;
        public Staff(string name, string dob, int RFIDNo, int employeeNo, string role, int shopNo): base(name, dob, RFIDNo)
        {
            this.employeeNo = employeeNo;
            this.role = role;
            this.shopNo = shopNo;
        }

        public decimal CheckTotalMoneyMade(decimal total)
        {
            totalMoneyMade = total;
            return totalMoneyMade;
        }

        public bool SellItem()
        {
            return false;
        }

        public string PrintReceipt()
        {
            string receipt = "";
            return receipt;
        }

        public bool CheckParticipant()
        {
            return false;
        }

        public bool CheckLoanMaterial()
        {
            return false;
        }

        public void LoanTent(int tentNo, int accountNo)
        {

        }

        public override string Info()
        {
            return base.Info() + " EmplopyeeNo: " + this.employeeNo + " Role: " + this.role + " shop number: " + this.shopNo + " total money made: " + this.totalMoneyMade;
        }
    }
}
