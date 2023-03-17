using System;

namespace _08.TennisRanklist
{
    internal class TennisRanklist
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int points = 0;
            int wins = 0;
            for (int i = 0; i < tournaments; i++)
            {
                string rank = Console.ReadLine();
                if (rank == "W")
                {
                    points += 2000;
                    wins++;
                }
                else if(rank == "F")
                {
                    points += 1200;
                }
                else if (rank == "SF")
                {
                    points += 720;
                }
            }
            int finalPoints = points + startingPoints;
            double averagePoints = points / tournaments; //Math.Floor
            double wonTournamentsPercentage = (double)wins / tournaments * 100;
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{wonTournamentsPercentage:f2}%");
        }
    }
}
