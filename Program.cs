namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ----- STREAMWRITER / STREAMREADER -----
            // These are best for reading and writing strings

            string textFilePath = @"C:\Users\mithi\c#data\testfile3.txt";

            // Create a text file
            StreamWriter sw = new StreamWriter(textFilePath);

            // Write to a file without a newline
            sw.Write("This is a random ");

            // Write to a file with a newline
            sw.WriteLine("sentence");

            // Write another
            sw.WriteLine("This is another sentence.");

            // Close the StreamWriter
            sw.Close();

            // Open the file for reading
            StreamReader sr = new StreamReader(textFilePath);

            // Peek returns the next character as a unicode number. Use Convert to change to a character
            Console.WriteLine($"Peek : {Convert.ToChar(sr.Peek())}");

            // Read to a newline
            Console.WriteLine($"1st String : {sr.ReadLine()}");

            // Read to the end of the file starting where you left off reading
            Console.WriteLine($"Everything Else : {sr.ReadToEnd()}");
        }
    }
}
