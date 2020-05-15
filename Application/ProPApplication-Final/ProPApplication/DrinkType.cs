using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    class DrinkType: Item
    {
        private string type;
        public DrinkType(int itemNo, string itemName, int quantity, decimal price, string type) : base(itemNo, itemName, quantity, price)
        {
            this.type = type;
        }
        public string GetDrinkType()
        {
            return type;
        }

        public override string Description()
        {
            return base.Description() + " Type: " + this.type;
        }
    }
}
