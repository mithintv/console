using System;
using System.Globalization;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{

    // We focus on Generic Collections, Generic Methods, Generic Structs, and more on Delegates
    public class Program
    {

        static void Main(string[] args)
        {

            // Generic collections are type safe and provide performance benefits

            // You define the data type when defining the generic. This is a dynamically resizing collection
            List<Animal> animalList = new List<Animal>();

            // You can also create a list of standard types like int
            List<int> numList = new List<int>();

            // Add an int
            numList.Add(24);

            // Add Animals
            animalList.Add(new Animal() { Name = "Doug", });
            animalList.Add(new Animal() { Name = "Paul", });
            animalList.Add(new Animal() { Name = "Sally", });

            // Insert in index 1
            animalList.Insert(1, new Animal() { Name = "Steve", });
            // Remove index 1
            animalList.RemoveAt(1);

            // Get number of Animals
            Console.WriteLine("Num of Animals : {0}", animalList.Count);

            // Cycle through Animals
            foreach (Animal a in animalList)
            {
                Console.WriteLine(a.Name);
            }

            // You can also use Stack<T>, Queue<T>, Dictionary<TKey, TValue> like I covered previously

            // Generic methods
            // You can use the type parameter <int>  if it can be inferred from the parameters  passed (Can't do this if there are no parameters)
            int x = 5, y = 4;
            Animal.GetSum<int>(ref x, ref y);
            string strX = "5", strY = "4";
            Animal.GetSum<string>(ref strX, ref strY);

            // Use the generic struct
            Rectangle<int> rec1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rec1.GetArea());
            Rectangle<string> rec2 = new Rectangle<string>("20", "50");
            Console.WriteLine(rec2.GetArea());
        }

        public struct Rectangle<T>
        {
            private T width;
            private T length;

            public T Width
            {
                get { return width; }
                set { width = value; }
            }

            public T Length
            {
                get { return length; }
                set { length = value; }
            }

            public Rectangle(T w, T l)
            {
                width = w;
                length = l;
            }

            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(Width);
                double dblLength = Convert.ToDouble(Length);
                return string.Format($"{Width} * {Length} = {dblWidth} * {dblLength}");
            }
        }
    }
}
