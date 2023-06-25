using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ------ CONSOLE METHODS -----
            // Change the text color in the console
            Console.ForegroundColor = ConsoleColor.Black;

            // Change background color
            Console.BackgroundColor = ConsoleColor.White;

            // Set background for whole console
            Console.Clear();

            // Prints Hello World on the console
            Console.WriteLine("Hello World!");
        }
    }
}
