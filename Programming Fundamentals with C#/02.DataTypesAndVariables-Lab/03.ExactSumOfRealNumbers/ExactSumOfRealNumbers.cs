namespace _03.ExactSumOfRealNumbers
{
    internal class ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            decimal sum = 0;
            while (numbersCount > 0)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
                numbersCount--;
            }
            Console.WriteLine(sum);
        }
    }
}