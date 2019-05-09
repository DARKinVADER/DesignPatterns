using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Decorators
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.1;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
    }
}
