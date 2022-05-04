using System.Collections;
using System.Collections.Generic;


namespace IenumerateAndEnumerator
{
  
    public class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Orlando", false),
                new Dog("Henry", false),
                new Dog("Jonny", true),
                new Dog("Max", true),
                new Dog("Helper", false),
            };
        }


        public IEnumerator<Dog> GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}