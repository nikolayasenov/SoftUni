using System;

namespace _08.PetShop
{
    internal class PetShop
    {
        static void Main(string[] args)
        {
            int dogFoodBags = int.Parse(Console.ReadLine());
            int catFoodBags = int.Parse(Console.ReadLine());
            double finalPrice = dogFoodBags * 2.50 + catFoodBags * 4;

            Console.WriteLine($"{finalPrice} lv.");
        }
    }
}
