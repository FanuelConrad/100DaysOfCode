using System;

namespace Accessing_class_members_using_objects // Note: actual namespace depends on the project name.
{
    class Dog
    {
        string breed;

        public void bark(){
            Console.WriteLine("Bark Bark!!");
        }
        static void Main(string[] args)
        {
            //create new dog object
            Dog bullDog=new Dog();

            //access breed of the Dog
            bullDog.breed="Bull Dog";
            Console.WriteLine(bullDog.breed);

            //access method of the Dog
            bullDog.bark();

            Console.ReadLine();
        }
    }
}