namespace _06.ReversedChars
{
    internal class ReversedChars
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();

            Console.WriteLine($"{input3} {input2} {input1}");
            //string reversed = String.Empty;
            //for (int i = 0; i < 3; i++)
            //{
            //    string currentChar = String.Empty;
            //    char character = char.Parse(Console.ReadLine());
            //    currentChar = char.ToString(character);
            //    reversed += " " + currentChar;
            //}
            //reversed = new string(reversed.Reverse().ToArray());
            //Console.WriteLine(reversed);
        }
    }
}