using System;

namespace _06.GoldMine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLocations = int.Parse(Console.ReadLine());
            double averageGold = 0;
            double totalGoldPerLocation = 0;
            for (int i = numberOfLocations; i > 0; i--)
            {
                totalGoldPerLocation = 0;
                double dailyProjectedAverageGold = double.Parse(Console.ReadLine());
                int daysDigging = int.Parse(Console.ReadLine());
                int firstDaysDigging = daysDigging;
                while (daysDigging > 0)
                {
                    double dailyDiggedGold = double.Parse(Console.ReadLine());
                    totalGoldPerLocation += dailyDiggedGold;
                    daysDigging--;
                }
                averageGold = totalGoldPerLocation / firstDaysDigging;
                if (averageGold >= dailyProjectedAverageGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGold:f2}.");
                }
                else
                {
                    double goldDiff = Math.Abs(dailyProjectedAverageGold - averageGold);
                    Console.WriteLine($"You need {goldDiff:f2} gold.");
                }
            }
        }
    }
}
