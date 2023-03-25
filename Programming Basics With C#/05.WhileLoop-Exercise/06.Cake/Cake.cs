using System;

namespace _06.Cake
{
    internal class Cake
    {
        static void Main(string[] args)
        {
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakePieces = cakeLenght * cakeWidth;
            bool stopEating = false;
            while (!stopEating && cakePieces > 0)
            {
                string input = Console.ReadLine();
                int takenPieces;
                if (input == "STOP")
                {
                    stopEating = true;
                    break;
                }
                else 
                {
                    takenPieces = int.Parse(input);
                    cakePieces -= takenPieces;
                }
            }
            int piecesLeft = Math.Abs(cakePieces);
            if (stopEating && piecesLeft > 0)
            {
                Console.WriteLine($"{piecesLeft} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {piecesLeft} pieces more.");
            }
        }
    }
}
