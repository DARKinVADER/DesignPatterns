using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Ingerdient;
using FactoryPattern.Pizza;

namespace FactoryPattern.Pizza
{
    public class ClamPizza : PizzaBase
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory ?? throw new ArgumentNullException(nameof(pizzaIngredientFactory));
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSauce();
            Cheese = pizzaIngredientFactory.CreateCheese();
            Clam = pizzaIngredientFactory.CreateClam();
        }
    }
}
