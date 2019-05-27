using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Ingerdient;
using FactoryPattern.Pizza;

namespace FactoryPattern.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override PizzaBase CreatePizza(string type)
        {
            PizzaBase pizza = null;
            ChicagoPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory)
                    {
                        Name = "Chicago Style Cheese Pizza"
                    };
                    break;

                case "clam":
                    pizza = new ClamPizza(ingredientFactory)
                    {
                        Name = "Chicago Style Clam Pizza"
                    };
                    break;

                default:
                    return null;
            }

            return pizza;
        }
    }
}
