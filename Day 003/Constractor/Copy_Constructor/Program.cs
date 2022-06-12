using System;

namespace Copy_Constructor // Note: actual namespace depends on the project name.
{
        class Car{
            string brand;
            
            //constructor
            Car(string theBrand){
                brand =  theBrand;
            }

            //copy constructor
            Car(Car c1){
                brand = c1.brand;
            }
        
        static void Main(string[] args)
        {
            //call constructor
            Car car1 = new Car("Bugatti");

            Console.WriteLine("Brand of car1: "+ car1.brand);

            //call the copy constructor
            Car car2 = new Car(car1);
            Console.WriteLine("Brand of car2: "+ car2.brand);

            Console.ReadLine();
        }
    }
}