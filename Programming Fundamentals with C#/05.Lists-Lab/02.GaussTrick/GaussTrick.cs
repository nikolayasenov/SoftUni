namespace _02.GaussTrick
{
    internal class GaussTrick
    {
        static void Main(string[] args)
        {
            List<int> list = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count / 2; i++)
            {
                int first = list[i];
                int second = list[list.Count - i - 1];
                int sum = first + second;
                result.Add(sum);
            }

            if (list.Count % 2 != 0)
            {
                result.Add(list[list.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}