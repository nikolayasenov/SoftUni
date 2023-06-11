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
            for (int rot = 1; rot <= rotations; rot++)
            {
                int firstElement = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    array[i - 1] = array[i];
                }
                array[array.Length - 1] = firstElement;

            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}