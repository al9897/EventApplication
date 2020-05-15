using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    public class Visitor: Participant
    {
        private int accountNo;
        private decimal balance;
        private int tentNo;
        private bool paidInAdvance;
        private bool checkIn;
        private bool loanStatus;
        public bool CheckIn { get { return checkIn; } }
        public int TentNo { get { return tentNo; } }
        public Visitor(string name, string dob, string RFIDNo, int accountNo, decimal balance, int tentNo,bool paidInAdvance, bool checkIn, bool loanStatus): base(name, dob, RFIDNo)
        {
            this.accountNo = accountNo;
            this.balance = balance;
            this.tentNo = tentNo;
            this.paidInAdvance = paidInAdvance;
            this.checkIn = checkIn;
            this.loanStatus = loanStatus;
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        public void BuyItems(decimal amount)
        {
            this.balance -= amount;
        }

        public bool LoanMaterial()
        {
            return false;
        }

        public void InvitePeopleToTent(int RFIDNo, int tentNo)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " Account Number: " + this.accountNo + " Balance: " + this.balance + " paid in advance: " + this.paidInAdvance + " check in: " + this.checkIn + " loan status: " + this.loanStatus;
        }
    }
}
