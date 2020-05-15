using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    class FoodType: Item
    {
        private string type;
        public string Type { get { return this.type; } }
        public FoodType(int itemNo, string itemName, int quantity, decimal price, int shopNo, string type): base(itemNo, itemName, quantity, price, shopNo)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
