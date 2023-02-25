using System;

namespace _09.FishTank
{
    internal class FishTank
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = lenght * width * height ;
            double usedSpace = volume * (percent * 0.01);
            double litres = (volume - usedSpace) * 0.001;
            Console.WriteLine(litres);


        }
    }
}
