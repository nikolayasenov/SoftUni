using System.Numerics;

namespace _11.Snowballs
{
    internal class Snowballs
    {
        static void Main(string[] args)
        {
            byte numberOfSnowballs = byte.Parse(Console.ReadLine());
            BigInteger highestSnowballValue = 0;
            short maxSnowballSnow = 0;
            short maxSnowballTime = 0;
            byte maxSnowballQuality = 0;
            while (numberOfSnowballs > 0)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime),snowballQuality);
                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                    
                }
                numberOfSnowballs--;
            }
            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {highestSnowballValue} ({maxSnowballQuality})");
        }
    }
}