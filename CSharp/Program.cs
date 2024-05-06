using System.Text.Json;
using System.Xml.Serialization;

namespace CSharp
{
    public class Program
    {

        static void Main(string[] args)
        {
            Animal? bowser = new Animal("Bowser", 45, 25, 1);

            // Serialize the object data to a file
            Stream stream = File.Open(@"C:\Users\mithi\c#data\AnimalData.dat", FileMode.Create);

            // Send the object data to the file

            // Binary Serialization is no longer supported
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(stream, bowser);

            JsonSerializer.Serialize(stream, bowser);
            stream.Close();

            // Delete the bowser data
            bowser = null;

            // Read object data from the file
            stream = File.Open(@"C:\Users\mithi\c#data\AnimalData.dat", FileMode.Open);

            // Binary Serialization is no longer supported
            //bf = new BinaryFormatter();
            //bowser = (Animal)bf.Deserialize(stream);

            bowser = JsonSerializer.Deserialize<Animal>(stream);
            stream.Close();

            Console.WriteLine(bowser?.ToString());

            bowser!.Weight = 50;

            // XmlSerializer writes object data as XML. Make sure you have a c#data folder
            XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(@"C:\Users\mithi\c#data\bowser.xml"))
            {
                serializer.Serialize(tw, bowser);
            };


            // Delete bowser data
            bowser = null;

            // Deserialize from XML to the object
            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            TextReader? reader = new StreamReader(@"C:\Users\mithi\c#data\bowser.xml");
            object? obj = deserializer.Deserialize(reader);
            bowser = (Animal?)obj;

            Console.WriteLine(bowser?.ToString());


            // Save a collection of Animals
            List<Animal>? theAnimals = new List<Animal> {
            new Animal("Mario", 60, 30, 2),
            new Animal("Luigi", 55, 24, 3),
            new Animal("Peach", 40, 20, 4),
            };

            using (Stream fs = new FileStream(@"C:\Users\mithi\c#data\animals.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, theAnimals);
            };

            // Delete list data
            theAnimals = null;

            // Read data from XML
            XmlSerializer? deserializer2 = new XmlSerializer(typeof(List<Animal>));
            using (FileStream? fs2 = File.OpenRead(@"C:\Users\mithi\c#data\animals.xml"))
            {
                theAnimals = (List<Animal>?)deserializer2.Deserialize(fs2);
            };
            foreach (Animal a in theAnimals!)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}
