namespace _04.SumOfChars
{
    internal class SumOfChars
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            double sum = 0;
            while (numberOfLines > 0)
            {
                char currentChar = char.Parse(Console.ReadLine());
                sum += (int)currentChar;
                numberOfLines--;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}