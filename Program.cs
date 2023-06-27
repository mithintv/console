using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ---------- DATA TYPE CONVERSION ----------

            // You can convert from string to other types with Parse
            bool boolFromStr = bool.Parse("True");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");
            Console.WriteLine($"{boolFromStr}: {boolFromStr.GetType()}");
            Console.WriteLine($"{intFromStr}: {intFromStr.GetType()}");
            Console.WriteLine($"{dblFromStr}: {dblFromStr.GetType()}");

            // Convert double into a string
            string strVal = dblFromStr.ToString();

            // Get the new data type
            Console.WriteLine($"Data type : {strVal.GetType()}");

            // Cast double into integer (Explicit Conversion)
            // Put the data type to convert into between ()
            double dblNum = 12.345;
            Console.WriteLine($"Integer : {(int)dblNum}");

            // Cast integer into long (Implicit Conversion)
            // smaller size type to a larger size
            int intNum = 10;
            long longNum = intNum;
        }
    }
}
