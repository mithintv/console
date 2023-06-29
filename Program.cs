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

            // ---------- DICTIONARIES ----------
            #region Dictionary Code

            // Dictionaries store key value pairs to create them define the data type for the key and the value
            Dictionary<string, string> superheroes = new Dictionary<string, string>();
            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry Allen", "The Flash");

            // Remove a key / value
            superheroes.Remove("Barry Allen");

            // Number of keys
            Console.WriteLine("Count : {0}", superheroes.Count);

            // Check if a key is present
            Console.WriteLine("Clark Kent: {0}", superheroes.ContainsKey("Clark Kent"));

            // Get the value for the key and store it in a string
            superheroes.TryGetValue("Clark Kent", out string? test);
            Console.WriteLine($"Clark Kent : {test}");

            // Cycle through key value pairs
            foreach (KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

            // Clear a dictionary
            superheroes.Clear();

            #endregion
        }
    }
}
