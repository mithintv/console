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

        // ----- Lock Example -----
        // lock keeps other threads from entering a statement block until another thread leaves
        static void Main(string[] args)
        {
            BankAcct acct = new BankAcct(10);
            Thread[] threads = new Thread[15];

            // CurrentThread gets you the current executing thread
            Thread.CurrentThread.Name = "main";

            // Create 15 threads that will call for IssueWithdraw to execute
            for (int i = 0; i < 15; i++)
            {
                // You can only point at methods  without arguments and that return nothing
                Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }

            // Have threads try to execute
            for (int i = 0; i < 15; i++)
            {
                // Check if thread has started
                Console.WriteLine($"Thread {threads[i].Name} Alive : {threads[i].IsAlive}");

                // Start thread
                threads[i].Start();

                // Check if thread has started
                Console.WriteLine($"Thread {threads[i].Name} Alive : {threads[i].IsAlive}");
            }

            // Get thread priority (Normal Default) There's also Lowest, BelowNormal, AboveNormal nand Highest
            // Changing priority doesn't guarantee the highest precedence though. It is best to not mess with this
            Console.WriteLine($"Current Priority : {Thread.CurrentThread.Priority}");
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} Ending");
        }
    }
}
