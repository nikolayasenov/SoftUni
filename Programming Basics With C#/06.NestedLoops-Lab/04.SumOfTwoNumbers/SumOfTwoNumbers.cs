using System;

namespace _04.SumOfTwoNumbers
{
    internal class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            bool endLoop = false;
            for (int i = start; i <= end && !endLoop; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                        endLoop = true;
                        break;
                    }
                }
            }
            if (!endLoop)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
            
        }
    }
}
