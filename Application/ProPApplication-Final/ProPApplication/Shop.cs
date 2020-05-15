using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    class Shop: IStorageAndShop
    {
        private int shopNo;
        private string name;
        private decimal total;
        private List<Item> itemToSell;
        public Shop(string name, int shopNo)
        {
            this.name = name;
            this.shopNo = shopNo;
            itemToSell = new List<Item>();
        }

        public void AddItem(Item addItem)
        {
            if(addItem.ShopNo == this.shopNo)
            {
                itemToSell.Add(addItem);
            }
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

        public void ItemSold(int itemNo)
        {
            foreach(Item search in itemToSell)
            {
                if(search.ShopNo == this.shopNo && search.ItemNo == itemNo)
                {
                    search.Quantity -= 1;
                }
            }
        }
    }
}
