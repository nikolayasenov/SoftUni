using System;

namespace _04.VacationBooksList
{
    internal class VacationBooksList
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());
            int totalHours = numberOfPages / pagesPerHour;
            int hoursPerDay = totalHours / numberOfDays;
            Console.WriteLine(hoursPerDay);

        }
    }
}
