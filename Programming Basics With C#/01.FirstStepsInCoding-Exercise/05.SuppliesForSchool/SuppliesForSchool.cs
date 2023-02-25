using System;

namespace _05.StudyMaterials
{
    internal class StudyMaterials
    {
        static void Main(string[] args)
        {
            int pensPack = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());
            double pensPrice = pensPack * 5.80;
            double markersPrice = markers * 7.20;
            double detergentPrice = detergent * 1.20;
            double price = pensPrice + markersPrice + detergentPrice;
            double discount = percentDiscount * 0.01;

            Console.WriteLine(price - (price * discount));
        }
    }
}
