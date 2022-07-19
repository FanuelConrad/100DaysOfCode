using System;
using System.Collections.Generic;
using System.Collections;

namespace IEnumerableAndIEnumeratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter=new DogShelter();

            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }
    }

    class Dog
    {
        //the name of the dog
        public string Name{get;set;}
        //is this a naughty dog
        public bool IsNaughtyDog{get;set;}
        //simple constructor
        public Dog(string name, bool isNaughtyDog)
        {
            this.Name=name;
            this.IsNaughtyDog=isNaughtyDog;
        }

        //this method will print how many treats the dog received
        public void GiveTreat(int numberofTreats)
        {
            //print a message counting the number of treats and the name of the dog
            System.Console.WriteLine("Dog: {0} said wuoff {1} times!.", Name,numberofTreats);
        }
    }

    //a class named DogShelter this class contains a generic collection of type Dog 
    //objects of this class can't be used inside a for each loop because it lacks an implementation of the IEnumerable interface
    class DogShelter : IEnumerable<Dog>
    {
        //list of type List<Dog>
        public List<Dog>dogs;

        //this constructor will initialize the dogs list with some values
        public DogShelter()
        {
            //initialize the dogs list using the collection-initializer
            dogs=new List<Dog>()
            {
                new Dog("Casper",false),
                new Dog("Sif",true),
                new Dog("Oreo",false),
                new Dog("Pixel",false),

            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();

        }
    }
}