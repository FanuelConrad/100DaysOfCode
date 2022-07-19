using System.Threading; 
namespace Inheritance_Challenge_VideoPost_and_Timer_with_callback
{
    class VideoPost:Post
    {
        //member fields
        protected bool isPlaying=false;
        protected int currDuration=0;
        Timer timer;
        protected string VideoURL{get;set;}
        protected int Length{get;set;}

        public VideoPost()
        {
            
        }

        public VideoPost(string title,string sendByUserName,string videoURL,bool isPublic,int length)
        {
            //the following properties and the GetNextID method are inherited from Post
            this.ID=GetNextID();
            this.Title=title;
            this.SendByUsername=sendByUserName;
            this.IsPublic=isPublic;

            //Property videoURL is a member of VideoPost, but not of Post
            this.VideoURL=videoURL;
            this.Length=length;
        }

        public void Play()
        {
            if(!isPlaying)
            {
                isPlaying=true;
            System.Console.WriteLine("Playing");
            timer=new Timer(TimerCallback, null,0,1000);
            }

        }

        private void TimerCallback(Object o)
        {
            if (currDuration<Length)
            {
                currDuration++;
                System.Console.WriteLine("Video at {0}s",currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {if (isPlaying)
        {
            isPlaying=false;
            System.Console.WriteLine("Stopped at {0}",currDuration);
            currDuration=0;
            timer.Dispose();
        }

        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} by {4}",this.ID,this.Title,this.VideoURL,this.Length,this.SendByUsername);
        }
    }
}