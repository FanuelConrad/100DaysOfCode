namespace InheritanceDemo
{
    class ImagePost:Post
    {
        public string ImageURL{get;set;}

        public ImagePost()
        {
            
        }

        public ImagePost(string title,string sendByUsername,string imageURL,bool isPublic)
        {
            this.ID=GetNextID();
            this.Title=title;
            this.SendByUsername=sendByUsername;
            this.IsPublic=isPublic;

            this.ImageURL=imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}",this.ID,this.Title,this.ImageURL,this.SendByUsername);
        }
    }
}