using System;

namespace Get_Length_of_String // Note: actual namespace depends on the project name.
{
    class Test
    {
       public static void Main(string[] args)
        {
            //create string
            string str = "C# Programming";
            Console.WriteLine("string:"+str);

            //get length of str
            int length = str.Length;
            Console.WriteLine("Length: "+ length);

            Console.ReadLine();
        }
    }
}