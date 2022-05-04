using System;
using System.Threading;

namespace InhertenceC
{
    public class VideoPost : Post
    {
        protected bool IsPlaying = false;
        protected int currentDuration = 0;
        Timer timer;


        protected string VideoURL { get; set; }
        protected int Length { get; set; }


        public VideoPost()
        {
        }

        public VideoPost(string title, string sendBy, bool isPublic, string videoURL, int length)
        {
            Id = GetNextID();
            Title = title;
            SendBy = sendBy;
            IsPublic = isPublic;
            Length = length;

            // property if imagePost
            VideoURL = videoURL;
        }

        public override string ToString()
        {
            return String.Format($"{Id} - {Title} - {SendBy} - {VideoURL} is {Length} long");
        }

        public void Play()
        {
            if (!IsPlaying)
            {
                IsPlaying = true;
                Console.WriteLine("playing");
                timer = new Timer(TimerCallback, null, 0, 100);  
            }
           
         
        }

        private void TimerCallback(object o)
        {
            if (currentDuration < Length)
            {
                
                currentDuration++;
                Console.WriteLine($"video is at {currentDuration}");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (IsPlaying)
            {
                IsPlaying = false;
                Console.WriteLine($" video stop at {currentDuration} ");
                // currentDuration = 0;
                timer.Dispose();
            }
           

        }
    }
}