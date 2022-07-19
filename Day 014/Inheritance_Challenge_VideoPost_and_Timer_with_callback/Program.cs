using System;

namespace Inheritance_Challenge_VideoPost_and_Timer_with_callback
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoPost videoPost1=new VideoPost("FailVideo", "Denis Panjuta","https//video.com/failvideo", true,10);
            System.Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            System.Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();
        }
    }
}