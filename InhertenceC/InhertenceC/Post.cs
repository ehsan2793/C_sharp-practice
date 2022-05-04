using System;

namespace InhertenceC
{
    public class Post
    {
        private static int currentPostId;
        protected int Id { get; set; }
        protected string Title { get; set; }
        public string SendBy { get; set; }

        public bool IsPublic { get; set; }


        public Post( )
        {
            Id = 0;
            Title = "Name of Post";
            IsPublic = true;
            SendBy = "me";
        }

        public Post(string title, string sendBy, bool isPublic)
        {
            Id = GetNextID();
            Title = title;
            SendBy = sendBy;
            IsPublic = isPublic;

        }


        protected static int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string newTitle ,  bool isPublic)
        {
            Title = newTitle;
            IsPublic = isPublic;
        }


        public override string ToString()
        {
            return String.Format($"{Id} - {Title} - {SendBy}");
        }
    }
}