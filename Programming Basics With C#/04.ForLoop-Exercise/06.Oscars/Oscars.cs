using System;

namespace _06.Oscars
{
    internal class Oscars
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointFromAcademy = double.Parse(Console.ReadLine());
            int numberOfJury = int.Parse(Console.ReadLine());
            double points = pointFromAcademy;
            for (int i = 0; i < numberOfJury && points < 1250.5; i++)
            {
                string nameOfJury = Console.ReadLine();
                double pointsFromJury = double.Parse(Console.ReadLine());
                points += nameOfJury.Length * pointsFromJury / 2;
            }
            if (points > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
            }
            else
            {
                double requiredPoints = Math.Abs(1250.5 - points);
                Console.WriteLine($"Sorry, {actorName} you need {requiredPoints:f1} more!");
            }
        }
    }
}
