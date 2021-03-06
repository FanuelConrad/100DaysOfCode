using System;

namespace Inheritance // Note: actual namespace depends on the project name.
{
    //base class
    class Animal
    {
        //'virtual' allows the method to be overridden by the derived class 
        public virtual void eat(){
            Console.WriteLine("I eat food");
        }
    }

    //derived class of Animal
    class Dog : Animal
    {
        //overriding method from Animal
        //'override' indicates the method is overriding the method from the base class
        public override void eat(){
            Console.WriteLine("I eat Dog food");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //object of derived class
            Dog labrador = new Dog();

            //accesses overridden method
            labrador.eat();
        }
    }
}