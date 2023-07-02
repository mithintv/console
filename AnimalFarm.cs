using System.Collections;

namespace ConsoleApp
{
    // IEnumerable provides for iteration over a collection
    class AnimalFarm : IEnumerable
    {
        // Holds list of Animals
        private List<Animal> animalList = new List<Animal>();

        // Indexer for AnimalFarm created with this[]
        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }

        public AnimalFarm() { }

        public Animal this[int index]
        {
            get
            {
                return (Animal)animalList[index];
            }
            set
            {
                animalList.Insert(index, value);
            }
        }

        // Returns the number of values in the collection
        public int Count
        {
            get { return animalList.Count; }
        }

        // Returns an enumerator that is used to iterate through the collection
        public IEnumerator GetEnumerator()
        {
            return animalList.GetEnumerator();
        }
    }
}
