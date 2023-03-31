using System;

namespace _04.GrandpaStavri
{
    internal class GrandpaStavri
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double sumLitres = 0;
            double sumDegrees = 0;
            for (int i = 1; i <= days; i++)
            {
                double currentLitresRakia = double.Parse(Console.ReadLine());
                double currentDegrees = double.Parse(Console.ReadLine());
                sumLitres += currentLitresRakia;
                sumDegrees += currentLitresRakia * currentDegrees;
            }
            double averageDegrees = sumDegrees / (double)sumLitres;
            Console.WriteLine($"Liter: {sumLitres:f2}");
            Console.WriteLine($"Degrees: {averageDegrees:f2}");
            if (averageDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if(averageDegrees < 42)
            {
                Console.WriteLine("Super!");
            }
            else 
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
