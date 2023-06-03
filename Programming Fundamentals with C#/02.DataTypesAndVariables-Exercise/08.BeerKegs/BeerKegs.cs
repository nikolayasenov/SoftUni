namespace _08.BeerKegs
{
    internal class BeerKegs
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            double biggestVolume = double.MinValue;
            string biggestKeg = String.Empty;
            while (numberOfLines > 0)
            {
                double volume = 0;
                string kegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radius , 2) * height;
                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = kegModel;
                    numberOfLines--;
                    continue;
                }
                numberOfLines--;
                
            }
            Console.WriteLine(biggestKeg);
        }
    }
}