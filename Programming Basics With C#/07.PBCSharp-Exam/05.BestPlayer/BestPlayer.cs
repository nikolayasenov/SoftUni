using System;

namespace _05.BestPlayer
{
    internal class BestPlayer
    {
        static void Main(string[] args)
        {
            string currentPlayerName = Console.ReadLine();
            int currentGoals = int.Parse(Console.ReadLine());
            bool endLoop = false;
            int bestGoaler = int.MinValue;
            bool hasHetrik = false;
            string currentBestPlaer = String.Empty;
            while(!endLoop && currentPlayerName != "END")
            {
                
                if (currentGoals >= 10)
                {
                    currentBestPlaer = currentPlayerName;
                    bestGoaler = currentGoals;
                    hasHetrik=true;
                    break;
                }
                if(currentGoals > bestGoaler)
                {
                    bestGoaler = currentGoals;
                    currentBestPlaer = currentPlayerName;
                    if (bestGoaler >= 3)
                    {
                        hasHetrik = true;
                    }
                }
                currentPlayerName = Console.ReadLine();
                if (currentPlayerName == "END")
                {
                    endLoop = true;
                    break;
                }
                currentGoals = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{currentBestPlaer} is the best player!");
            if (hasHetrik)
            {
                Console.WriteLine($"He has scored {bestGoaler} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestGoaler} goals.");
            }
        }
    }
}
