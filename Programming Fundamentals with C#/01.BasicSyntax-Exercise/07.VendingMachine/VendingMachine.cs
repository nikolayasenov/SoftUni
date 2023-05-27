using System.Windows.Markup;

namespace _07.VendingMachine
{
    internal class VendingMachine
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sumOfCoins = 0;
            while (input != "Start")
            {
                double coin = double.Parse(input);
                switch (coin)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        sumOfCoins += coin;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }

                input = Console.ReadLine();
            }
            while ((input = Console.ReadLine()) != "End")
            {
                double price = 0;
                switch (input)
                {
                    case "Nuts":
                        price = 2.0;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        continue;
                }
                if (sumOfCoins >= price)
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    sumOfCoins -= price;
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }
            Console.WriteLine($"Change: {sumOfCoins:f2}");
        }
    }
}