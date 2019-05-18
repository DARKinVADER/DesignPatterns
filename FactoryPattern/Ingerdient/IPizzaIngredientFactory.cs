using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingerdient
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        List<Veggies> CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClam();
    }
}
