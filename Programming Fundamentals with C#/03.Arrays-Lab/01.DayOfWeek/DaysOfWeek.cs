namespace _01.DayOfWeek
{
    internal class DaysOfWeek
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[]{"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int number = int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 7)
            {
                Console.WriteLine(daysOfWeek[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}