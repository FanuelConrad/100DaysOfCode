using System;

namespace CsharpNestedClass // Note: actual namespace depends on the project name.
{
    //outer class
    class Computer
    {
        //nested class
        public class CPU
        {
            public void display(){
                Console.WriteLine("Method of CPU class");
            }
        }
    }

    //inheriting inner class
    class Laptop :Computer.CPU
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