// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Globalization;

Console.WriteLine("Hello, World!");

Book book1 = new Book("pista","Pista", 1000);
Book book2 = new Book("jani", "Jani", 200);

book1.Describe();
book2.Describe();

Console.WriteLine(book1.IsLong());
Console.WriteLine(book2.IsLong());

Book book3 = new Book("ki", "Setőfi Pámndor");
book3.Describe2();


Book book4 = new Book("jani", "Jani", 200);
Book book5 = new Book("jani", "Jani", 200);
Book book6 = new Book("jani", "Jani", 200);
Console.WriteLine(book1.Borrow());
book1.Return();
Console.WriteLine(book1.Borrow());

Library Pist = new Library("Nev");

Pist.AddBook(book1);
Pist.AddBook(book2);
Pist.AddBook(book3);
Pist.AddBook(book4);
Pist.AddBook(book5);
Pist.AddBook(book6);