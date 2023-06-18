namespace _11.MathOperations
{
    internal class MathOperations
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int numberTwo = int.Parse(Console.ReadLine());
            double result = Calculate(numberOne, @operator, numberTwo);
            Console.WriteLine(result);

        }
        static double Calculate(int numberOne, string @operator, int numberTwo)
        {
            double result = 0;
            if (numberTwo !=0 )
            {
                switch(@operator)
                {
                case "/":
                    return numberOne / numberTwo;
                    break;
                case "*":
                    return numberOne * numberTwo;
                    break;
                case "+":
                    return numberOne + numberTwo;
                    break;
                case "-":
                    return numberOne - numberTwo;
                }
            }
            return result;


        }
    }
}