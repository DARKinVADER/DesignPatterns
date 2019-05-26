using System;

namespace CommandPattern.Receiver
{
    public class Light
    {
        internal void on()
        {
            Console.WriteLine(@"Lights turned on!");
        }
    }
}