using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Abstraction Explained", "Austina Murara", 420);
        video1.AddComment(new Comment("Alice", "This makes so much sense now!"));
        video1.AddComment(new Comment("Bob", "Wait, so classes are just templates?"));
        video1.AddComment(new Comment("Charlie", "Great tutorial, thanks."));
        videoList.Add(video1);

        // Video 2
        Video video2 = new Video("Top 5 Sights in Harare", "TravelZim", 600);
        video2.AddComment(new Comment("Dave", "I need to visit the balancing rocks!"));
        video2.AddComment(new Comment("Eve", "The gardens look beautiful."));
        video2.AddComment(new Comment("Frank", "Adding this to my 2026 travel list."));
        videoList.Add(video2);

        // Video 3
        Video video3 = new Video("Object-Oriented Programming Tips", "CodePro", 300);
        video3.AddComment(new Comment("Grace", "Abstraction is the first step."));
        video3.AddComment(new Comment("Heidi", "I love the encapsulation examples."));
        video3.AddComment(new Comment("Ivan", "Can you do one on inheritance next?"));
        videoList.Add(video3);

        Console.WriteLine("=== YouTube Video Monitoring System ===");
        
        foreach (Video video in videoList)
        {
            video.DisplayVideoDetails();
        }

        Console.WriteLine("--------------------------------------------------");
    }
}