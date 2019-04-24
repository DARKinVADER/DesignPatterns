using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Decorators
{
    public class Mocha : CondimentDecorator
    {
        readonly Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.2;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}
