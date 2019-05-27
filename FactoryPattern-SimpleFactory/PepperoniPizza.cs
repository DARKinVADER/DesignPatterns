using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern_SimpleFactory
{
    class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Type = "pepperoni";
        }
    }
}
