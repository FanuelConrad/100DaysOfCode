using System;

namespace ReversingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=new int[] {8,2,3,4,7,6,2};

            Stack<int> myStack=new Stack<int>();
            foreach (int number in numbers)
            {
                myStack.Push(number);
            }
            
            Console.WriteLine("");
            Console.WriteLine("the numbers in reverse :");
            //as long as our stack is not empty
            while (myStack.Count()>0)
            {
                //Pop it and store it in a variable
                int number=myStack.Pop();
                //print the value we popped
                Console.Write(number + " ");
            }
        }
    }
}