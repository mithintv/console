﻿using System.Runtime.Serialization;


// With serialization you can store the state  of an object in a file stream, pass it to a remote network

namespace CSharp
{
    // Defines that you want to serialize this class
    [Serializable()]
    public class Animal : ISerializable
    {
        public string? Name { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public int? AnimalID { get; set; }

        public Animal() { }

        public Animal(
            string name = "No Name",
            double weight = 0,
            double height = 0,
            int animalID = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
            AnimalID = animalID;
        }

        public override string ToString()
        {
            return string.Format($"{Name} weighs {Weight} lbs and is {Height} inches tall");
        }

        // Serialization function (Stores Object Data in File)
        // SerializationInfo holds the key value pairs
        // StreamingContext can hold additional info but we aren't using it here
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
            info.AddValue("AnimalID", AnimalID);
        }

        // The deserialize function (Removes Object Data from File)
        public Animal(SerializationInfo info, StreamingContext context)
        {
            // Get the values from info and assign them to the properties
            Name = (string?)info.GetValue("Name", typeof(string));
            Weight = (double?)info.GetValue("Weight", typeof(double));
            Height = (double?)info.GetValue("Height", typeof(double));
            AnimalID = (int?)info.GetValue("AnimalID", typeof(int));
        }
    }
}
