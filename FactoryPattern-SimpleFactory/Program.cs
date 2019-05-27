using System;

namespace FactoryPattern_SimpleFactory
{
    public static class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new PizzaStore(new SimplePizzaFactory());

            Pizza pizza = pizzaStore.OrderPizza("cheese");

            Console.WriteLine(pizza.toString());
            pizza = pizzaStore.OrderPizza("clam");
            Console.WriteLine(pizza.toString());
        }
    }
}
