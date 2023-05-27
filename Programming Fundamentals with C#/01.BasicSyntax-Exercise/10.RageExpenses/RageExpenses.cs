namespace _10.RageExpenses
{
    internal class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int count = 0;
            double price = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                bool trashedHeadset = false;
                bool trashedMouse = false;
                if (i % 2 == 0)
                {
                    trashedHeadset = true;
                    price += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    trashedMouse = true;
                    price += mousePrice;

                    if (trashedHeadset == true && trashedMouse == true)
                    {
                        count++;
                        price += keyboardPrice;

                        if (count % 2 == 0)
                        {
                            price += displayPrice;
                        }
                    }
                }
            }

            Console.WriteLine($"Rage expenses: {price:f2} lv.");
        }
    }
}