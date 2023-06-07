namespace _03.ZigZagArrays
{
    internal class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[numberOfLines];
            int[] arrayTwo = new int[numberOfLines];

            for (int i = 0; i < arrayOne.Length; i++)
            {
                int[] input = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    arrayOne[i] = input[0];
                    arrayTwo[i] = input[1];
                }
                else
                {
                    arrayOne[i] = input[1];
                    arrayTwo[i] = input[0];
                }
            }

            Console.WriteLine(string.Join(" ", arrayOne));
            Console.WriteLine(string.Join(" ", arrayTwo));
        }
    }
}