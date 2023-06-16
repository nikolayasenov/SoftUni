namespace _04.PrintingTriangle
{
    internal class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);
            
        }
        static void PrintTriangle(int input)
        {
            PrintTriangleTopPart(input);
            PrintBottomTrianglePart(input - 1);
        }

        private static void PrintBottomTrianglePart(int input)
        {
            for (int row = input; row >= 1; row--)
            {
                PrintTriangleRow(row);
            }
        }

        private static void PrintTriangleRow(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }

            Console.WriteLine();
        }

        private static void PrintTriangleTopPart(int input)
        {
            for (int row = 1; row <= input; row++)
            {
                PrintTriangleRow(row);
            }
        }
    }
}