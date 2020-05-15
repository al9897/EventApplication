using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    class Storage: IStorageAndShop
    {
        private List<Item> storageItem;
        public Storage()
        {
            storageItem = new List<Item>();
        }

        public void AddItem(Item addItem)
        {
            storageItem.Add(addItem);
        }

        //public void addQuantity(int shopNo, string name, int amount)
        //{
        //    foreach(Item search in storageItem)
        //    {
        //        if(search.ShopNo == shopNo && search.ItemName == name)
        //        {
        //            search.Quantity += amount;
        //        }
        //    }
        //}

        public int CheckItemQuantity(int itemNo)
        {
            int quantity = -1;
            foreach(Item search in storageItem)
            {
                if(search.ItemNo == itemNo)
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
            foreach(Item search in storageItem)
            {
                if(search.ShopNo == shopNo)
                {
                    temp.Add(search);
                }
            }
            return temp;
        }
    }
}
