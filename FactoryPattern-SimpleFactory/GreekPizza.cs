using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern_SimpleFactory
{
    public class GreekPizza : Pizza
    {
        public GreekPizza()
        {
            Type = "greek";
        }
    }
}
