using ConsoleMathUtility.Classes;
using Math = ConsoleMathUtility.Classes.Math;

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
                Math math = new Math();

                report.ShowMenu();
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Calculate.AddTwoNumbers();
                        break;

                    case 2:
                        Calculate.AddListOfNumbers();
                        break;

                    case 3:
                        showTable.Multiplicator();
                        break;
                    case 4:
                        math.Calculate();
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