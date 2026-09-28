// See https://aka.ms/new-console-template for more information
using ora09_28;

Console.WriteLine("Hello, World!");

Member member = new Member("Jani", 95, false);
Member member2 = new Member("Peti", 15, true);
Member member3 = new Member("Pista a kicsmából", 45, false);

member.Kiirat();
member2.Kiirat();
member3.Kiirat();
member.Describe();