using System;

namespace _05.ChristmasGifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countOverSixteen = 0;
            int countUnderSixteen = 0;
            double toysSum = 0;
            double sweatersSum = 0;
            while (input != "Christmas")
            {
                int currentYears = int.Parse(input);
                if (currentYears <= 16)
                {
                    toysSum += 5;
                    countUnderSixteen++;
                }
                else
                {
                    sweatersSum += 15;
                    countOverSixteen++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Number of adults: {countOverSixteen}");
            Console.WriteLine($"Number of kids: {countUnderSixteen}");
            Console.WriteLine($"Money for toys: {toysSum}");
            Console.WriteLine($"Money for sweaters: {sweatersSum}");
        }
    }
}
