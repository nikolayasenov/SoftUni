namespace _09.SpiceMustFlow
{
    internal class SpiceMustFlow
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int daysCount = 0;
            int totalSpiceExtracted = 0;
            while (yield >= 100)
            {
                totalSpiceExtracted += yield;
                if (totalSpiceExtracted - 26 < 0)
                {
                    break;
                }
                totalSpiceExtracted -= 26 ;
                yield -= 10;
                daysCount++;
            }
            if (totalSpiceExtracted > 26)
            {
                totalSpiceExtracted -= 26;
            }
            Console.WriteLine(daysCount);
            Console.WriteLine(totalSpiceExtracted);
        }
    }
}