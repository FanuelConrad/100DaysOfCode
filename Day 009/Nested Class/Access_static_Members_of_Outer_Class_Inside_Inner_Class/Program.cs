using System;

namespace CsharpNestedClass // Note: actual namespace depends on the project name.
{
    //outer class
    public class Car
    {
        //static member of outer class
        public static string brand = "Bugatti";

        //nested class
        public class Engine
        {
            public void display(){

                //access static member of outer class
                Console.WriteLine("Brand: " + Car.brand);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //object of inner class
            Car.Engine obj = new Car.Engine();
            obj.display();

            Console.ReadLine();
        }
    }
}