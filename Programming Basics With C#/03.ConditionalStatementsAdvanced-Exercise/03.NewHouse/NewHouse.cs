using System;

namespace _03.NewHouse
{
    internal class NewHouse
    {
        static void Main(string[] args)
        {
            // 1.Read all input
            string flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            // 2.Calculate total cost:
            // Roses - 5 leva; if more than 80 - 10% discount
            // Dahlias - 3.8 leva; if more than 90 - 15% discount
            // Tulips - 2.8 leva; if more than 80 - 15% discount
            // Narcissus - 3 leva; if less than 120 - add 15% to the final price
            // Gladious - 2.5 leva; if less than 80 - add 20% to the final price
            double totalCost = 0;
            if (flowersType == "Roses")
            {
                totalCost = 5 * flowersCount;

                if (flowersCount > 80)
                {
                    totalCost = totalCost - 0.1 * totalCost; // 0.9 * totalCost
                }
            }
            else if (flowersType == "Dahlias")
            {
                totalCost = 3.8 * flowersCount;

                if (flowersCount > 90)
                {
                    totalCost = totalCost - 0.15 * totalCost; // 0.85 * totalCost
                }
            }
            else if (flowersType == "Tulips")
            {
                totalCost = 2.8 * flowersCount;

                if (flowersCount > 80)
                {
                    totalCost = totalCost - 0.15 * totalCost; // 0.85 * totalCost
                }
            }
            else if (flowersType == "Narcissus")
            {
                totalCost = 3 * flowersCount;

                if (flowersCount < 120)
                {
                    totalCost = totalCost + 0.15 * totalCost; // 1.15 * totalCost
                }
            }
            else if (flowersType == "Gladiolus")
            {
                totalCost = 2.5 * flowersCount;

                if (flowersCount < 80)
                {
                    totalCost = totalCost + 0.2 * totalCost; // 1.20 * totalCost
                }
            }


            // 3.Output
            // If budget is enough: Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left.
            // Else: Not enough money, you need {нужната сума} leva more.
            if (budget >= totalCost)
            {
                double remainingMoney = budget - totalCost;
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {remainingMoney:f2} leva left.");
            }
            else
            {
                double remainingMoney = totalCost - budget;
                Console.WriteLine($"Not enough money, you need {remainingMoney:f2} leva more.");
            }
        }
    }
}
