using System;

namespace _03.Histrogram
{
    internal class Histogram
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            for (int i = 0; i < numbers; i++)
            {
                int currrentNumber = int.Parse(Console.ReadLine());
                if (currrentNumber < 200)
                {
                    p1++;
                }
                else if (currrentNumber < 400)
                {
                    p2++;
                }
                else if (currrentNumber < 600)
                {
                    p3++;
                }
                else if (currrentNumber < 800)
                {
                    p4++;
                }
                else if (currrentNumber >= 800)
                {
                    p5++;
                }
            }
            Console.WriteLine($"{(double)p1 / numbers * 100:f2}%");
            Console.WriteLine($"{(double)p2 / numbers * 100:f2}%");
            Console.WriteLine($"{(double)p3 / numbers * 100:f2}%");
            Console.WriteLine($"{(double)p4 / numbers * 100:f2}%");
            Console.WriteLine($"{(double)p5 / numbers * 100:f2}%");
        }
    }
}
