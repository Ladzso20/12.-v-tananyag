namespace SocialFeed
{
    public class Program
    {
        static void Main(string[] args)
        {
            TextPost a = new TextPost("A", "aaaaaa");
            TextPost b = new TextPost("B", "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb");
            for(int i = 0; i < 3; i++)
            {
                a.Like();
            }

            Console.WriteLine(a.GetDescription());
            Console.WriteLine(a.Like());
            Console.WriteLine(b.GetDescription());
            Console.WriteLine(b.Like());

            ImagePost img1 = new ImagePost("C", 3);
            for(int i=0; i < 5; i++)
            {
                img1.Like();
            }
            Console.WriteLine(img1.Score());
            Console.WriteLine(img1.GetDescription());
            ImagePost img2 = new ImagePost("D", 15);
            Console.WriteLine(img2.GetDescription());

            PollPost poll1 = new PollPost("E");
            poll1.Like();
            poll1.Like();
            for (int i= 0; i < 4; i++)
            {
                poll1.Vote();
            }
            poll1.Close();
            Console.WriteLine(poll1.Like());
            Console.WriteLine(poll1.Vote());
            Console.WriteLine(poll1.GetDescription());

            ModerationQueue moderation = new ModerationQueue();
            moderation.ReportItem(a);
            Console.WriteLine(moderation.ToReview.Count);
            moderation.ReportItem(a);
            moderation.ReportItem(a);
            Console.WriteLine(moderation.ToReview.Count);
        }
    }
}
