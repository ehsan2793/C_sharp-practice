using System;
using System.Collections.Generic;

namespace Iheritance_interface
{
    public class Car : Vehical ,IDestroy
    {
        public string DestructionSound { get; set; }
        public List<IDestroy> DestroyNearby;

        
        public Car(float speed , string color)
        {
            Speed = speed;
            Color = color;
            DestructionSound = "CarExploadSound.mp3";
            DestroyNearby = new List<IDestroy>();
        }

        public void Destroy()
        {
            Console.WriteLine($"play Destruction Sound {DestructionSound } ");
            Console.WriteLine("create Fire");

            foreach (IDestroy destroyable in DestroyNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}