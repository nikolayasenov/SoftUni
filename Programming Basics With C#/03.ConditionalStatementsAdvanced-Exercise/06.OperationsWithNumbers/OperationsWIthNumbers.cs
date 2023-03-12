using System;

namespace _06.OperationsWithNumbers
{
    internal class OperationsWIthNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            if ((operation == '/' || operation == '%') && secondNumber == 0)
            {
                Console.WriteLine($"Cannot divide {firstNumber} by zero");
            }
            else
            {
                if (operation == '/')
                {
                    double divisionResult = (double)firstNumber / secondNumber;
                    // (1.0 * firstNumber) / secondNumber
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {divisionResult:f2}");
                }
                else if (operation == '%')
                {
                    int remainder = firstNumber % secondNumber;
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {remainder}");
                }
                else
                {
                    int result = 0;
                    if (operation == '+')
                    {
                        result = firstNumber + secondNumber;
                    }
                    else if (operation == '-')
                    {
                        result = firstNumber - secondNumber;
                    }
                    else if (operation == '*')
                    {
                        result = firstNumber * secondNumber;
                    }

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result} - odd");
                    }
                }
            }

        }
    }
}
