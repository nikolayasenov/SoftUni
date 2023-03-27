using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class EqualSumsEvenOddPosition
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int evenSum = 0, oddSum = 0, digitPosition = 0;
                int number = i;
                while (number != 0)
                {
                    int lastDigit = number % 10;
                    if (digitPosition % 2 == 0)
                    {
                        evenSum += lastDigit;
                    }
                    else
                    {
                        oddSum += lastDigit;
                    }
                    digitPosition++;
                    number /= 10;
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
                
            }
        }
    }
}
