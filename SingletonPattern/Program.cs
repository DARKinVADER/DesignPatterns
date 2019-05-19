using System;

namespace SingletonPattern
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine($"Hello World of Singleton, Counter is {singleton.Counter++}!");
            Console.WriteLine($"Hello World of Singleton, Counter is incremented by one : {singleton.Counter}!");

            Singleton singletonSecond = Singleton.GetInstance();
            Console.WriteLine($"Singleton - singletonSecond, Counter is {singletonSecond.Counter}!");
        }
    }
}
