using System;

namespace AbstractClass // Note: actual namespace depends on the project name.
{
    abstract class Animal
    {
        //abstract method
        public abstract void makeSound();
    }

    //inheriting from abstract class
    class Dog : Animal
    {
        //provide implementation of abstract method
        public override void makeSound(){

        Console.WriteLine("Bark Bark");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of Dog class
            Dog obj = new Dog();
            obj.makeSound();

            Console.ReadLine();
        }
    }
}