using System;

namespace _09.SkiTrip
{
    internal class SkiTrip
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            days = days - 1;
            double price = 0;
            if (roomType == "room for one person")
            {
                price = 18.00 * days;
            }
            else if (roomType == "apartment")
            {
                price = 25 * days;
                if (days < 10)
                {
                    price = price - (price * 0.3);
                }
                else if (days < 15)
                {
                    price = price - (price * 0.35);
                }
                else
                {
                    price -= (price * 0.5);
                }
            }
            else if (roomType == "president apartment")
            {
                price = 35.00 * days;
                if (days < 10)
                {
                    price = price - (price * 0.1);
                }
                else if (days < 15)
                {
                    price = price - (price * 0.15);
                }
                else
                {
                    price = price - (price * 0.20);
                }
            }
            if (rating == "positive")
            {
                price = price + (price * 0.25);
            }
            else
            {
                price = price - (price * 0.1);
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
