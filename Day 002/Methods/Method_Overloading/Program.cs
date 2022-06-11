using System;

namespace Method_Overloading // Note: actual namespace depends on the project name.
{
    class Program
    {
        //method with one parameter
        void display(int a){
            Console.WriteLine("Arguments: "+ a);
        }

        //method with two parameters
        void display(int a, int b){
            Console.WriteLine("Arguments: "+ a + " and " + b);
        }
        static void Main(string[] args)
        {
          Program p1 = new Program();
          p1.display(100);
          p1.display(100,100);
          Console.ReadLine();
        }
    }
}