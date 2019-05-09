using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public SizeType Size { get; set; }

        public enum SizeType { tall, grande, venti };

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();      

    }
}
