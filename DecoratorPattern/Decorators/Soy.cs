using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Decorators
{
    class Soy:CondimentDecorator
    {
        readonly Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.15;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}
