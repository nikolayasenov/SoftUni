using System;

namespace _05.GodzillaVsKong
{
    internal class GodzillaVsKong
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int extrasCount = int.Parse(Console.ReadLine());
            double extrasClothingPrice = double.Parse(Console.ReadLine());

            double decor = movieBudget * 0.1;
            if (extrasCount > 150)
            {
                extrasClothingPrice -= extrasClothingPrice * 0.1;
            }

            double expenses = decor + extrasClothingPrice * extrasCount;
            double leftOverMoney = Math.Abs(movieBudget - expenses);
            if (expenses <= movieBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftOverMoney:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {leftOverMoney:F2} leva more.");
            }
        }
    }
}
