using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Introduction to C#", "Ifeanyi", 300);
        Video video2 = new Video("Learning Python", "John", 450);
        Video video3 = new Video("Understanding HTML", "Mary", 250);

        // Create comments for video 1
        video1.AddComment(new Comment("David", "Very helpful video!"));
        video1.AddComment(new Comment("Sarah", "I learned something new."));
        video1.AddComment(new Comment("Peter", "Please make more videos."));

        // Create comments for video 2
        video2.AddComment(new Comment("Grace", "Python is interesting."));
        video2.AddComment(new Comment("James", "Great explanation!"));
        video2.AddComment(new Comment("Esther", "Thank you for this lesson."));

        // Create comments for video 3
        video3.AddComment(new Comment("Daniel", "HTML is easy to understand."));
        video3.AddComment(new Comment("Faith", "This helped me a lot."));
        video3.AddComment(new Comment("Michael", "Nice tutorial!"));

        // Store videos in a list
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine("\n----------------------------");

            video.DisplayVideoDetails();

            Console.WriteLine("\nComments:");

            video.DisplayComments();

            Console.WriteLine("----------------------------");
        }
    }
}