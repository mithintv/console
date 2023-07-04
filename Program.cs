using System;
using System.Globalization;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    // With threads you can execute multiple pieces of code that share resources and data without corrupting it

    // You can't guarantee when a thread executes. You also must lock resources until a thread is done with them or you could corrupt them
    public class Program
    {
        // ----- Simple Thread Example -----
        static void Print1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(Print1);
            t.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }
        }
    }
}
