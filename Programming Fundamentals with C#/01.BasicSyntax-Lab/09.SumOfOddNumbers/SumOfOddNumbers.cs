namespace _09.SumOfOddNumbers
{
    internal class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= rows * 2; i += 2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");

            //int countOfNumbers = int.Parse(Console.ReadLine());
            //int sumOfOddNumbers = 0;
            //int counter = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //        sumOfOddNumbers += i;
            //        counter++;
            //    }
            //    if (counter == countOfNumbers)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine($"Sum: {sumOfOddNumbers}");
        }
    }
}