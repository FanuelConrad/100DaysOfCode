using System;

namespace Parameterized_Constructor // Note: actual namespace depends on the project name.
{
    class Car
    {
        string brand;
        int price;

        //parameterized constructor
        Car(string theBrand,int thePrice){
            brand = theBrand;
            price = thePrice;
        }

        static void Main(string[] args)
        {
            //call parameterized constructor
            Car car1 = new Car("Bugatti",50000);

            Console.WriteLine("Brand: "+ car1.brand);
            Console.WriteLine("Price: "+ car1.price);
            Console.ReadLine();
        }
    }
}