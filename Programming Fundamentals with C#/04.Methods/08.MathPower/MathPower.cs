namespace _08.MathPower
{
    internal class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = PowerOfNumber(number, power);
            Console.WriteLine(result);
        }
        static double PowerOfNumber(double number, int power)
        {
            return  Math.Pow(number, power);
        }
    }
}