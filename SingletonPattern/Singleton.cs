using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton uniqueInstance;
        public int Counter { get; set; }

        private Singleton()
        {
            Counter = 1;
        }

        public static Singleton GetInstance()
        {
            if(uniqueInstance== null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
    }
}
