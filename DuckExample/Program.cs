using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckExample
{
    static class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();

            mallard.performQuack();
            mallard.performFly();

            Console.ReadKey();
        }
    }
}
