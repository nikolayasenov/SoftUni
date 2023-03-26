using System;

namespace _05.Traveling
{
    internal class Traveling
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                while (budget > 0)
                {
                    double currentSavedMoney = double.Parse(Console.ReadLine());
                    budget -= currentSavedMoney;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }

        }
    }
}
