using System;

namespace _08.CinemaTicket
{
    internal class CinemaTicket
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int priceOfTicket = 0;
            if (day == "Monday" || day == "Tuesday" || day == "Friday")
            {
                priceOfTicket = 12;
            }
            else if (day == "Wednesday" || day == "Thursday")
            {
                priceOfTicket = 14;
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                priceOfTicket = 16;
            }
            Console.WriteLine(priceOfTicket);
        }
    }
}
