using System;

namespace AbstractClass // Note: actual namespace depends on the project name.
{
    abstract class MotorBike
    {
        public abstract void brake();
    }

    class SportsBike : MotorBike
    {
        //provide implementation of abstract method
        public override void brake()
        {
            Console.WriteLine("Sports Bike Brake");
        }
    }

    class MountainBike : MotorBike
    {
        //provide implementation of abstract method
        public override void brake()
        {
            Console.WriteLine("Mountain Bike Brake");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //create an object of SportsBike class
            SportsBike s1 = new SportsBike();
            s1.brake();

            //create an object of MountainBike class
            MountainBike m1 = new MountainBike();
            m1.brake();

            Console.ReadLine();
        }
    }
}