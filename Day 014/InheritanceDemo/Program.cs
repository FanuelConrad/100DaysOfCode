using System;
namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1=new Post("Thanks for the birthday wishes",true,"Denis Panjuta");
            System.Console.WriteLine(post1.ToString());
            
            ImagePost imagePost1=new ImagePost("Check out my new shoes","Denis Panjuta","https//image.com/shoes",true);
            System.Console.WriteLine(imagePost1.ToString());
        }
    }
}