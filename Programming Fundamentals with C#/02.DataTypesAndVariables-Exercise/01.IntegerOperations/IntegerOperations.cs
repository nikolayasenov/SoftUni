namespace _01.IntegerOperations
{
    internal class IntegerOperations
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());

            int addOneToTwo = numberOne + numberTwo;
            int divideAddByThree = addOneToTwo / numberThree;
            int multiplyDivideByFour = divideAddByThree * numberFour;
            Console.WriteLine(multiplyDivideByFour);
        }
    }
}