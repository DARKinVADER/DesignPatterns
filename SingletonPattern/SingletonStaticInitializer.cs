using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    // For performance issues
    public class SingletonStaticInitializer
    {
        private static SingletonStaticInitializer uniqueInstance = new SingletonStaticInitializer();
        private SingletonStaticInitializer()
        {
        }

        public static SingletonStaticInitializer GetInstance()
        {
            return uniqueInstance;
        }
    }
}
