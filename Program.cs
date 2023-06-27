using System;
using System.Globalization;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            // ---------- FORMATTING OUTPUT ----------

            // Format output for currency
            Console.WriteLine("Currency : {0:c}", 23.455);

            // Pad with zeroes
            Console.WriteLine("Pad with 0s : {0:d4}", 23);

            // Define decimals
            Console.WriteLine("3 Decimals : {0:f3}", 23.4555);

            // Add commas and decimals
            Console.WriteLine("Commas : {0:n4}", 2300);
        }
    }
}
