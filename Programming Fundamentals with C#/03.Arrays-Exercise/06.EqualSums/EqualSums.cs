namespace _06.EqualSums
{
    internal class EqualSums
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
                if (array.Length == 1) // array has only 1 element
                {
                    Console.WriteLine(0);
                    return;
                }
                // storing left sum
                int leftSum = 0;
                for (int k = i; k > 0; k--)
                {
                    int nextEl = k - 1;
                    if (k > 0)
                    {
                        leftSum += array[nextEl];
                    }
                }
                // storing right sum
                int rightSum = 0;
                for (int j = i; j < array.Length; j++)
                {
                    int nextEl = j + 1;
                    if (array.Length - 1 > j)
                    {
                        rightSum += array[nextEl];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}