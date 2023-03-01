using System;

namespace _07.FoodDelivery
{
    internal class FoodDelivery
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());
            double chickenPrice = chickenMenu * 10.35 ;
            double fishPrice = fishMenu * 12.40;
            double veganPrice = veganMenu * 8.15;
            double orderPrice = chickenPrice + fishPrice + veganPrice;
            double finalPrice = orderPrice + (orderPrice * 0.2) + 2.50;
            Console.WriteLine(finalPrice);

        }
    }
}
