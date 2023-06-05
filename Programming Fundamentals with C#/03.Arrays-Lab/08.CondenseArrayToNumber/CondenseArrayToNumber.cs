namespace _08.CondenseArrayToNumber
{
    internal class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] nums = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            while (nums.Length > 1)
            {
                int[] condense = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {

                    condense[i] = nums[i] + nums[i + 1];
                }
                nums = condense;
            }

            Console.WriteLine(nums[0]);
        }
    }
}