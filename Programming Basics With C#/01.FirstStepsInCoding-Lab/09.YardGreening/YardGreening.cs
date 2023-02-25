using System;

namespace _09.YardGreening
{
    internal class YardGreening
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double squareMeterPrice = squareMeters * 7.61;
            double discount = squareMeterPrice * 0.18;
            double finalPrice = squareMeterPrice - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
