using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    internal class InventoryItem
    {

        public string categories;
        public string name;
        public double price;
        public int quantity;




        public void Constructor1(string categories, string name, double price, int quantity)
        {
            this.categories = categories;
            this.name = name;
            this.price = price;
            this.quantity = quantity;

        }

    }

   
}
