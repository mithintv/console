using System;
using System.Globalization;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    // This time I'll cover multiple functions you can use to work with lists of data including Lambda, Where, ToList, Select, Zip, Aggregate and Average
    public class Program
    {
        // Delegate that is assigned a Lambda expression
        delegate double doubleIt(double val);

        static void Main(string[] args)
        {
            // Like we did with predicates earlier Lambda expressions allow you to use anonymous methods that define the input parameters on the left and the code to execute on the right
            doubleIt dblIt = x => x * 2;
            Console.WriteLine($"5 * 2 = {dblIt(5)}");

            // You don't have to use delegates though. Here we'll search through a list to find all the even numbers
            List<int> numList = new List<int> { 1, 9, 2, 6, 3 };

            // Put the number in the list if the condition is true
            var evenList = numList.Where(a => a % 2 == 0).ToList();
            foreach (var j in evenList) Console.WriteLine(j);

            // Add values in a range to a list
            var rangeList = numList.Where(x => (x > 2) || (x < 9)).ToList();
            foreach (var j in rangeList) Console.WriteLine(j);

            // Find the number of heads and tails in a list 1 = H, 2 = T

            // Generate our list
            List<int> flipList = new List<int>();
            int i = 0;
            Random rnd = new Random();
            while (i < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;
            }

            // Print out the heads and tails
            Console.WriteLine("Heads : {0}", flipList.Where(a => a == 1).ToList().Count());
            Console.WriteLine("Tails : {0}", flipList.Where(a => a == 2).ToList().Count());

            // Find all names starting with s
            var nameList = new List<string> { "Doug", "Sally", "Sue" };
            var sNameList = nameList.Where(x => x.StartsWith("S"));
            foreach (var m in sNameList) Console.WriteLine(m);
        }
    }
}
