using System;

namespace _06.Repainting
{
    internal class Repainting
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paintLitres = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int workersHours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylon + 2) * 1.50;
            double paintLitresPrice = (paintLitres + (paintLitres * 0.1)) * 14.50;
            double diluentPrice = diluent * 5.00;
            double materialPrice = nylonPrice + paintLitresPrice + diluentPrice + 0.40;
            double workerPrice = (materialPrice * 0.3) * workersHours;
            double finalPrice = materialPrice + workerPrice;
            Console.WriteLine(finalPrice);

        }
    }
}
