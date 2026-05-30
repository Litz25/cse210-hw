using System;

class Program
{
    static void Main(string[] args)
    {
              

        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();

        video1._title = "Python Full Course";
        video1._author = "Mosh";
        video1._length = 300;

        video2._title = "C# Full Course";
        video2._author = "Bro Code";
        video2._length = 120;

        video3._title = "What is OOP";
        video3._author = "Code ON";
        video3._length = 60;


        Comment c1 = new Comment();
        c1._userName = "Alice";
        c1._commentText = "Great video";
        video1._comments.Add(c1);

        Comment c2 = new Comment();
        c2._userName = "Mwiya";
        c2._commentText = "Very helpful, thanks!";
        video2._comments.Add(c2);

        Comment c3 = new Comment();
        c3._userName = "Lita";
        c3._commentText = "I understand OOP now!";
        video3._comments.Add(c3);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        
        foreach (Video v in videos)
        {
        
        Console.WriteLine("Title: " + v._title);
        Console.WriteLine("Author: " + v._author);
        Console.WriteLine("Length: " + v._length + " seconds");
        Console.WriteLine("Number of Comments: " + v.NumberOfComments());
        Console.WriteLine("Comments:");

        foreach (Comment c in v._comments)
        {

            Console.WriteLine(c._userName + ": " + c._commentText);

        }

        }
    }
            
}