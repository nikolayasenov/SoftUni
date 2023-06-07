namespace _04.ArrayRotation
{
    internal class ArrayRotation
    {
        static void Main(string[] args)
        {
            int[] array = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                array[0] = array[array.Length - 1];
                array[array.Length - 1] = array[0];
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}