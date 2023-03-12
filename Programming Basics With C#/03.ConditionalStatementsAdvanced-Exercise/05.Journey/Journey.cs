using System;

namespace _05.Journey
{
    internal class Journey
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double spendMoney = 0;
            string campOrHotel = "";
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spendMoney = budget * 0.3;
                }
                else if (season == "winter")
                {
                    spendMoney = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spendMoney = budget * 0.4;
                }
                else if (season == "winter")
                {
                    spendMoney = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                spendMoney = budget * 0.9;
            }

            if (season == "summer" && destination != "Europe")
            {
                campOrHotel = "Camp";
            }
            else
            {
                campOrHotel = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{campOrHotel} - {spendMoney:f2}");
        }
    }
}
