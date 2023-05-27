namespace _09.PadawanEquipment
{
    internal class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = float.Parse(Console.ReadLine());
            double totalPrice = 0;
            double totalLightsabersPrice = (Math.Ceiling(students * 1.10)) * lightsaberPrice;
            double totalRobePrice = students * robePrice;
            double totalBeltPrice = (students - (students / 6)) * beltPrice;

            totalPrice = totalLightsabersPrice + totalRobePrice + totalBeltPrice;
            double neededMoney = Math.Abs(totalPrice - money);
            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }

        }
    }
}