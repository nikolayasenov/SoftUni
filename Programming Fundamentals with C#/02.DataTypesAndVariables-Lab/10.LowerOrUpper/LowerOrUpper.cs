﻿namespace _10.LowerOrUpper
{
    internal class LowerOrUpper
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            bool isUpper= char.IsUpper(input);
            if (isUpper)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}