using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.description = "Dark Roast Coffee";
        }
        public override double Cost()
        {
            return 0.99;
        }
    }
}
