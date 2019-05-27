using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Pizza;

namespace FactoryPattern.PizzaStores
{
    public abstract class PizzaStore
    {
        //private readonly SimplePizzaFactory simplePizzaFactory;

        //public PizzaStore(SimplePizzaFactory simplePizzaFactory)
        //{
        //    this.simplePizzaFactory = simplePizzaFactory;
        //}

        public PizzaBase OrderPizza(string type)
        {
            PizzaBase pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;

        }

        protected abstract PizzaBase CreatePizza(string type);
    }
}
