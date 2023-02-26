using System;

namespace _07.ProjectsCreation
{
    internal class ProjectsCreation
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projects= int.Parse(Console.ReadLine());
            int hoursNeeded = projects * 3;
            Console.WriteLine($"The architect {architectName} will need {hoursNeeded} hours to complete {projects} project/s.");
        }
    }
}
