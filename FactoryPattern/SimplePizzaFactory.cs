using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("greek"))
            {
                pizza = new GreekPizza();
            }
            else
            {
                pizza = new PepperoniPizza();
            }

            return pizza;
        }
    }
}
