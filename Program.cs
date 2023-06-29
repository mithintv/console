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

            // Collections can resize unlike arrays
            // ---------- ARRAYLISTS ----------

            // #region provides a way to collapse long blocks of code
            #region ArrayList Code

            // ArrayLists are resizable arrays that can hold multiple data types
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);

            // Number of items in list
            Console.WriteLine("Count : {0}", aList.Count);

            // The capacity automatically increases as items are added
            Console.WriteLine("Capacity : {0}", aList.Capacity);


            ArrayList aList2 = new ArrayList();
            // Add an object array
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });
            aList.AddRange(aList2);


            // You can sort the list if the types are the same
            aList2.Sort();
            aList2.Reverse();

            // Insert at the 2nd position
            aList2.Insert(1, "Turkey");

            // Get the first 2 items
            ArrayList range = aList2.GetRange(0, 2);

            // Remove the first item
            aList.Remove(0);
            // Remove the 1st 2 items
            aList.RemoveRange(0, 2);

            // Search for a match starting at the provided index. You can also find the last index with LastIndexOf
            Console.WriteLine("Turkey Index : {0}", aList2.IndexOf("Turkey", 0));


            // Cycle through the list
            foreach (object o in aList)
            {
                Console.WriteLine(o);
            }


            // Convert an ArrayList into a string array
            string[] myArray = (string[])aList.ToArray(typeof(string));
            Console.WriteLine(myArray);

            // Convert a string array into an ArrayList
            string[] customers = { "Bob", "Sally", "Sue" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customers);

            #endregion
        }
    }
}
