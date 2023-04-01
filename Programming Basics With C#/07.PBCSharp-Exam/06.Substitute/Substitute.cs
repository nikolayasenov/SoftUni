using System;

namespace _06.Substitute
{
    internal class Substitute
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            int currentCombination = 0;
            for (int k = firstNumber; k <= 8; k++)
            {
                for (int l = 9; l >= secondNumber; l--)
                {
                    for (int m = thirdNumber; m <= 8; m++)
                    {
                        for (int n = 9; n >=fourthNumber; n--)
                        {
                            if (k == m && l == n && k % 2 == 0 && l % 2 != 0)
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                            else if (k % 2 == 0 && l % 2 != 0 && m % 2 == 0 && n % 2 != 0)
                            {
                                Console.WriteLine($"{k}{l} - {m}{n}");
                                currentCombination++;
                            }
                            if (currentCombination == 6)
                            {
                                break;
                            }
                        }
                        if (currentCombination == 6)
                        {
                            break;
                        }
                    }
                    if (currentCombination == 6)
                    {
                        break;
                    }
                }
                if (currentCombination == 6)
                {
                    break;
                }
            }

             
        }
    }
}
