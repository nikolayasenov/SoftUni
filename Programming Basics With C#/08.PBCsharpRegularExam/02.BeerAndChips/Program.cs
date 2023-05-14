using System;

namespace _02.BeerAndChips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string footballFanName = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerBottles = int.Parse(Console.ReadLine());
            int packetsChips = int.Parse(Console.ReadLine());

            double beerPrice = beerBottles * 1.20;
            double chipsPrice = (beerPrice * 0.45) * packetsChips;
            double orderPrice = Math.Ceiling(chipsPrice) + beerPrice;
            double moneyDiff = Math.Abs(budget - orderPrice);
            if (orderPrice <= budget)
            {
                Console.WriteLine($"{footballFanName} bought a snack and has {moneyDiff:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{footballFanName} needs {moneyDiff:f2} more leva!");
            }
        }
    }
}
