using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp
{
    public class Program
    {
        // ---------- FUNCTIONS / METHODS ----------
        // Functions are used to avoid code duplication, provides organization and allows use to simulate different systems
        // <Access Specifier> <Return Type> <Method Name>(Parameters)
        // { <Body> }

        // Access Specifier determines whether the function can be called from another class
        // public : Can be accessed from another class
        // private : Can't be accessed from another class
        // protected : Can't be accessed by another class but can by derived classes

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }

        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in zip code {1}", name, zipCode);
        }

        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }

        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }


        // -------- END OF FUNCTIONS --------
        static void Main(string[] args)
        {
            // SayHello();


            // ----- PASSING BY VALUE -----
            // By default values are passed into a method and not a reference to the variable passed
            // Changes made to those values do not effect the variables outside of the method
            double x = 5;
            double y = 4;

            Console.WriteLine("5 + 4 = {0}", GetSum(x, y));

            // Even though the value for x changed in method it remains unchanged here
            Console.WriteLine("x = {0}", x);


            // ----- OUT PARAMETER -----
            // You can pass a variable as an output variable even without assigning a value to it

            int solution;

            // A parameter passed with out has its value assigned in the method
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);


            // ----- PASS BY REFERENCE -----
            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap num1: {0} num2: {1}", num3, num4);
            Swap(ref num3, ref num4);
            Console.WriteLine("After Swap num1: {0} num2: {1}", num3, num4);

            // ----- PARAMS -----
            // You are able to pass a variable amount of data of the same data type into a  method using params. You can also pass in an array.
            Console.WriteLine("1 + 2 + 3 = {0}", GetSumMore(1, 2, 3));


            // ----- NAMED PARAMETERS -----
            // You can pass values in any order if you used named parameters
            PrintInfo(zipCode: 15147, name: "Derek Banas");


            // ----- METHOD OVERLOADING -----
            // You can define methods with the same name that will be called depending on what data is sent automatically
            Console.WriteLine("5.0 + 4.0 = {0}", GetSum2(5.0, 4.5));
            Console.WriteLine("5.0 + 4.0 = {0}", GetSum2("5.0", "4.5"));
        }
    }
}
