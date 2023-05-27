using System.Linq;

namespace _05.Login
{
    internal class Login
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();
            // string correctPassword = String.Empty;
            // forr(i = userName.Lenght - 1; i >= 0; i--)
            // correctPassword += userName[i];
            string reverse = new string(userName.Reverse().ToArray());
            int counter = 0;
            bool isBlocked = false;
            while (password != reverse)
            {
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    isBlocked = true;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
            }
            if (!isBlocked)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}