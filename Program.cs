using System;

namespace ConsoleApp
{
    public class Program
    {
        // -------- FUNCTIONS --------

        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }

        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }


        // -------- END OF FUNCTIONS --------
        static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleaning Up");
            }

        }
    }
}
