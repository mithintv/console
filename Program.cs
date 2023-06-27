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


        // -------- END OF FUNCTIONS --------
        static void Main(string[] args)
        {
            // ------ ARRAYS ------
            // Arrays are just lists that can contain many values of the same data type. Each item is assigned a key starting at 0 and incrementing up from there

            // Define an array which holds 3 values
            // Arrays have fixed sizes
            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);


            // Create and fill array
            string[] customers = { "Bob", "Sally", "Sue" };

            // You can use var to create arrays, but the
            // values must be of the same type
            var employees = new[] { "Mike", "Paul", "Rick" };

            // Create an array of base objects which is the
            // base type of all other types
            object[] randomArray = { "Paul", 45, 1.234 };


            // GetType knows its true type
            Console.WriteLine("randomArray 0: {0}", randomArray[0].GetType());


            // Get number of items in array
            Console.WriteLine("Array Size 0 : {0}", randomArray.Length);


            // Use for loop to cycle through the array
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Index : {0} // Value : {1}", i, randomArray[i]);
            }

            Console.WriteLine("-----------------------");


            // Cycle through the multidimensional array
            // Get length of multidimensional array column
            string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Smith" } };
            Console.WriteLine("MD Value: {0}", custNames.GetValue(1, 0));

            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int j = 0; j < custNames.GetLength(0); j++)
                {
                    Console.WriteLine("{0} ", custNames[i, j]);
                }
                Console.WriteLine();
            }

            int[] randNums = { 1, 4, 9, 2 };
            PrintArray(randNums, "ForEach");

            // Sort array
            Array.Sort(randNums);

            // Reverse array
            Array.Reverse(randNums);

            // Get index of match or return -1
            Console.WriteLine("At index 1 : {0}", Array.IndexOf(randNums, 1));

            // Change value at index 1 to 0
            randNums.SetValue(0, 1);


            // Copy part of an array to another
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray, 0, length);
            PrintArray(destArray, "Copy");


            // Create an array with CreateInstance
            Array anotherArray = Array.CreateInstance(typeof(int), 10);


            // Copy values in srcArray to destArray starting
            // at index 5 in destination
            srcArray.CopyTo(anotherArray, 5);
            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo: {0} ", m);
            }


            // Create Predicate to check against
            int[] numArray = { 1, 11, 22 };
            Predicate<int> GT10 = number => number > 10;
            Console.WriteLine("> 10 : {0}", Array.Find(numArray, GT10));
        }
    }
}
