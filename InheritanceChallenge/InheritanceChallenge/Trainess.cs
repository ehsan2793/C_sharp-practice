using System;

namespace InheritanceChallenge
{
    public class Trainess : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainess( string name , string firstName ,int salary, int workingHours , int schoolHours)
        {
           
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public  void Learn()
        {
            Console.WriteLine("i cant learn shit if i dont money");
        }

        public override void WorK()
        {
            Console.WriteLine("i dont know how to work");
        }
    }
}