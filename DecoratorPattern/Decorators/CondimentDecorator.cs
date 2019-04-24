using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDescription();
    }
}
