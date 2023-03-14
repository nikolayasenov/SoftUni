using System;

namespace _10.OddEvenSum
{
    internal class OddEvenSum
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int resultEven = 0;
            int resultOdd = 0;
            for (int i = 0; i < numbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    resultEven += currentNumber;
                }
                else
                {
                    resultOdd += currentNumber;
                }
    
            }
            if (resultEven == resultOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {resultEven}");
            }
            else
            {
                int diff = Math.Abs(resultEven - resultOdd);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
