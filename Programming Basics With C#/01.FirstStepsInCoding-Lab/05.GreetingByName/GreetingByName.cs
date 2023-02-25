using System;

namespace _05.GreetingByName
{
    internal class GreetingByName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            //Console.WriteLine($"Hello, {name}!");
        }
    }
}
