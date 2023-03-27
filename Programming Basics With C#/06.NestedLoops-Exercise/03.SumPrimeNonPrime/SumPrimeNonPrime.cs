using System;

namespace _03.SumPrimeNonPrime
{
    internal class SumPrimeNonPrime
    {
        static void Main(string[] args)
        {
            int primeSum = 0, nonPrimeSum = 0;
            string input = Console.ReadLine();
            while (input != "stop")
            {
                int currentNumber = int.Parse(input);
                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    double sqrt = Math.Sqrt(currentNumber);
                    for (int i = 2; i <= sqrt && isPrime; i++)
                    {
                        if (currentNumber % i == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        primeSum += currentNumber;
                    }
                    else
                    {
                        nonPrimeSum += currentNumber;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
