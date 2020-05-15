using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    public abstract class Item
    {
        private int itemNo;
        private string itemName;
        private int quantity;
        private decimal price;
        private int shopNo;
        private int sellingQuantity;
        public int SellingQuantity { get { return this.sellingQuantity; } }
        public string ItemName { get { return this.itemName; } }
        public int ItemNo { get { return this.itemNo; } }
        public int ShopNo { get { return this.shopNo; } }
        public int Quantity { get { return this.quantity; } set { this.quantity = value; } }
        public decimal Price { get { return this.price; } }
        public Item(int itemNo, string itemName, int quantity, decimal price, int shopNo)
        {
            this.itemNo = itemNo;
            this.itemName = itemName;
            this.quantity = quantity;
            this.price = price;
            this.shopNo = shopNo;
            this.sellingQuantity = 0;
        }

        public void AddSellingQuantity()
        {
            this.sellingQuantity += 1;
            this.quantity -= 1;
        }

        public void RemoveSellingQuantity()
        {
            if(this.sellingQuantity - 1 >= 0)
            {
                this.sellingQuantity -= 1;
                this.quantity += 1;
            }
        }

        public void FinishSelling()
        {
            this.sellingQuantity = 0;
        }
        // optimize this by connecting to the db
        public void AddQuantity(int amount)
        {
            this.quantity += amount;
        }

        public override string ToString()
        {
            return this.itemNo + "                        " + this.itemName + "          " + this.sellingQuantity + "           " + this.sellingQuantity * this.price;
        }
    }
}
