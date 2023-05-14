using System;

namespace _03.PastryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pastryType = Console.ReadLine();
            int pastryOrderCount = int.Parse(Console.ReadLine());
            int date = int.Parse(Console.ReadLine());
            double pastryPrice = 0;
            if (date <= 15)
            {
                if (pastryType == "Cake")
                {
                    pastryPrice = 24.0 * pastryOrderCount;
                }
                else if (pastryType == "Souffle")
                {
                    pastryPrice = 6.66 * pastryOrderCount;
                }
                else if (pastryType == "Baklava")
                {
                    pastryPrice = 12.60 * pastryOrderCount;
                }
            }
            else
            {
                if (pastryType == "Cake")
                {
                    pastryPrice = 28.70 * pastryOrderCount;
                }
                else if (pastryType == "Souffle")
                {
                    pastryPrice = 9.80 * pastryOrderCount;
                }
                else if (pastryType == "Baklava")
                {
                    pastryPrice = 16.98 * pastryOrderCount;
                }
            }
            if (date <= 22 )
            {
                if (pastryPrice >= 100 && pastryPrice <= 200)
                {
                    pastryPrice -= pastryPrice * 0.15;
                }
                else if (pastryPrice > 200)
                {
                    pastryPrice -= pastryPrice * 0.25;
                }
            }
            if (date <= 15)
            {
                pastryPrice -= pastryPrice * 0.1;
            }
            Console.WriteLine($"{pastryPrice:f2}");

        }
    }
}
