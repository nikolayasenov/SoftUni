using System;

namespace _03.Vacation
{
    internal class Vacation
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int countDays = 0;
            int spendingDays = 0;
            bool isSaved = false;
            while (spendingDays < 5)
            {
                countDays++;
                string spendOrSave = Console.ReadLine();
                double outgoingMoney = double.Parse(Console.ReadLine());
                if (spendOrSave == "spend")
                {
                    money -= outgoingMoney;
                    spendingDays++;
                    if (money <= 0)
                    {
                        money = 0;
                        continue;                        
                    }
                }
                else if (spendOrSave == "save")
                {
                    money += outgoingMoney;
                    spendingDays = 0;
                }
                if (spendingDays == 5)
                {
                    break;
                }
                if (money >= vacationPrice)
                {
                    isSaved = true;
                    break;
                }
                       
            }
            if (isSaved)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(countDays);
            }
        }
    }
}
