using System;

namespace _01.NumberPyramid
{
    internal class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            int numberToPrint = 1;
            while (numberToPrint <= n)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write($"{numberToPrint} ");
                    numberToPrint++;
                    if (numberToPrint > n)
                    {
                        break;
                    }
                }
                row++;
                Console.WriteLine();
            }
            //int n = int.Parse(Console.ReadLine());
            //int row = 1;
            //int countOfWrittenNumbers = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"{i} ");
            //    countOfWrittenNumbers++;
            //    if (countOfWrittenNumbers == row)
            //    {
            //        Console.WriteLine();
            //        countOfWrittenNumbers = 0;
            //        row++;
            //    }
            //}
        }
    }
}
