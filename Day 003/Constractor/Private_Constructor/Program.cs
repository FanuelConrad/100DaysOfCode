/*We can create a private constructor using the private access specifier. This is known as a private constructor in C#.

Once the constructor is declared private, we cannot create objects of the class in other classes.

In the above example, we have created a private constructor Car(). Since private members are not accessed outside of the class, when we try to create an object of Car

// inside CarDrive class
Car car1 = new Car();

we get an error:
error CS0122: 'Car.Car()' is inaccessible due to its protection level
Note: If a constructor is private, we cannot create objects of the class. Hence, all fields and methods of the class should be declared static, so that they can be accessed using the class name.*/

using System;

namespace Private_Constructor // Note: actual namespace depends on the project name.
{
    class Car
    {
        //private constructor
        private Car(){
            Console.WriteLine("Private Constructor");
        }
        }

        class CarDrive{
        static void Main(string[] args)
        {
            //call private constructor
            //Car car1 = new Car();
            Console.ReadLine();
        }
        }
}