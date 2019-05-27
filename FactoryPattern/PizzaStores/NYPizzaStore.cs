using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Ingerdient;
using FactoryPattern.Pizza;

namespace FactoryPattern.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override PizzaBase CreatePizza(string type)
        {
            PizzaBase pizza = null;
            NYPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory)
                    {
                        Name = "NY Style Cheese Pizza"
                    };
                    break;

                case "clam":
                    pizza = new ClamPizza(ingredientFactory)
                    {
                        Name = "NY Style Clam Pizza"
                    };
                    break;

                default:
                    return null;
            }

            return pizza;
        }
    }
}
