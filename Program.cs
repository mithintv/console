namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ----- BINARYWRITER / BINARYREADER -----
            // Used to read and write data types 
            string textFilePath = @"C:\Users\mithi\c#data\testfile4.txt";

            // Create file and retrieve it
            FileInfo datFile = new FileInfo(textFilePath);

            // Open the file
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            // Data to save to the file
            string randText = "Random Text";
            int myAge = 47;
            double height = 6.25;

            // Write data to a file
            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();

            // Open file for reading
            BinaryReader br = new BinaryReader(datFile.OpenRead());

            // Output data
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            br.Close();
        }
    }
}
