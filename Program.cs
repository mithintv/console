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
        // ----- Sleep Example -----

        // With sleep() the thread is suspended for the designated amount of time
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(num);
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine("Thread Ends");
        }
    }
}
