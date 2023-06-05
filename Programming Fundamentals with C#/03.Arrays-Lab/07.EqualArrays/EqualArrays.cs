using System;

namespace _07.EqualArrays
{
    internal class EqualArrays
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] arrayTwo = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            int differentIndex = 0;
            bool arraysAreEqual = true;
            /* Easier dont need two for loops
             * for (int i = 0; i < arrayOne.Length; i++)
             {
                    if(arrayOne[i] != arrayTwo[i])
             }
            */
            for (int i = 0; i < arrayOne.Length && arraysAreEqual == true; i++)
            {
                for (int j = i; j < arrayTwo.Length; j++)
                {
                    if (arrayOne[i] == arrayTwo[j])
                    {
                        sum += arrayOne[i];
                    }
                    else
                    {
                        differentIndex = i;
                        arraysAreEqual = false;
                        break;
                    }
                    break;
                }
            }
            if (arraysAreEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {differentIndex} index");
            }
        }
    }
}