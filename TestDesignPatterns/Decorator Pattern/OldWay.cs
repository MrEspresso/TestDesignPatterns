using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns
{
    // There are many types of drinks and new ones will be added later.
    // There are several condiments (soy, milk, whip...) with vairous prices. New condiments will be added and prices will change.
    // Need to calculate total price of a drink
    // Some drinks should not be allowed to add condiments



    public class Drink
    {
        private string DrinkType; // coffee, tea, soda... stored in a database table. New entries can be added.
        private string Description; // House Blend, Decaf... stored in a database table. New entries can be added.
        private List<string> Addons; // Whip, Soy, Sugar... stored in a database table. New entries can be added.

        public decimal Cost()
        {
            return 2;
        }
    }
}