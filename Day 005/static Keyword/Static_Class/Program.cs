//when we declare a class as static, we cannot create objects of the class

using System;

namespace Static_Class // Note: actual namespace depends on the project name.
{
    static class Test
    {
        static int a = 5;
        static void display(){
            Console.WriteLine("Static method");
        }

        static void Main(string[] args)
        {
            //creating object of Test not possible
            //Test t1=new Test();
            Console.WriteLine(a);
            display();
        }
    }
}