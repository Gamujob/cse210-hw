using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // CREATE THE VIDEOS
        Video video1 = new Video("Eating Health Food", "Job Gamu", 540);
        video1.AddComment(new Comment("Joe", "Thanks for this"));
        video1.AddComment(new Comment("Anna", "I will start eating it today"));
        video1.AddComment(new Comment("Emma", "I have to show this to my family"));

        Video video2 = new Video("Body Excercise", "Tom Cruise", 660);
        video2.AddComment(new Comment("Sharon", "Things are not easy to do"));
        video2.AddComment(new Comment("Moses", "I will try"));

        Video video3 = new Video("Explaining Python", "John Russel", 120);
        video3.AddComment(new Comment("Tonny", "Thanks very much sir, I have now got it"));
        video3.AddComment(new Comment("Joshua", "Wow, well explained"));
        video3.AddComment(new Comment("Zubair", "I can't fail to understand such a great video. Thank you!"));
        video3.AddComment(new Comment("James", "I have to check this account or such good videos. I like this!"));


        Video video4 = new Video("Sports Benefits", "Evans Chris", 980);
        video4.AddComment(new Comment("Jimmy", "I petty those who don't have interest in sports!"));
        video4.AddComment(new Comment("Bommy", "But still I don't like sports."));
        video4.AddComment(new Comment("Robert", "That makes me to like sports more!"));

        // ADD VIDEOS TO THE LIST
        List<Video> videos = new List<Video> {video1, video2, video3, video4};

        // LOOPING THROUGH THE LIST OF VIDEO
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}