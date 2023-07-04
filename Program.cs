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
        // ----- Passing Data to Threads -----
        // You can pass arguments to a thread using a lambda expression

        static void CountTo(int maxNum, int threadNum)
        {
            for (int i = 0; i <= maxNum; i++)
            {
                Console.WriteLine($"{threadNum} :  {i}");
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(() => CountTo(10, 0));
            t.Start();

            new Thread(() =>
            {
                CountTo(5, 1);
            }).Start();
        }
    }
}
