using System;
using System.Globalization;
using System.Text;

// This time we cover Abstract Classes, Abstract Methods, Base Classes, Is, As, Casting and more about Polymorphism

namespace ConsoleApp
{
    public class Program
    {

        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powBut = new PowerButton(TV);

            powBut.Execute();
            powBut.Undo();
            powBut.Execute();
            powBut.Undo();
        }
    }
}
