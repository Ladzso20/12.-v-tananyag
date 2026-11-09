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
        }
    }
}
