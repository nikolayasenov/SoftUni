using System;

namespace _06.VowelsSum
{
    internal class VowelsSum
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                switch (currentLetter)
                {
                    case 'a':
                        result += 1;
                        break;
                    case 'e':
                        result += 2;
                        break;
                    case 'i':
                        result += 3;
                        break;
                    case 'o':
                        result += 4;
                        break;
                    case 'u':
                        result += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
