using System;

namespace _08.LunchBreak
{
    internal class LunchBreak
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int movieDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());

            double timeForLunch = 0.125 * breakDuration;  // (1 / 8.0) * breakDuration;
            double timeForRest = 0.25 * breakDuration; // (1 / 4.0) * breakDuration;

            double totalTime = movieDuration + timeForLunch + timeForRest;
            double timeLeft = Math.Abs(breakDuration - totalTime);
            if (totalTime <= breakDuration)
            {
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(timeLeft)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(timeLeft)} more minutes.");
            }    
        }
    }
}
