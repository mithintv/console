using System;
using System.Globalization;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ---------- SELECT ----------
            // Select allows us to execute a function on each item in a list
            // Generate a list from 1 to 10
            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));
            var squares = oneTo10.Select(x => x * x);
            foreach (var l in squares) Console.WriteLine(l);


            // ---------- ZIP ----------
            // Zip applies a function to two lists
            // Add values in 2 lists together
            var listOne = new List<int>(new int[] { 1, 3, 4 });
            var listTwo = new List<int>(new int[] { 4, 6, 8 });
            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();
            foreach (var item in sumList) Console.WriteLine(item);


            // ---------- AGGREGATE ----------
            // Aggregate performs an operation on each item in a list and carries the results forward
            // Sum values in a list
            var numList1 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum {0}", numList1.Aggregate((a, b) => a + b));


            // ---------- AVERAGE ----------
            // Get the average of a list of values
            // AsQueryable allows you to manipulate the collection with the Average function
            Console.WriteLine("Avg {0}", numList1.AsQueryable().Average());


            // ---------- ALL ----------
            // Determines if all items in a list meet a condition
            Console.WriteLine("All > 3 {0}", numList1.All(x => x > 3));


            // ---------- ANY ----------
            // Determines if any items in a list meet a condition
            Console.WriteLine("Any > 3 {0}", numList1.Any(x => x > 3));


            // ---------- DISTINCT ----------
            // Eliminates duplicates from a list
            var numList5 = new List<int>() { 1, 2, 3, 2, 3 };
            Console.WriteLine("Distinct : {0}", String.Join(", ", numList5.Distinct()));


            // ---------- EXCEPT ----------
            // Receives 2 lists and returns values not found in the 2nd list
            var numList6 = new List<int>() { 3 };
            Console.WriteLine("Except : {0}", String.Join(", ", numList5.Except(numList6)));


            // ---------- INTERSECT ----------
            // Receives 2 lists and returns values that
            // both lists have
            Console.WriteLine("Intersect : {0}", String.Join(", ", numList5.Intersect(numList6)));
        }
    }
}
