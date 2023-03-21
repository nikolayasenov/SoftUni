using System;

namespace _08.Graduation
{
    internal class Graduation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double allGrades = 0;
            int badGrades = 0;
            int grade = 1;
            while (grade <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade < 4)
                {
                    badGrades++;
                    if (badGrades == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        return;
                    }
                    continue;
                }
                grade++;
                allGrades += currentGrade;
            }
            double averageGrade = allGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
