using System;

namespace _03.DepositCalculator
{
    internal class DepositCalculator
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int depositLenght = int.Parse(Console.ReadLine());
            double yearlyIterest = double.Parse(Console.ReadLine());
            double sum = deposit + depositLenght *((deposit * yearlyIterest * 0.01 ) / 12);
            Console.WriteLine(sum);
        }
    }
}
