using FactoryPattern.Ingerdient;
using System;

namespace FactoryPattern.Pizza
{
    public class CheesePizza : PizzaBase
    {
        private readonly IPizzaIngredientFactory pizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        //public override void cut()
        //{
        //    Console.WriteLine("Cutting the pizza into square slices");
        //}

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = pizzaIngredientFactory.CreateDough();
            Sauce = pizzaIngredientFactory.CreateSauce();
            Cheese = pizzaIngredientFactory.CreateCheese();
        }
    }
}