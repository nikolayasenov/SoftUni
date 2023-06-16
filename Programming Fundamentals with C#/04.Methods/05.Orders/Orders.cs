namespace _05.Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            CalculatePrice(product, quantity);
        }

        private static void CalculatePrice(string product, int quantity)
        {
            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.50 * quantity;
                    break;
                case "water":
                    price = 1.0 * quantity;
                    break;
                case "coke":
                    price = 1.40 * quantity;
                    break;
                case "snacks":
                    price = 2.00 * quantity;
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}