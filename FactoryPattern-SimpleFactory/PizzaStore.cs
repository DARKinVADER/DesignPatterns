using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern_SimpleFactory
{
    public class PizzaStore
    {
        private readonly SimplePizzaFactory simplePizzaFactory;

        public PizzaStore(SimplePizzaFactory simplePizzaFactory)
        {
            this.simplePizzaFactory = simplePizzaFactory ?? throw new ArgumentNullException(nameof(simplePizzaFactory));
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = simplePizzaFactory.CreatePizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
