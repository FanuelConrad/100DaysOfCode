//Note: Calling one constructor from another constructor is known as constructor chaining.

using System;

namespace Invoke_Constructor_of_the_Same_Class_Using_this // Note: actual namespace depends on the project name.
{
    class Test
    {
        Test(int num1, int num2){
            Console.WriteLine("Constructor with two parameter");
        }

        //invokes the constructor with 2 parameters
        Test(int num) : this(33,22){
            Console.WriteLine("Constructor with one parameter");
        }
        public static void Main(string[] args)
        {
            Test t1 = new Test(11);
            Console.ReadLine();
        }
    }
}