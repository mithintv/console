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
            // ---------- DATETIME & TIMESPAN ----------

            // Used to define dates
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of the Week: {0}", awesomeDate.DayOfWeek);

            // You can change values
            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("New Date : {0}", awesomeDate.Date);


            // TimeSpan
            // Used to define a time
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);

            // Change values
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New Time : {0}", lunchTime.ToString());
        }
    }
}
