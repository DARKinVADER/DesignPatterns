using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingerdient
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clams CreateClam()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<Veggies> CreateVeggies()
        {
            List<Veggies> veggies = new List<Veggies>() {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };

            return veggies;
        }
    }
}
