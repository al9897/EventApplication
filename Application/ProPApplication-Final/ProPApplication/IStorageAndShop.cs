using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    interface IStorageAndShop
    {
        void AddItem(Item addItem);
        int CheckItemQuantity(int itemNo);
        List<Item> CheckAllItem(int shopNo);
    }
}
