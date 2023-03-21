using System;

namespace _07.MinNumber
{
    internal class MinNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;
            while (input != "Stop")
            {
                int currentNumber = int.Parse(input);
                if (currentNumber < min)
                {
                    min = currentNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
