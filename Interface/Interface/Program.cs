using System;

namespace Interface
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Ticket ticket1 = new Ticket(10);
            Ticket ticket2 = new Ticket(10);
            Console.WriteLine(ticket1.Equals(ticket1));
        }
    }
}