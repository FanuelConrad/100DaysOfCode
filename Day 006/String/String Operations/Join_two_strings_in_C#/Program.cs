using System;

namespace Join_two_strings // Note: actual namespace depends on the project name.
{
    class Test
    {
        public static void Main(string[] args)
        {
            string str1 ="C#";
            Console.WriteLine("string str1: "+ str1);

            //create string
            string str2 = "Programming";
            Console.WriteLine("string str2: "+ str2);

            //join two strings
            string joinedString = string.Concat(str1, str2);
            Console.WriteLine("Joined string: "+ joinedString);

            Console.ReadLine();
        }
    }
}