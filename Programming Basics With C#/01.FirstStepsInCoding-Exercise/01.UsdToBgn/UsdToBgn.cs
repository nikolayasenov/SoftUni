﻿using System;

namespace _01.UsdToBgn
{
    internal class UsdToBgn
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine(bgn);
        }
    }
}
