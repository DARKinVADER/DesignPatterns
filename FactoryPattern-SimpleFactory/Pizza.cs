using System;

namespace FactoryPattern_SimpleFactory
{
    public abstract class Pizza
    {
        public string Type { get; set; }

        public virtual void prepare()
        {
            Console.WriteLine($"Prepare {Type} pizza");
        }
        public virtual void bake()
        {
            Console.WriteLine($"Bake for 25 minutes at 350");
        }
        public virtual void cut()
        {
            Console.WriteLine($"Cutting the pizza into diagonal slices");
        }
        public virtual void box()
        {
            Console.WriteLine($"Place pizza in offical PizzaStore box");
        }

        public string toString()
        {

            return $"Delicious {Type} pizza!";
        }
    }
}
