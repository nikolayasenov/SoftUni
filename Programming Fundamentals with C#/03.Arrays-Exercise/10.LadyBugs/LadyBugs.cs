namespace _10.LadyBugs
{
    internal class LadyBugs
    {
        static void Main(string[] args)
        {
            long fieldLenght = long.Parse(Console.ReadLine());

            int[] bugPlaces = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            long[] field = new long[fieldLenght];

            for (int i = 0; i < bugPlaces.Length; i++)
            {
                int currentIndex = bugPlaces[i];
                if (currentIndex >= 0 && currentIndex < field.Length)
                {
                    field[currentIndex] = 1;
                }

            }
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                int bugIndex = int.Parse(arguments[0]);
                string direction = arguments[1];
                int flyLength = int.Parse(arguments[2]);

                if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0)
                {
                    continue;
                }

                field[bugIndex] = 0;
                if (direction == "right")
                {
                    int landIndex = bugIndex + flyLength;
                    if (landIndex > field.Length - 1)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLength;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }

                }
                else if (direction == "left")
                {
                    int landIndex = bugIndex - flyLength;
                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0)
                    {
                        field[landIndex] = 1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",field));
        }
    }
}