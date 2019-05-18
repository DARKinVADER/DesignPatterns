using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.PizzaStores
{
    public abstract class PizzaStore
    {
        //private readonly SimplePizzaFactory simplePizzaFactory;

        //public PizzaStore(SimplePizzaFactory simplePizzaFactory)
        //{
        //    this.simplePizzaFactory = simplePizzaFactory;
        //}

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;

        }

        protected abstract Pizza CreatePizza(string type);
    }
}
