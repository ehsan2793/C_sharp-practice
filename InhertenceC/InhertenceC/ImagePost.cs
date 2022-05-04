using System;
namespace InhertenceC
{
    public class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {
        }

        public ImagePost(string title, string sendBy, bool isPublic, string imageUrl)
        {
            Id = GetNextID();
            Title = title;
            SendBy = sendBy;
            IsPublic = isPublic;
            
            // property if imagePost
            ImageURL = imageUrl;

        }

        public override string ToString()
        {
     
            return String.Format($"{Id} - {Title} - {SendBy} - {ImageURL}");
        
        }
    }
}