using FactoryPattern.Ingerdient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizza
{
    class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory pizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine($"Preparing {Name}");

            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSauce();
            Cheese = pizzaIngredientFactory.CreateCheese();
        }
    }
}
