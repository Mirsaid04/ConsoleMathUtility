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
        public int AddListOfNumbers(params int[] numbers)
        {  
            int sum =0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}
