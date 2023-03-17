using System;

namespace _07.TrekkingMania
{
    internal class TrekkingMania
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            int totalNumberOfPeople = 0;
            for (int i = 0; i < groups; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());
                if (numberOfPeople <= 5)
                { 
                    p1 += numberOfPeople;
                }
                else if (numberOfPeople <= 12)
                {
                    p2 += numberOfPeople;
                }
                else if (numberOfPeople <= 25)
                {
                    p3 += numberOfPeople;
                }
                else if (numberOfPeople <= 40)
                {
                    p4 += numberOfPeople;
                }
                else
                {
                    p5 += numberOfPeople;
                }

                totalNumberOfPeople += numberOfPeople;
            }
            Console.WriteLine($"{(double)p1 / totalNumberOfPeople * 100:f2}%");
            Console.WriteLine($"{(double)p2 / totalNumberOfPeople * 100:f2}%");
            Console.WriteLine($"{(double)p3 / totalNumberOfPeople * 100:f2}%");
            Console.WriteLine($"{(double)p4 / totalNumberOfPeople * 100:f2}%");
            Console.WriteLine($"{(double)p5 / totalNumberOfPeople * 100:f2}%");
        }
    }
}
