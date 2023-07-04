using System.Text;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ----- FILESTREAMS -----
            // FileStream is used to read and write a byte or an array of bytes. 

            string textFilePath = @"C:\Users\mithi\c#data\testfile2.txt";

            // Create and open a file
            FileStream fs = File.Open(textFilePath, FileMode.Create);

            string randString = "This is a random string";

            // Convert to a byte array
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            // Write to file by defining the byte array, the index to start writing from, and length
            fs.Write(rsByteArray, 0, rsByteArray.Length);

            // Move back to the beginning of the file
            fs.Position = 0;

            // Create byte array to hold file data
            byte[] fileByteArray = new byte[rsByteArray.Length];

            // Put bytes in array
            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            // Convert from bytes to string and output
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            // Close the FileStream
            fs.Close();
        }
    }
}
