namespace Inheritance_Challenge_VideoPost_and_Timer_with_callback
{
    class Post
    {
        private static int currentPostId;

    //properties
    protected int ID {get; set;}
    protected string Title { get; set; }
    protected string SendByUsername { get; set; }
    protected bool IsPublic { get; set; }

    public Post()
    {
        ID=0;
        Title="My First Post";
        IsPublic=true;
        SendByUsername="Denis Panjuta";
    }

    //Instance constructor that has three parameters
        public Post(string title,bool isPublic,string sendByUserName)
        {
            this.ID=GetNextID();
            this.Title=title;
            this.SendByUsername=sendByUserName;
            this.IsPublic=isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title=title;
            this.IsPublic=isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}",this.ID,this.Title,this.SendByUsername);
        }


    }

}