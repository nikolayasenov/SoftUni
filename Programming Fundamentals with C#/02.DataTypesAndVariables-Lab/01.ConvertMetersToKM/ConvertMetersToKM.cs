namespace _01.ConvertMetersToKM
{
    internal class ConvertMetersToKM
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double convert = number * 0.001;
            Console.WriteLine($"{convert:f2}");
        }
    }
}