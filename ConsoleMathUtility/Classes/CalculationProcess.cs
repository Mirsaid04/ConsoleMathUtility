using static System.Net.Mime.MediaTypeNames;

namespace ConsoleMathUtility.Classes
{
    internal class CalculationProcess
    {
        public void AddTwoNumbers()
        {
            Console.Write("\nEnter the firstNumber: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the secondNumber: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            Console.WriteLine($"Answer is {sum}",0);
        }
        public static int AddListOfNumbers(string nums)
        {
            int[] provider = nums.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            return provider.Sum();
        }
    }
}
