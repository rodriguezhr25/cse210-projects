using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating video objects
        Video v1 = new Video("Yellow - Coldplay in Madrid", "Coldplay", 230);
        Video v2 = new Video("Rawayana - 911 (Rawalizer)", "Rawayana Official", 198);
        Video v3 = new Video("The Calling - Wherever You Will Go (First Video- in Tijuana)", "TheCallingVEVO", 186);
        Video v4 = new Video("Evanescence - My Immortal (Official Music Video)", "Evanescence", 272);

        //Add comments to the videos
        v1.AddComment(new Comment("Hector Rodriguez", "Coldplay is the best band ever!"));
        v1.AddComment(new Comment("Sebastian Rodriguez", "I love this song"));
        v1.AddComment(new Comment("Maria Garcia", "Sounds good!"));
        v1.AddComment(new Comment("Alan Brito", "The background sound is amazing!"));

        v2.AddComment(new Comment("Jose Perez", "I love reague!"));
        v2.AddComment(new Comment("Carlos Smith", "To listen in the beach"));
        v2.AddComment(new Comment("Dan Reynolds", "We can make a cover of this one"));

        
        v3.AddComment(new Comment("Yetza Garcia", "his song never age"));
        v3.AddComment(new Comment("Kathy K", "To listen in the beach"));
        v3.AddComment(new Comment("Cris Martin", "We can make a cover of this one"));


        
        v4.AddComment(new Comment("Dani Devito", "Amazing singer"));
        v4.AddComment(new Comment("Al Pacino", "Great band!!"));
        v4.AddComment(new Comment("Robert De Niro", "Rock!!"));
        v4.AddComment(new Comment("J.J L", "Love it!"));

        //Put the videos in the list

        List<Video> videos = new List<Video>();
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);
        Console.WriteLine("Youtube Videos");
        foreach(Video video in videos){
            Console.WriteLine("");
            Console.WriteLine(video.GetVideoString());
            Console.WriteLine("Comments: ");
            foreach(Comment comment in video.GetCommentsList()){
                Console.WriteLine(comment.GetCommentString());
            }
        }
    }
}