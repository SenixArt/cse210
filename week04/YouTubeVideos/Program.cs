using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creamos la lista que almacenará todos los videos
        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("Learning C# in 10 Minutes", "Tech Guru", 600);
        video1._comments.Add(new Comment("CodeMaster", "Great tutorial, very clear!"));
        video1._comments.Add(new Comment("DevBeginner", "This helped me a lot for my class."));
        video1._comments.Add(new Comment("CSharpFan", "Can you make a video about classes?"));
        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Funny Cat Videos", "CatLover99", 420);
        video2._comments.Add(new Comment("Meow", "The third cat is hilarious."));
        video2._comments.Add(new Comment("DogPerson", "Even I liked this one."));
        video2._comments.Add(new Comment("MemeKing", "I need to download this."));
        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Easy Pasta Recipe", "Chef Mario", 950);
        video3._comments.Add(new Comment("Foodie", "Looks delicious, trying it tonight."));
        video3._comments.Add(new Comment("HungryGuy", "Did you use fresh tomatoes?"));
        video3._comments.Add(new Comment("KitchenNoob", "I burned the pasta, but the sauce was good."));
        videosList.Add(video3);

        // Bucle para iterar a través de la lista de videos y mostrar la información
        foreach (Video video in videosList)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            // Bucle interno para listar los comentarios de cada video
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._text}");
            }
        }
        
        Console.WriteLine("---------------------------------------------");
    }
}
