using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    abstract class Item
    {
        private int itemNo;
        private string itemName;
        private int quantity;
        private decimal price;
        private int shopNo;
        public string ItemName { get { return itemName} }
        public int ItemNo { get { return itemNo; } }
        public int ShopNo { get { return shopNo; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public Item(int itemNo, string itemName, int quantity, decimal price, int shopNo)
        {
            this.itemNo = itemNo;
            this.itemName = itemName;
            this.quantity = quantity;
            this.price = price;
            this.shopNo = shopNo;
        }

        public virtual string Description()
        {
            return "Item number: " + this.itemNo + " Item name: " + this.itemName + " quantity: " + this.quantity + " price: " + this.price;
        }
    }
}
