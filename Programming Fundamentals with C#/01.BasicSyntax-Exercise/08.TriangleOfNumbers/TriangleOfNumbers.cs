namespace _08.TriangleOfNumbers
{
    internal class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int row = 1; row <= number; row++)
            {
                for (int times = 1; times <= row; times++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }
    }
}