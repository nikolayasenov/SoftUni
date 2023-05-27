namespace _06.StrongNumber
{
    internal class StrongNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberInText = number.ToString();
            int sum = 0;
            for (int i = 0; i < numberInText.Length; i++)
            {
                int result = 0;
                double currentDigitInDouble = char.GetNumericValue(numberInText[i]);
                int currentDigit = (int)currentDigitInDouble;
                if (currentDigit != 0 && currentDigit != 1)
                {
                    for (int factoriel = currentDigit - 1; factoriel >= 1; factoriel--)
                    {
                        result = currentDigit * factoriel;
                        currentDigit = result;
                    }

                    sum += result;
                }
                else
                {
                    sum += 1;
                }

            }
            if (number == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}