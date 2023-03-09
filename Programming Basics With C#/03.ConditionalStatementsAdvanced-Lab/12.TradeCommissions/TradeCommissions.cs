using System;

namespace _12.TradeCommissions
{
    internal class TradeCommissions
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            double commission = 0;

            
            if (sells >= 0 && sells <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = sells * 0.05;
                        break;
                    case "Varna":
                        commission = sells * 0.045;
                        break;
                    case "Plovdiv":
                        commission = sells * 0.055;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sells > 500 && sells <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = sells * 0.07;
                        break;
                    case "Varna":
                        commission = sells * 0.075;
                        break;
                    case "Plovdiv":
                        commission = sells * 0.080;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sells > 1000 && sells <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = sells * 0.08;
                        break;
                    case "Varna":
                        commission = sells * 0.10;
                        break;
                    case "Plovdiv":
                        commission = sells * 0.12;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sells > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = sells * 0.12;
                        break;
                    case "Varna":
                        commission = sells * 0.13;
                        break;
                    case "Plovdiv":
                        commission = sells * 0.145;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            if (commission > 0)
            {
                Console.WriteLine($"{commission:F2}");
            }
        }
    }
}
