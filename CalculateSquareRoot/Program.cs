using System;
namespace CalculateSquareRoot
{
    class Program
    {
        private delegate double Mydelegate(double nguess, double num);
        private static double tolerance = 0.0001;
        static void Main(string[] args)
        {
            double num;
            Mydelegate f = null; // Declaring Lambda Function
            double initialGuess = 0.1; // Initial Guess
            f = (initial, val) => { // A Recursive Lambda Function Definition
                if (Math.Abs((initial*initial)-(val)) > tolerance) { return f((initial - ((initial * initial - (val)) / (2 * initial))), val); }
                else { return initial; }
            };
            Console.Write("Enter the number whose square root you need to find : ");
            if (Double.TryParse(Console.ReadLine(), out num) == false)
            { Console.WriteLine("You entered an invalid number"); }
            else { 
              if (num < 0) { Console.WriteLine("Cannot Find square root of a negative number."); }
              else { Console.WriteLine("Square root of " + num + " is : " + f(initialGuess, num)); }}
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}