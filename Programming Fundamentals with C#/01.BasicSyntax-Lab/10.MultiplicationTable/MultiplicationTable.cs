﻿namespace _10.MultiplicationTable
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int product = number * i;
                Console.WriteLine($"{number} X {i} = {product}");
            }
        }
    }
}