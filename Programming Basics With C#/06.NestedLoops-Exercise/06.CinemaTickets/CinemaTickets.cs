using System;

namespace _06.CinemaTickets
{
    internal class CinemaTickets
    {
        static void Main(string[] args)
        {
            int totalSoldTickets = 0, standartTickets = 0, studentTickets = 0, kidTickets = 0;
            string movie = Console.ReadLine();
            while (movie != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                int soldTicketsForCurrentProjection = 0;
                string ticketType = Console.ReadLine();
                while (soldTicketsForCurrentProjection < freeSeats && ticketType != "End")
                {
                    if (ticketType == "standard")
                    {
                        standartTickets++;
                    }
                    else if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                    }
                    soldTicketsForCurrentProjection++;
                    if (soldTicketsForCurrentProjection >= freeSeats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                double filPercentage = (double)soldTicketsForCurrentProjection / freeSeats * 100;
                Console.WriteLine($"{movie} - {filPercentage:f2}% full.");
                totalSoldTickets += soldTicketsForCurrentProjection;
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalSoldTickets}");
            double studentTicketPercentage = (double)studentTickets / totalSoldTickets * 100;
            double standartTicketPercentage = (double)standartTickets / totalSoldTickets * 100; ;
            double kidTicketPercentage = (double)kidTickets / totalSoldTickets * 100; ;
            Console.WriteLine($"{studentTicketPercentage:f2}% student tickets.");
            Console.WriteLine($"{standartTicketPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketPercentage:f2}% kids tickets.");
        }
    }
}
