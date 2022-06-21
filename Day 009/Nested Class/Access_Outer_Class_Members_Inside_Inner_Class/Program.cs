using System;

namespace CsharpNestedClass // Note: actual namespace depends on the project name.
{
    //outer class
    public class Car
    {
        public string brand = "Bugatti";

        //nested class
        public class Engine
        {
            public void displayCar(){
                //object of outer class
                Car sportsCar = new Car();
                Console.WriteLine("Brand: " + sportsCar.brand);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //object of inner class
            Car.Engine engineObj = new Car.Engine();
            engineObj.displayCar();

            Console.ReadLine();
        }
    }
}