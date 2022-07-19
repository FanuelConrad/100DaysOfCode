using System;
using System.Collections.Generic;

namespace IEnumerableDem2
{
    class Program
    {
    static void Main(string[] args)
    {
        //a list of type List<int> initialised with some number
        List<int>numbersList=new List<int>(){8,6,2};
        //an array of type int[] initialized with some numbers
        int[] numberArray=new int[] {1,7,1,3};
        //new line
        System.Console.WriteLine(" ");
        //call CollectSum() and pass the list to it
        CollectionSum(numberArray);
        
    }

    static void CollectionSum(IEnumerable<int> anyCollection)
    {
        //sum variable to store the sum of the numbers in anyCollection
        int sum=0;
        //for each number in the collection passed to this method
        foreach (int num in anyCollection)
        {
            //add the num value to sum
            sum+=num;
        }
        //print the sum
        System.Console.WriteLine("Sum is {0}",sum);
    }
    }
}