﻿using System;

namespace _01.NumbersEdingInSeven
{
    internal class NumbersEndingInSeven
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 997; i+=10)
            {
                Console.WriteLine(i);
                //if (i % 10 == 7)
                //{
                //    Console.WriteLine(i);
                //}
            }
        }
    }
}
