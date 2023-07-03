using System;
using System.Globalization;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/*
We’ll learn about IEnumerable, Indexer, Enumerator, Operator Overloading, Custom Casting, Anonymous Types and more
*/


namespace ConsoleApp
{
    // Language Integrated Query (LINQ) provides many tools for working with data. LINQ is similar to SQL, but it can work with data aside from databases. You manipulate data using Query Expressions
    public class Program
    {

        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };

            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;

            foreach (int num in gt20)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine($"Get Type : {gt20.GetType()}");

            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            nums[0] = 40;
            foreach (int num in gt20)
            {
                Console.WriteLine(num);
            }
            return arrayGT20;
        }
        static void Main(string[] args)
        {
            string[] dogs = { "K9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Charlie B. Barkin", "Lassie", "Snoopy" };

            // Get strings with spaces and put in alphabetical order
            // from states where data comes from and where to store each piece as you cycle
            // where defines conditions that must be met
            // orderby defines what data is used for ordering results (ascending / descending)
            // select defines the variable that is checked against the condition
            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }


            int[] intArray = QueryIntArray();
            foreach (int num in intArray)
            {
                Console.WriteLine(num);
            }

            ArrayList famAnimals = new ArrayList()
            {
                new Animal {
                    Name = "Heidi",
                    Height = .8,
                    Weight = 18 },
                new Animal {
                    Name = "Shrek",
                    Height = 4,
                    Weight = 130 },
                new Animal {
                    Name = "Congo",
                    Height = 3.8,
                    Weight = 90 }
            };

            var famAnimalEnum = famAnimals.OfType<Animal>();

            var smAnimals = from animal in famAnimalEnum
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;
            foreach (var animal in smAnimals)
            {
                Console.WriteLine($"{animal.Name} weighs {animal.Weight}lbs");
            }

        }
    }
}
