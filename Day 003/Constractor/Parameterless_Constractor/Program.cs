using System;

namespace Parameterless_Constructor // Note: actual namespace depends on the project name.
{
    class Car
    {
        //parameterless constructor
        Car(){
            Console.WriteLine("Car Constructor");
        }
        static void Main(string[] args)
        {
            //call constructor
            new Car();
            Console.ReadLine();
        }
    }
}