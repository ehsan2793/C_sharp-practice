using System;

namespace InheritanceChallenge
{
    public class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string name , string firstName ,int salary , string companyCar)
        {
            CompanyCar = companyCar;
        }
        public  void Lead()
        {
            Console.WriteLine("I am the fucking boss");
        }

        public override void WorK()
        {
            Console.WriteLine("I am the boss I dont need to work fuck you");
        }

       
    }
}