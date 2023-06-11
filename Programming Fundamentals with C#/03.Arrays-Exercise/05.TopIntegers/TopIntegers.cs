namespace _05.TopIntegers
{
    internal class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] array = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                bool isTopInteger = true;
                int currentNumber = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    int nextNum = array[j];
                    if (nextNum >= currentNumber)
                    {
                        isTopInteger = false;
                        break;
                    }

                }

                if (isTopInteger)
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }
    }
}