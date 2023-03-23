using System;

namespace _02.ExamPreparation
{
    internal class ExamPreparation
    {
        static void Main(string[] args)
        {
            int maxCountOfBadGrades = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();
            int countOfProblems = 0;
            int countBadGrades = 0;
            int sumOfGrades = 0;
            string lastProblemName = String.Empty;
            while (problemName != "Enough")
            {               
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    countBadGrades++;
                    if (countBadGrades == maxCountOfBadGrades)
                    {                       
                        break;
                    }
                }
                sumOfGrades += grade;
                lastProblemName = problemName;
                problemName = Console.ReadLine();
                countOfProblems++;

            }
            if (countBadGrades == maxCountOfBadGrades)
            {
                Console.WriteLine($"You need a break, {countBadGrades} poor grades.");
            }
            else
            {
                double average = (double)sumOfGrades / countOfProblems;
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {countOfProblems}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }

        }
    }
}
