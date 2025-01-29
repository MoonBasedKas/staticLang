using System;
using action;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic x = 1;
            dynamic y = 2.3;
            dynamic z = x + y;
            Console.WriteLine("Hello World " + z);
        }
    }
}