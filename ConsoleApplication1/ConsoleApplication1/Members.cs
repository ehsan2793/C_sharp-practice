using System;

namespace ConsoleApplication1
{
    public class Members
    {
        //private Field
        private string memberName;
        private string jobTitle;
        private int salary;
        
        // member = public field
        public int age;
        
        // property expose jobTitle safely
        
        public string JobTitle
        {
            get => jobTitle;
            set => jobTitle = value;
        }
        
        // public method
        public void Interduce(bool isfried)
        {
            if (isfried)
            {
                SharingInfo();
            }
            else
            {
                Console.WriteLine($"Hi my name is{memberName} and I am {age} years old");
            }
        }
        
        // private method

        private void SharingInfo()
        {
            Console.WriteLine($"my salary is {salary}");
        }
        
        // member constructor 
        public Members(string name, string job , int salary , int age)
        {
            
        this.memberName = name;
        this.jobTitle = job;
        this.salary = salary;
        this.age = age;
        Console.WriteLine("member created");
        }
        
        // member - finalizer - destructor
        ~Members()
        {
            Console.WriteLine("destructor of member object");
        }
        
        
    }
}