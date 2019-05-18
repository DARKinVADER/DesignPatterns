using FactoryPattern.Ingerdient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicagp Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");

            PizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
        }

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}