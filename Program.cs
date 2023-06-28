using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp
{
    public class Program
    {

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
        }
        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }
        static void Main(string[] args)
        {
            // ----- ENUM -----
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);
        }
    }
}
