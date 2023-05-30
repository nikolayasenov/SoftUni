namespace _12.RefactorSpecialNumbers
{
    internal class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbersCount; i++)
            {
                bool isSpecialNum = false;
                int sum = 0;
                int digit = i;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecialNum = true;
                } 

                Console.WriteLine($"{i} -> {isSpecialNum}");
            }
        }
    }
}