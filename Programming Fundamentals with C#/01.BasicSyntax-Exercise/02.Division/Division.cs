namespace _02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int biggestDivider = 0;
            if (number % 10 == 0)
            {
                biggestDivider = 10;
            }
            else if (number % 7 == 0)
            {
                biggestDivider = 7;
            }
            else if (number % 6 == 0)
            {
                biggestDivider = 6;
            }
            else if (number % 3 == 0)
            {
                biggestDivider = 3;
            }
            else if (number % 2 == 0)
            {
                biggestDivider = 2;
            }
            if (biggestDivider > 0)
            {
                Console.WriteLine($"The number is divisible by {biggestDivider}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}