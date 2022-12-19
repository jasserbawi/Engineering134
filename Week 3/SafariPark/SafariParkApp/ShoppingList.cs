using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class ShoppingList
    {
        // fields
        private string _basket = "";

        public string Basket //Initialisation
        {
            get
            {
                return _basket;
            }
            init
            {
                _basket = value;
            }
        }

        public string ListOfItems()
        {
            return _basket;
        }

        public ShoppingList()
        {
        }

    }
}
