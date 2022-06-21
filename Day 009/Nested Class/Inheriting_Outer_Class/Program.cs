using System;

namespace CsharpNestedClass // Note: actual namespace depends on the project name.
{
    //outer class
    class Computer
    {
        public void display(){
            Console.WriteLine("Method of Computer class");
        }

        //nested class
        public class CPU
        {
            
        }
    }

        class Laptop : Computer
        {
            
        }
    
    class Program
    {
        static void Main(string[] args)
        {
           //object of derived class
           Laptop obj = new Laptop();
           obj.display();

           Console.ReadLine();
        }
    }
}