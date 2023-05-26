namespace _11.MultiplicationTable2._0
{
    internal class MultiplicationTableTwo
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier > 10)
            {
                int result = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {result}");
            }
            else if (true)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    int product = number * i;
                    Console.WriteLine($"{number} X {i} = {product}");
                }
            }
        }
    }
}