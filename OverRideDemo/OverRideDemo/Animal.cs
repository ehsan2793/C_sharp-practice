using System;

namespace OverRideDemo
{
    public class Animal
    {
        //name age is hungry

        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Age = age;
            Name = name;
            IsHungry = true;
        }

        public virtual void MakeSound()
        {
          
        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is Eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}