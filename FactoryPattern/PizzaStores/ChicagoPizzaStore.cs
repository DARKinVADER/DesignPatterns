using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                default:
                    return null;
            }
        }
    }
}
