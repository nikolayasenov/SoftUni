using System;

namespace _01.CatDiet
{
    internal class CatDiet
    {
        static void Main(string[] args)
        {
            int fatPercentage = int.Parse(Console.ReadLine());
            int proteinPercentage = int.Parse(Console.ReadLine());
            int carboPercentage = int.Parse(Console.ReadLine());
            int requiredCalories = int.Parse(Console.ReadLine());
            int waterPercentage = int.Parse(Console.ReadLine());

            double fatCal = (fatPercentage * requiredCalories * 0.01) / 9.0;
            double proteinCal = (proteinPercentage * requiredCalories * 0.01) / 4.0;
            double carboCal = (carboPercentage * requiredCalories * 0.01) / 4.0;

            double totalFood = fatCal + proteinCal + carboCal;
            double foodCalPerGram = requiredCalories / totalFood;
            double calWithoutWater = foodCalPerGram * waterPercentage * 0.01;
            double finalCal = foodCalPerGram - calWithoutWater;
            Console.WriteLine($"{finalCal:f4}");


        }
    }
}
