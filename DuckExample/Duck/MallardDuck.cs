using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckExample
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.flyBehavior = new FlyWithWings();
            this.quackBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a real mallard duck!");
        }
    }
}
