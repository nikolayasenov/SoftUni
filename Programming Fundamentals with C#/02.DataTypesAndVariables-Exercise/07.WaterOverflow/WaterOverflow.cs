namespace _07.WaterOverflow
{
    internal class WaterOverflow
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int litresInTheTank = 0;
            int numberOfLines = int.Parse(Console.ReadLine());
            while (numberOfLines > 0)
            {
                int litresOfWater = int.Parse(Console.ReadLine());
                if (litresOfWater > capacity || litresOfWater + litresInTheTank > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    numberOfLines--;
                    continue;
                }
                else
                {
                    litresInTheTank += litresOfWater;
                    numberOfLines--;
                }

            }
            Console.WriteLine(litresInTheTank);
        }
    }
}