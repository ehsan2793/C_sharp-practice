using System;

namespace Iheritance_interface
{
    public class Chair : Furniture ,IDestroy
    {
        public string DestructionSound { get; set; }

        public Chair(string color , string material )
        {
            Color = color;
            Material = material;
            DestructionSound = "ChairDestruction.mp3";

        }


     
        public void Destroy()
        {
            Console.WriteLine($"the {Color} chair was destroyed");
            Console.WriteLine($"playing Destruction sound {DestructionSound}");
            Console.WriteLine("spawning chair parts");
        }
    }
}