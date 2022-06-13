using System;

namespace this_to_declare_an_indexer // Note: actual namespace depends on the project name.
{
    class Student
    {
        private string[] name = new string[3];

        //declaring an indexer
        public string this[int index]{

            //returns value of array element
            get{
                return name[index];
            }

            //sets value of array element
            set{
                name[index] = value;
            }
        }
    }
    
    class Program{
        public static void Main()
        {
            Student s1 = new Student();
            s1[0] = "Ram";
            s1[1] = "Shyam";
            s1[2] = "Gopal";

            for(int i=0; i<3;i++){
            Console.WriteLine(s1[i] + " ");
            }
        }
    }

}