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
            double condimentCost = 0;

            switch (beverage.Size)
            {
                case SizeType.tall:
                    condimentCost = 0.1;
                    break;
                case SizeType.grande:
                    condimentCost = 0.15;
                    break;
                case SizeType.venti:
                    condimentCost = 0.20;
                    break;
                default:
                    throw new IndexOutOfRangeException($"Unknown Beverage size {beverage.Size}");
            }

            return beverage.Cost() + condimentCost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}
