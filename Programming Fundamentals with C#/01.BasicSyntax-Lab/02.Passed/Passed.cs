namespace _02.Passed
{
    internal class Passed
    {
        static void Main(string[] args)
        {
            float grade = float.Parse(Console.ReadLine()!);
            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}