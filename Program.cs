namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ----- MESSING WITH DIRECTORIES -----

            // Get access to the current directory
            DirectoryInfo currDir = new DirectoryInfo(".");

            // Get access to a directory with a path
            DirectoryInfo customDir = new DirectoryInfo(@"C:/Users/mithi");

            // Get the directory path
            Console.WriteLine(currDir.FullName);
            Console.WriteLine(customDir.FullName);

            // Get the directory name
            Console.WriteLine(customDir.Name);

            // Get the parent directory
            Console.WriteLine(customDir.Parent);

            // What type is it
            Console.WriteLine(customDir.Attributes);

            // When was it created
            Console.WriteLine(customDir.CreationTime);

            // Create a directory
            DirectoryInfo dataDirectory = new DirectoryInfo(@"C:/Users/mithi/c#data");
            dataDirectory.Create();

            // Delete a directory
            //Directory.Delete(@"C:/Users/mithi/c#data\");


            // ----- SIMPLE FILE READING & WRITING -----

            // Write a string array to a text file
            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };
            string textFilePath = @"C:\Users\mithi\c#data\textfile1.txt";

            // Write the array
            File.WriteAllLines(textFilePath, customers);

            // Read strings from array
            foreach (string customer in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {customer}");
            }


            // ----- GETTING FILE DATA -----

            DirectoryInfo myDataDir = new DirectoryInfo(@"C:/Users/mithi/c#data");

            // Get all txt files 
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            // Number of matches
            Console.WriteLine($"Matches : {txtFiles.Length}");

            foreach (FileInfo file in txtFiles)
            {
                // Get file name
                Console.WriteLine(file.Name);

                // Get bytes in file
                Console.WriteLine(file.Length);
            }
        }
    }
}
