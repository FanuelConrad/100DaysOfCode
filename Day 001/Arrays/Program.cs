using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args){
            int[] numbers = {51,1,3,4,98};

            //get the minimum element
            Console.WriteLine("Smallest Element: "+numbers.Min());

            //Max() returns the largest number in array
            Console.WriteLine("Largest Element: "+ numbers.Max());

            //get the sum of all array elements
            Console.WriteLine("Sum: " + numbers.Sum());

            //get the total number of elements present in the array
            Console.WriteLine("Count: " + numbers.Count());

            //get the average of the elements
            Console.WriteLine("Average: " + numbers.Average());

            Console.ReadLine();
        }
    }
}