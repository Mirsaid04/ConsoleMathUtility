namespace ConsoleMathUtility.Classes
{
    internal class ValueManipulator
    {
        public void ShowMenu()
        {
            Console.WriteLine("Welcome to my Calculator Application.\n______Menu______n");
            Console.Write("1.Add two numbers \n2.Add list of numbers. \n3.Multiplication Table. \n4.Choice: ");
        }

        public void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You entered Invalid input, please try again");
            Console.ResetColor();
        }
    }
}
