using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProPApplication
{
    class Spot
    {
        public int ID { get; set; }
        public bool IsAvailable { get; set; }
        public Decimal Price { get; set; }
        public Visitor Renter;
        public Spot(int id, bool isAvailable, decimal price,Visitor p)
        {
            ID = id;
            IsAvailable = isAvailable;
            Price = price;
            Renter = p;
        }
        public bool AddARenter(Visitor p)
        {
            if (IsAvailable)
            {
                Renter = p;
                IsAvailable = false;
                return true;
            }
            return false;
        }
    }
}
