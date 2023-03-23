using System;

namespace _04.Walking
{
    internal class Walking
    {
        static void Main(string[] args)
        {
            const int stepsThreshold = 10000;
            int sumOfSteps = 0;
            bool goalReached = false;
            while (!goalReached && sumOfSteps < stepsThreshold)
            {
                string input = Console.ReadLine();
                int currentSteps;
                if (input == "Going home")
                {
                    currentSteps = int.Parse(Console.ReadLine());
                    goalReached = true;
                }
                else
                {
                    currentSteps = int.Parse(input);
                }
                sumOfSteps += currentSteps;
            }
            int difference = Math.Abs(stepsThreshold - sumOfSteps);
            if (sumOfSteps >= stepsThreshold)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{difference} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{difference} more steps to reach goal.");
            }
        }
    }
}
