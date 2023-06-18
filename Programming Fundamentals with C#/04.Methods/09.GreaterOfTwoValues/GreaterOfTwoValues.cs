namespace _09.GreaterOfTwoValues
{
    internal class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            if (type == "int")
            {
                int firstInt = int.Parse(firstValue);
                int secondInt = int.Parse(secondValue);
                int result = GetMax(firstInt, secondInt);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }

        }
        static int GetMax(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            return secondValue;
        }
        static char GetMax(char firstValue, char secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            return secondValue;
        }
        static string GetMax(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) > 0)
            {
                return firstValue;
            }
            return secondValue;
        }

    }
}