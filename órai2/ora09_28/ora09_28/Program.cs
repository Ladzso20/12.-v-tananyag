// See https://aka.ms/new-console-template for more information
using ora09_28;

Console.WriteLine("Hello, World!");

Member member = new Member("Jani", 95, false);
Member member2 = new Member("Peti", 15, true);
Member member3 = new Member("Pista a kocsmából", 45, false);

member.Kiirat();
member2.Kiirat();
member3.Kiirat();
Console.WriteLine(member.Describe());
Console.WriteLine(member2.Describe());

Membership ship = new Membership(member, 10000, 12);
Membership ship2 = new Membership(member2, 10000, 12);
Membership ship3 = new Membership(member3, 10000, 0);
Console.WriteLine(ship.TotalCost());
Console.WriteLine(ship2.TotalCost());
ship.Extend(18);
Console.WriteLine(ship.TotalCost());


Gym gym = new Gym("Gym ok");
gym.MostActive();
gym.BestValue();