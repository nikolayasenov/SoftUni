using System;

namespace _02.NumbersNToOne
{
    internal class NumbersNToOne
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = number; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
