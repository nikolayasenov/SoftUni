using System;

namespace _04.ToyShop
{
    internal class ToyShop
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int orderCount = puzzles + dolls + bears + minions + trucks;
            double orderPrice = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
            if (orderCount >= 50)
            {
                orderPrice -= orderPrice * 0.25;
            }
            double finalProfit = orderPrice - (orderPrice * 0.1);
            double leftOverMoney = Math.Abs(finalProfit - tripPrice);

            if (finalProfit >= tripPrice)
            {
                Console.WriteLine($"Yes! {leftOverMoney:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {leftOverMoney:F2} lv needed.");
            }

            
        }
    }
}
