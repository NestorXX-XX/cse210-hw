using System;

class Program
{
    static void Main(string[] args)
    {
        List <Comment> comments_video1 = new List<Comment>
        {
            new Comment("Nestor", "Really good video"),
            new Comment("Juan", "I really enjoyed it thanks"),
            new Comment("Martin", "Keep going!")
        };
        Video video1 = new Video("Why should you not quit!", "Jorge Gomez Artiles", 600, comments_video1);

        List<Comment> comments_video2 = new List<Comment>
        {
            new Comment("Luisa", "Amazing tips!"),
            new Comment("Carlos", "This helped me a lot"),
            new Comment("Ana", "Subscribing now!")
        };
        Video video2 = new Video("How to stay consistent", "Paula Martínez", 480, comments_video2);

        List<Comment> comments_video3 = new List<Comment>
        {
            new Comment("Diego", "Clear explanation"),
            new Comment("Sara", "Can you cover routines next?"),
            new Comment("Leo", "Liked and shared!")
        };
        Video video3 = new Video("Morning habits that work", "Alex Rivera", 720, comments_video3);

        List<Video> _videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in _videos)
        {
            video.displayInfo();
        }


    }
}