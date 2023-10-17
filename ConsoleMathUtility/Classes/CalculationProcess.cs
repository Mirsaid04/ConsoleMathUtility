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
        public void AddListOfNumbers()
        {
            int sum = 0;
            string[] numbers;
            Console.Write("Please enter the number separeted with { , } :  ");
            numbers = Console.ReadLine().Split(",");

            foreach (var number in numbers)
            {
                sum += Convert.ToInt32(number);
            }

            Console.WriteLine($"Answer is {sum}");
        }
    }
}
