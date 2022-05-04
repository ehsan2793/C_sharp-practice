using System;

namespace InheritanceChallenge
{
    public class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            Name = "Rahimi";
            FirstName = "ehsan";
            Salary = 1000;
        }

        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public virtual void WorK()
        {
            Console.WriteLine("I am working");
        }

        public void Pause()
        {
            Console.WriteLine("I am having a break");
        }
    }
}