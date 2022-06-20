using System;

namespace AbstractClass // Note: actual namespace depends on the project name.
{
    abstract class Animal
    {
        protected string name;

        //abstract method
        public abstract string Name{get; set;}

    }

    //inheriting from abstract class
    class Dog : Animal
    {
        //provide implementation of abstract method
        public override string Name {get {return name;} set {name = value;} }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of Dog class
            Dog obj = new Dog();
            obj.Name = "Tom";
            Console.WriteLine("Name: " + obj.Name);;

            Console.ReadLine();
        }
    }
}