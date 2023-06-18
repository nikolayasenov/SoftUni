namespace _07.RepeatString
{
    internal class RepeatString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            RepeatStrings(str, n);
        }
        private static void RepeatStrings(string str, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(str);
            }
        }
    }
}