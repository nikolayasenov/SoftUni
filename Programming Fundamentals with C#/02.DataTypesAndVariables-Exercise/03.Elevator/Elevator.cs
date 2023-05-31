namespace _03.Elevator
{
    internal class Elevator
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;
            // int courses = (int)Math.Celing((double)peopleCount / capacity)
            if (peopleCount % capacity == 0)
            {
                courses = peopleCount / capacity;
            }
            else
            {
                int leftPersons = peopleCount % capacity;
                courses = peopleCount / capacity + 1;
            }
            Console.WriteLine(courses);

        }
    }
}