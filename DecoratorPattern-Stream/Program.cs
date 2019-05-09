using System;
using System.IO;

namespace DecoratorPattern_Stream
{
    static class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader textFile = new LowerCaseStreamReader(@"Files\TextFile1.txt"))
            {
                int c;
                while ((c = textFile.Read())!=-1)
                {
                    Console.Write(Convert.ToChar(c));
                }
            }
        }
    }
}
