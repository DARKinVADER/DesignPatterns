using System;

namespace FactoryPattern_SimpleFactory
{
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            Type = "clam";
        }
    }
}
