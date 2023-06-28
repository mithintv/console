using System;

namespace ConsoleApp
{
    class Animal
    {

        private string name = "No Name";
        private string sound = "No Sound";


        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        // Added virtual so that this method can be overridden by subclasses
        // You must add override to the method in the subclass
        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }

        // Capabilities (methods) that all Animals have
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }


        public Animal() : this("No Name", "No Sound") { }
        public Animal(string name) : this(name, "No Sound") { }
        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name
        {
            get { return name; }
            set
            {
                // value is assigned the value passed in
                if (value.Any(char.IsDigit))
                {
                    name = "No Name";
                    Console.WriteLine("Can't use numbers in name");
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                // value is assigned the value passed in
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                else
                {
                    sound = value;
                }
            }
        }


        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;

            }
        }
        // You can have the getters and setters generated for you like this and also set the default value
        public string Owner { get; set; } = "No Owner";


    }


}
