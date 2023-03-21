using System;

namespace _06.MaxNumber
{
    internal class MaxNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;
            while (input != "Stop")
            {
                int currentNumber = int.Parse(input);
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
