using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProPApplication
{
    class LoanType: Item
    {
        private string type;
        private string loaningStatus;
        private int orderNo;
        public string Type { get { return this.type; } }
        public string LoaningStatus { get { return this.loaningStatus; } }
        public int OrderNo { get { return this.orderNo; } }
        public LoanType(int itemNo, string itemName, int quantity, decimal price, int shopNo, string type) : base(itemNo, itemName, quantity, price, shopNo)
        {
            this.type = type;
        }

        public LoanType(int itemNo, string itemName, int quantity, decimal price, int shopNo, string type, int orderNo) : base(itemNo, itemName, quantity, price, shopNo)
        {
            this.type = type;
            this.orderNo = orderNo;
        }

        public override string ToString()
        {
            return base.ToString() + " order number: " + this.orderNo;
        }

        public void IsBorrowing()
        {
            this.loaningStatus = "B";
        }

        public void ReturnLoaningItem()
        {
            this.loaningStatus = "A";
        }
    }
}
