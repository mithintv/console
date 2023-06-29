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
            // ---------- STACKS ----------
            #region Queue Code
            // Stack Last in 1st Out Collection

            // Create a stack
            Stack stack = new Stack();

            // Put items on the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Get but don't remove item
            Console.WriteLine("Peek 1 : {0}", stack.Peek());

            // Remove item
            Console.WriteLine("Remove 1 : {0}", stack.Pop());

            // Does item exist on stack
            Console.WriteLine("Contain 1 : {0}", stack.Contains(1));

            // Copy stack to array
            object?[] numArray = stack.ToArray();

            // Print array
            Console.WriteLine(String.Join(",", numArray));

            // Print the stack
            foreach (object o in numArray)
            {
                Console.WriteLine($"Stack : {o}");
            }

            #endregion
        }
    }
}
