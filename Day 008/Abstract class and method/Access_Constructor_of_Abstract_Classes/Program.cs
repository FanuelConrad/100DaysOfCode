using System;

namespace AbstractClass // Note: actual namespace depends on the project name.
{
    abstract class Animal
    {
        public Animal(){
            Console.WriteLine("Animal Constructor");
        }
    }

    class Dog : Animal
    {
        public Dog(){
            Console.WriteLine("Dog Constructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //create an object of Dog class
            Dog d1 = new Dog();
            
            Console.ReadLine();
        }
    }
}