using System;

namespace _07.Shopping
{
    internal class Shopping
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int graphicCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double graphicCardsPrice = graphicCards * 250;
            double processorsPrice = processors * (graphicCardsPrice * 0.35);
            double ramPrice = ram * (graphicCardsPrice * 0.1);
            double finalPrice = graphicCardsPrice + processorsPrice + ramPrice;
            if (graphicCards > processors)
            {
                finalPrice = finalPrice - (finalPrice * 0.15);
            }

            double spareMoney = Math.Abs(budget - finalPrice);
            if (finalPrice <= budget)
            {
                Console.WriteLine($"You have {spareMoney:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {spareMoney:F2} leva more!");
            }
        }
    }
}
