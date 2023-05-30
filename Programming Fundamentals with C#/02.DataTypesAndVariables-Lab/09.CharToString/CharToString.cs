namespace _09.CharToString
{
    internal class CharToString
    {
        static void Main(string[] args)
        {
            string text = String.Empty;
            for (int i = 0; i < 3; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                text += new string(currentChar.ToString());
            }
            Console.WriteLine(text);
        }
    }
}