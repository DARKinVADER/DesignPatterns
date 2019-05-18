using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingerdient
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new MozarellaCheese();
        }

        public Clams CreateClam()
        {
            return new FrozenClam();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSource();
        }

        public List<Veggies> CreateVeggies()
        {
            return new List<Veggies>()
            {
                new BlackOlives(),
                new Spinach(),
                new EggPlant()
            };
        }
    }
}
