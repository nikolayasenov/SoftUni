namespace _03.PassedOrFailed
{
    internal class PassedOrFailed
    {
        static void Main(string[] args)
        {
            float grade = float.Parse(Console.ReadLine()!);
            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}