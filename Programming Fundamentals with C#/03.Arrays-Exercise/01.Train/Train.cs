namespace _01.Train
{
    internal class Train
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numberOfWagons];
            //int totalPassengers = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                wagons[i] = passengers;
            }
            Console.WriteLine(string.Join(" " , wagons));
            Console.WriteLine(wagons.Sum());
        }
    }
}