using System;

namespace OverRideDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dog henrey = new  Dog("Henrey", 2);
            henrey.MakeSound();
            henrey.Play();
            henrey.Eat();

            Console.WriteLine($"{henrey.Name} and {henrey.Age}");
        }
    }
}