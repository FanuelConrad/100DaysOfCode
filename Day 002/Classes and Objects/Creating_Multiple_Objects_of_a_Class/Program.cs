using System;

namespace Creating_Multiple_Objects_of_a_Class // Note: actual namespace depends on the project name.
{
    class Employee
    {
        string department;
        static void Main(string[] args)
        {
            //create Employee object
            Employee sheeran=new Employee();

            //set department for sheeran
            sheeran.department="Development";
            Console.WriteLine("Sheeran: "+sheeran.department);

            //create a second object of Employee
            Employee taylor=new Employee();

            //set department for taylor
            taylor.department="Content Writing";
            Console.WriteLine("Taylor: "+taylor.department);

            Console.ReadLine();
        }
    }
}