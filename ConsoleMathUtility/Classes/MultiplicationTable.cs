namespace ConsoleMathUtility.Classes
{
    internal class MultiplicationTable
    {
        public void Multiplicator()
        {
            Console.Write("Enter the firstNumber: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the secondNumber: ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            for(int outerIteration = firstNumber; outerIteration < SecondNumber; outerIteration++)
            {
                Console.WriteLine("      ");

                for(int innerIteration = 10 ; innerIteration <= 20; innerIteration++)
                {
                    Console.WriteLine($"{outerIteration}*{innerIteration}={outerIteration * innerIteration}");
                }
            }
        }
    }
}
