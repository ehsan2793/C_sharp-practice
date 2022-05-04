using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;


namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Hashtable table = new Hashtable();
                // Dictionary<int, string> myDictionary = new Dictionary<int, string>()
                // {
                //     { 1, "ehsan" },
                //     {2,"arsa;an"},
                //     {3,"mom"},
                //     {4,"baba"}
                // };
                //
                // if (myDictionary.ContainsKey(1))
                // {
                //     myDictionary[1] = "jasem";
                // }
                //
                // for (int i = 0; i < myDictionary.Count; i++)
                // {
                //     KeyValuePair<int, string> keyValuePair = myDictionary.ElementAt(i);
                //     Console.WriteLine("{" + keyValuePair.Key+ " : " + keyValuePair.Value + "}");
                // }



                // Stack<int> stack = new Stack<int>();
                // int[] num = new int[] { 1,2,3,4,5,6};
                //
                // foreach (int n in num)
                // {
                //     stack.Push(n);
                // }
                //
                // while (stack.Count > 0)
                // {  
                //     Console.Write(stack.Pop());
                // }
                // {
                //    
                // }


                Queue<int> q = new Queue<int>();
                q.Enqueue(1);
                q.Enqueue(2);
                q.Enqueue(3);
                q.Enqueue(4);

                Console.WriteLine(q.Dequeue());
                Console.WriteLine(q.Dequeue());
                Console.WriteLine(q.Dequeue());
                Console.WriteLine(q.Dequeue());
         

        }
    }
}