using System;

namespace _07.SumNumbers
{
    internal class SumNumbers
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < numbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                result += currentNumber;
            }
            Console.WriteLine(result);
        }
    }
}
