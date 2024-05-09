using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    internal class Inventory
    {
        public string product;

        public Dictionary<string, List<string>> Categories = new Dictionary<string, List<string>>();

        public void AddItem(string product, string category)
        {
            if (!Categories.ContainsKey(category))
            {
                Categories[category] = new List<string>();
            }
            Categories[category].Add(product);
        }


        public void RemoveItem(int index, string category)
        {
            if (Categories.ContainsKey(category))
            {
                if (index >= 0 && index < Categories[category].Count)
                {
                    Categories[category].RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Index is out of range for the selected category.");
                }
            }
            else
            {
                MessageBox.Show("Category does not exist.");
            }
        }




    }


}
