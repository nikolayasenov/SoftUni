﻿using System;

namespace _04.GiftsFromSanta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m ; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0 && i != s)
                {
                    Console.Write($"{i} ");
                }
                else if(i % 2 == 0 && i % 3 == 0 && i == s)
                {
                    break;
                }
            }
        }
    }
}
