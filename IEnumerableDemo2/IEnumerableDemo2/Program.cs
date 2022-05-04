using System;
using System.Collections.Generic;

namespace IEnumerableDemo2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
 
            List<int> numberList = new List<int> { 1, 2, 3, 4, 5 };
            int[] numberarr = { 6, 7, 8, 9, 10 };
            Queue<int> queueNumbers = new Queue<int>();
            for (int i = 0; i < 4; i++)
            {
                int num = 11;
                queueNumbers.Enqueue(num);
                num++;

            }
            Collectionsum(numberList);
            Collectionsum(numberarr);
            Collectionsum(queueNumbers);



        }

        static void Collectionsum(IEnumerable<int> anyCollection)
        {
            int sum = 0;
            foreach (int num in anyCollection)
            {
                sum += num;
                Console.Write(sum + " ");
            }

            Console.WriteLine("");

            
        }
    }
}