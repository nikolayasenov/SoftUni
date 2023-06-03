namespace _10.PokeMon
{
    internal class PokeMon
    {
        static void Main(string[] args)
        {
            int originalPokePower = int.Parse(Console.ReadLine());
            int pokePower = originalPokePower;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int countPokedTargets = 0;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                countPokedTargets++;
                if (pokePower == originalPokePower * 0.5 && exhaustionFactor != 0)
                {
                    pokePower = pokePower / exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(countPokedTargets);
        }
    }
}