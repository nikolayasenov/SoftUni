namespace _04.RverseArrayOfStrings
{
    internal class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] text = Console
                .ReadLine()
                .Split(' ')
                .ToArray();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i] + " ");
            }
        }
    }
}