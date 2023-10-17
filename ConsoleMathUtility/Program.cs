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
                        Console.Write("Please enter the number between \'comma\'(0,1) : ");
                        string nums = Console.ReadLine();
                        Console.WriteLine($"The answer is : {CalculationProcess.AddListOfNumbers(nums)}");
                        break;

                    case 3:
                        showTable.Multiplicator();
                        break;

                    default:
                        report.Error();
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Do you want to continue [y/n]: ");
                yesOrNo = Console.ReadLine()!;
                Console.ResetColor();

            }while(yesOrNo == "y");
        }
    }
}