using System;

namespace _04.FishingBoat
{
    internal class FishingBoat
    {
        static void Main(string[] args)
        {
            // 1.Read all input
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());
            // 2.Find rent price:
            // Spring: 3000 leva
            // Summer and Autumn: 4200 leva
            // Winter: 2600 leva
            double rentPrice = 0;
            if (season == "Spring")
            {
                rentPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rentPrice = 4200;
            }
            else if (season == "Winter")
            {
                rentPrice = 2600;
            }
            // 3.Calculate Discount
            // 6 people (including) - 10% discount
            // 7 to 11 people (including) - 15% discount
            // more than 12 people (including) - 25% discount
            if (fishermenCount <= 6)
            {
                rentPrice = rentPrice - 0.1 * rentPrice; // 0.9 * rentPrice
            }
            else if (fishermenCount <= 11)
            {
                rentPrice = rentPrice - 0.15 * rentPrice; // 0.85 * rentPrice
            }
            else
            {
                rentPrice = rentPrice - 0.25 * rentPrice; // 0.75 * rentPrice
            }
            // 4.Additional discount %2 == 0 and Not in Autumn = 5%
            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                rentPrice = rentPrice - 0.05 * rentPrice; // 0.95 * rentPrice
            }
            // 3. Output
            // If budget is enough: "Yes! You have {останалите пари:f2} leva left."
            // Else: "Not enough money! You need {сумата, която не достига:f2} leva."
            double absoluteDifference = Math.Abs(budget - rentPrice);
            if (budget >= rentPrice)
            {
                Console.WriteLine($"Yes! You have {absoluteDifference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {absoluteDifference:f2} leva.");
            }

        }
    }
}
