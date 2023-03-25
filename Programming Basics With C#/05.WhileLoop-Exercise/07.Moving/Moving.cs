using System;

namespace _07.Moving
{
    internal class Moving
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = width * lenght * height;
            bool movingOver = false;
            while (!movingOver && freeSpace > 0)
            {
                string input = Console.ReadLine();
                int numberOfBoxes;
                if (input == "Done")
                {
                    movingOver = true;
                    break;
                }
                else
                {
                    numberOfBoxes = int.Parse(input);
                    freeSpace -= numberOfBoxes;
                }
            }
            int cubicMeters = Math.Abs(freeSpace);
            if (movingOver && cubicMeters > 0)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {cubicMeters} Cubic meters more.");
            }
        }
    }
}
