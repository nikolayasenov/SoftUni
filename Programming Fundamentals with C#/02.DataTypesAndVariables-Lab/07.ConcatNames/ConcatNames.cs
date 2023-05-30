namespace _07.ConcatNames
{
    internal class ConcatNames
    {
        static void Main(string[] args)
        {
            string nameOne = Console.ReadLine();
            string nameTwo = Console.ReadLine();
            string delimer = Console.ReadLine();
            Console.WriteLine($"{nameOne}{delimer}{nameTwo}");
        }
    }
}