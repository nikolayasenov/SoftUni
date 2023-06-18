namespace _10.MultiplyEvensByOdds
{
    internal class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }
        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            while (number > 0)
            {
                int currN = number % 10;
                number /= 10;
                if (currN % 2 == 0)
                {
                    evenSum += currN;
                }
            }
            return evenSum;

        }
        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int currN = number % 10;
                number /= 10;
                if (currN % 2 != 0)
                {
                    oddSum += currN;
                }
            }
            return oddSum;

        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            int totalSum = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            return totalSum;
        }
    }
}