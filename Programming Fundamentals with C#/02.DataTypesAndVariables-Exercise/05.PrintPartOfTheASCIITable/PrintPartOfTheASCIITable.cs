namespace _05.PrintPartOfTheASCIITable
{
    internal class PrintPartOfTheASCIITable
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            char currentChar = ' ';
            for (int i = start; i <= end; i++)
            {
                currentChar = (char)i;
                Console.Write($"{currentChar} ");
            }
        }
    }
}