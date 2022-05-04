using System;
using System.Collections.Generic;

namespace IEnumerableDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<int> unknowncollection;
            unknowncollection = GetCollection(2);
            foreach (int i in unknowncollection)
            {
                Console.Write(i + " bb ");
            }
        }


        static IEnumerable<int> GetCollection(int option)
        {

            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5 };
            Queue<int> numberQueue = new Queue<int>();
            numberQueue.Enqueue(6);
            numberQueue.Enqueue(7);
            numberQueue.Enqueue(8);
            numberQueue.Enqueue(9);
            numberQueue.Enqueue(10);

            if (option == 1)
            {
                return numberList;
            }

            else if (option == 2)
            {
                return numberQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }
            

        }
    }
}