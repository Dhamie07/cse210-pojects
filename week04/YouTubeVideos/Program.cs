using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create and add videos to the list
        Video video1 = new Video("Learning C#", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot from this video."));
        videos.Add(video1);

        Video video2 = new Video("Mastering ASP.NET", "TechGuru", 1200);
        video2.AddComment(new Comment("David", "Excellent explanation."));
        video2.AddComment(new Comment("Ella", "This is exactly what I was looking for."));
        video2.AddComment(new Comment("Frank", "Can you do a part 2?"));
        videos.Add(video2);

        Video video3 = new Video("Introduction to AI", "AI World", 900);
        video3.AddComment(new Comment("Grace", "Fascinating topic!"));
        video3.AddComment(new Comment("Hank", "Loved the examples."));
        video3.AddComment(new Comment("Ivy", "Subscribing for more content."));
        videos.Add(video3);

        // Display details of each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}