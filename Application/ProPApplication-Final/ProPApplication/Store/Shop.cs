using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    public class Shop: IStorageAndShop
    {
        private int shopNo;
        private string name;
        private string shopType;
        private decimal profit;
        private List<Item> itemToSell;
        public List<Item> ItemToSell { get { return this.itemToSell; } set { this.itemToSell = value; } }
        public int ShopNo { get { return this.shopNo; } }
        public string ShopType { get { return this.shopType; } }
        public decimal Profit { get { return this.profit; } }
        public Shop(string name, int shopNo, string shopType)
        {
            this.name = name;
            this.shopNo = shopNo;
            this.shopType = shopType;
            itemToSell = new List<Item>();
        }

        //Item List this is for all the item 
        public void AddItem(Item addItem)
        {
            if(addItem.ShopNo == this.shopNo)
            {
                itemToSell.Add(addItem);
            }
        }

        public Item findItem(int itemNo)
        {
            foreach(Item search in itemToSell)
            {
                if(search.ItemNo == itemNo)
                {
                    return search;
                }
            }
            return null; 
        }

        public int CheckItemQuantity(int itemNo)
        {
            int quantity = -1;
            foreach (Item search in itemToSell)
            {
                if (search.ItemNo == itemNo)
                {
                    quantity = search.ItemNo;
                    return quantity;
                }
            }
            return quantity;
        }

        public List<Item> CheckAllItem(int shopNo)
        {
            List<Item> temp = new List<Item>();
            foreach (Item search in itemToSell)
            {
                if (search.ShopNo == shopNo)
                {
                    temp.Add(search);
                }
            }
            return temp;
        }

        //public void ItemSold(int itemNo)
        //{
        //    foreach(Item search in itemToSell)
        //    {
        //        if(search.ShopNo == this.shopNo && search.ItemNo == itemNo)
        //        {
        //            search.Quantity -= findItem(itemNo).SellingQuantity;
        //        }
        //    }
        //}

        public List<Item> GetItemList()
        {
            return this.itemToSell;
        }

        public List<Item> GetFoodList(string type)
        {
            List<Item> temp = new List<Item>();
            foreach(Item search in this.itemToSell)
            {
                if(search is FoodType food)
                {
                    if(food.Type == type)
                    {
                        temp.Add(search);
                    }
                }
            }
            return temp;
        }

        public List<Item> GetDrinkList(string type)
        {
            List<Item> temp = new List<Item>();
            foreach (Item search in this.itemToSell)
            {
                if (search is DrinkType drink)
                {
                    if (drink.Type == type)
                    {
                        temp.Add(search);
                    }
                }
            }
            return temp;
        }

        public decimal GetProfit(int shopNo)
        {
            string scalar = string.Format("select sum(total) from ordernumber where employeeno in (select employeeno from employee where shopno = {0})", shopNo);
            this.profit = DBConnection.ExecuteScalar(scalar);
            if(this.profit != -1)
            {
                return this.profit;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Shop number: " + this.shopNo + ", Shop name: " + this.name + ", Shop type: " + this.shopType + ", Total money made: " + this.GetProfit(this.shopNo);
        }
    }
}
