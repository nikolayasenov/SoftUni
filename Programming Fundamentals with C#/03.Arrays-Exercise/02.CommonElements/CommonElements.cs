﻿namespace _02.CommonElements
{
    internal class CommonElements
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();
            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int j = 0; j < secondArr.Length; j++)
                {
                    if (firstArr[i] == secondArr[j])
                    {
                        Console.Write($"{firstArr[i]} ");
                    }
                }
            }
            //foreach (var firstElement in firstArr)
            //{
            //    foreach (var secondElement in secondArr)
            //    {
            //        if (firstElement == secondElement)
            //        {
            //            Console.Write(firstElement);
            //        }
            //    }
            //}
        }
    }
}