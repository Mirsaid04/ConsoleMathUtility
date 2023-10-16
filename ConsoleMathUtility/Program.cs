using ConsoleMathUtility.Classes;

namespace ConsoleMathUtility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yesOrNo = " ";
            do
            {
                ValueManipulator report = new ValueManipulator();
                CalculationProcess Calculate = new CalculationProcess();
                MultiplicationTable showTable = new MultiplicationTable();

                report.ShowMenu();

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Calculate.AddTwoNumbers();
                        break;

                    case 2:
                        int result = Calculate.AddListOfNumbers(1, 2, 3, 4);
                        Console.WriteLine($"Entered 1,2,3,4\nThe answer is {result}");
                        break;

                    case 3:
                        showTable.Multiplicator();
                        break;

                    default:
                        report.Error();
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you want to continue : [y/n]");
                yesOrNo = Console.ReadLine()!;
                Console.ResetColor();

            }while(yesOrNo == "y");
        }
    }
}