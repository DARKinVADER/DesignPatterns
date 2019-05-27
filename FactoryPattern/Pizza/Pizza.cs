using FactoryPattern.Ingerdient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizza
{
    public abstract class PizzaBase
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public List<Veggies> Veggies { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }
        public Clams Clam { get; set; }
        protected List<string> toppings = new List<string>();

        //public virtual void prepare()
        //{
        //    Console.WriteLine($"Preparing {Name}");
        //    Console.WriteLine("Tossing dough...");
        //    Console.WriteLine("Adding sauce...");
        //    Console.WriteLine("Adding toppings: ");
        //    foreach (string topping in toppings)
        //    {
        //        Console.WriteLine($" {topping}");
        //    }
        //}
        public abstract void Prepare();
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

        public string toString() { return null; }
    }
}
