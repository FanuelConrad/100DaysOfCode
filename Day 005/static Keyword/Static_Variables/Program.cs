using System;

namespace Static_Variables // Note: actual namespace depends on the project name.
{
    class Student{
        
        //static variable
        public static string department = "Computer Science";
    }

    class Program
    {
        static void Main(string[] args)
        {
            //access static variable
            Console.WriteLine("Department: "+Student.department);

            Console.ReadLine();
        }
    }
}