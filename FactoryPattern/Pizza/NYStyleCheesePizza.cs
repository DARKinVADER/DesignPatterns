using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Souce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
