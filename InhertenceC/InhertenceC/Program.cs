using System;

namespace InhertenceC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Post post1 = new Post();
            Post post2 = new Post("awesome me", "i made it" , true);
            Post post3 = new Post("me and you" , "me" , true);
            // ImagePost imagePost1 = new ImagePost();
            ImagePost imagePost2 = new ImagePost("image 1", "tom" , true , "www.ejsam.pic.mic.com");
            // VideoPost videoPost1 = new VideoPost();
            VideoPost videoPost2 = new VideoPost("myvideo", "me", true, "www.gppgle.com" , 500);
           
            // Console.WriteLine(post1);
            Console.WriteLine(post2);
            Console.WriteLine(post3);

            // Console.WriteLine(imagePost1);
            Console.WriteLine(imagePost2);


            // Console.WriteLine(videoPost1);
            Console.WriteLine(videoPost2);
            videoPost2.Play();
            Console.WriteLine("press any key to stop");
            Console.ReadKey();
            videoPost2.Stop();
            Console.ReadKey();
            videoPost2.Play();
            Console.ReadKey();
            videoPost2.Stop();
        }
    }
}