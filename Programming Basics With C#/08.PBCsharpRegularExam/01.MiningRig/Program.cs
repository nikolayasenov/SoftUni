using System;

namespace _01.MiningRig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int singleGpuPrice = int.Parse(Console.ReadLine());
            int transitional = int.Parse(Console.ReadLine());
            double gpuElConsumption = double.Parse(Console.ReadLine());
            double gpuDailyRavenue = double.Parse(Console.ReadLine());

            int gpuPrice = singleGpuPrice * 13;
            int transitionalPrice = transitional * 13;
            int moneySpend = gpuPrice + transitionalPrice + 1000;
            double allGpuRavenue = (gpuDailyRavenue - gpuElConsumption) * 13.0;
            double roi = moneySpend / allGpuRavenue;
            Console.WriteLine(moneySpend);
            Console.WriteLine(Math.Ceiling(roi));

        }
    }
}
