using System;

namespace _09.LeftAndRightSum
{
    internal class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int resultOne = 0;
            int resultTwo = 0;
            int difference = 0;
            for (int i = 0; i < numbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                resultOne += currentNumber;
            }
            for (int i = 0; i < numbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                resultTwo += currentNumber;
            }
            if (resultOne == resultTwo)
            {
                Console.WriteLine($"Yes, sum = {resultOne}");
            }
            else
            {
                difference = Math.Abs(resultOne - resultTwo);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
