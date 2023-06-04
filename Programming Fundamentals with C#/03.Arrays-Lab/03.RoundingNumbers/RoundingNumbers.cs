namespace _03.RoundingNumbers
{
    internal class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {currentNumber}");
            }
        }
    }
}