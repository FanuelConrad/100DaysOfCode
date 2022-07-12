using System;
using System.Collections.Generic;

namespace DictionariesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees ={
                new Employee("CEO","Gwyn",95,200),
                new Employee("Manager","Joe",35,25),
                new Employee("HR","Lora",32,21),
                new Employee("Secretary","Petra",28,18),
                new Employee("Lead Developer","Artorias",55,35),
                new Employee("Intern","Ernest",22,8)
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                //add entries to the dictionary
                employeesDirectory.Add(emp.Role, emp);
            }

            //check if key exists in the dictionary
            string key = "CEO";
            if (employeesDirectory.ContainsKey(key))
            {
                //retriving data from Dictionary
                Employee empl = employeesDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this Key {0}", key);
            }

            string KeyToUpdate = "HR";
            //check if key exists
            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                //edit entry in the dictionary
                employeesDirectory[KeyToUpdate]=new Employee("HR","Eleka",26,18);
                Console.WriteLine("Employee with Role/Key {0} was updated!.", KeyToUpdate);
            }
            else
            {
                Console.WriteLine("No employee found with this key {0}", KeyToUpdate);
            }

            
            foreach (KeyValuePair<string, Employee> keyValuePair in employeesDirectory)
            {
                //storing the value in an employee object
            Employee employeeValue=keyValuePair.Value;
                Console.WriteLine("Employee Name: {0} Employee Role: {1} Employee Age: {2} Employee Salary: {3}",employeeValue.Name,employeeValue.Role,employeeValue.Age,employeeValue.Salary);
            }
        }
    }
}