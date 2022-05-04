using System;

namespace Iheritance_interface
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Chair chair1 = new Chair("red", "wood");
            Chair chair2 = new Chair("blue", "pastic");
           
            Car car1 = new Car(100.923f, "red Orange");
            car1.DestroyNearby.Add(chair1);
            car1.DestroyNearby.Add(chair2);
            
            car1.Destroy();
        }
    }
}