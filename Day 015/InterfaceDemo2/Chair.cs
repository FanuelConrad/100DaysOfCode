using System;
using System.Collections.Generic;
namespace InterfaceDemo2
{
    class Chair : Furniture, IDestroyable
    {
        //implementing the interface's property
        public string DestructionSound{get;set;}

        //simple constructor
        public Chair(string colour, string material)
        {
            this.Color=colour;
            this.Material=material;
            //initializing the interface's property with a value in the constructor
            DestructionSound="ChairDestructionSound.mp3";
        }
        //implementing the interface's method
        public void Destroy()
        {
            //when a chair gets destroyed we should play the destruction sound and spawn the destroyed chairs
            System.Console.WriteLine($"The {Color} chair was destroyed");
            System.Console.WriteLine("Playing the destruction sound {0}",DestructionSound);
            System.Console.WriteLine("Spawning chair parts");
        }
    }
}