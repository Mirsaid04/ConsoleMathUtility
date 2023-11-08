namespace ConsoleMathUtility.Classes
{
    internal class Math
    {
        public void Calculate()
        {
            double baseNumber, powerNumber;

            Console.Write("Enter base number :");
            baseNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter exponent number :");
            powerNumber = Convert.ToDouble(Console.ReadLine());

            double returnNumber = System.Math.Pow(baseNumber, powerNumber);
            Console.WriteLine("{0}^{1} = {2}", baseNumber, powerNumber, returnNumber);
        }
    }
}
