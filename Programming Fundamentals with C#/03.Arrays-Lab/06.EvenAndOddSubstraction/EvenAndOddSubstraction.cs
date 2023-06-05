namespace _06.EvenAndOddSubstraction
{
    internal class EvenAndOddSubstraction
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int sumEven = 0, sumOdd = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                }
                else
                {
                    sumOdd += numbers[i];
                }
            }
            int result = sumEven - sumOdd;
            Console.WriteLine(result);
        }
    }
}