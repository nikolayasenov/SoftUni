using System;

namespace _08.BasketballEquipment
{
    internal class BasketBallEquipment
    {
        static void Main(string[] args)
        {
            int yearlyTax = int.Parse(Console.ReadLine());
            double sneakers = yearlyTax - (yearlyTax * 0.4);
            double outfit = sneakers - (sneakers * 0.2);
            double ball = outfit * 0.25;
            double accessoaries = ball * 0.2;
            double finalPrice = yearlyTax + sneakers + outfit + ball + accessoaries;
            Console.WriteLine(finalPrice);
        }
    }
}
