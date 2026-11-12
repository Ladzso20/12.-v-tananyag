namespace SocialFeed
{
    internal class Program
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
        }
    }
}
