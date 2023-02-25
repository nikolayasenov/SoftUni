using System;

namespace _06.WorldSwimmingRecord
{
    internal class WorldSwimmingRecord
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double secForOneMeter = double.Parse(Console.ReadLine());

            double timeToSwimDistanceInSec = distanceInMeters * secForOneMeter;
            double ressistance = Math.Floor(distanceInMeters / 15) * 12.5;
            double totalTime = timeToSwimDistanceInSec + ressistance;
            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                double requiredSeconds = totalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {requiredSeconds:F2} seconds slower.");
            }

        }
    }
}
