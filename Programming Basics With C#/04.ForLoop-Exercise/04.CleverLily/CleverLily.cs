using System;

namespace _04.CleverLily
{
    internal class CleverLily
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int singleToyPrice = int.Parse(Console.ReadLine());
            int savedMoney = 0;
            int giftedMoney = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    savedMoney += singleToyPrice;

                }
                else
                {
                    savedMoney += giftedMoney - 1;
                    giftedMoney += 10;
                }
            }
            double diff = Math.Abs(washingMachinePrice - savedMoney);
            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
