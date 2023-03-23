using System;

namespace _01.OldBooks
{
    internal class OldBooks
    {
        static void Main(string[] args)
        {
            string bookToLookFor = Console.ReadLine();
            string currentBook = Console.ReadLine();
            bool isFound = false;
            int bookCount = 0;
            while (currentBook != "No More Books")
            {

                if (currentBook == bookToLookFor)
                {
                    isFound = true;
                    break;
                }
                currentBook = Console.ReadLine();
                bookCount++;
            }
            if (isFound)
            {
                Console.WriteLine($"You checked {bookCount} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCount} books.");
            }
        }
    }
}
