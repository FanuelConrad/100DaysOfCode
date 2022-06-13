using System;

namespace this_with_Same_Name_Variables // Note: actual namespace depends on the project name.
{
    class Test
    {
        int num;
        Test(int num){
            //this.num refers to the instance field
            this.num = num;
        }
        static void Main(string[] args)
        {
            Test t1 = new Test(4);
            Console.WriteLine("value of num: "+t1.num);
            Console.ReadLine();
        }
    }
}