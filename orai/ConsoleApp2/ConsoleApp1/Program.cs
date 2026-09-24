// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");


MenuItem item = new MenuItem("Vitéz Dávid", "Híg", 250);
MenuItem item2 = new MenuItem("Vitézi Dávid", "Híg", 2500);
MenuItem item3 = new MenuItem("Vitézi Dáv", "Híg", 25020);
MenuItem item4 = new MenuItem("Vit Dávid", "Híg", 25060);
MenuItem item5 = new MenuItem("Vité Dávid", "Híg", 25800);
item.SellOut();
Console.WriteLine(item.GetDescriptrion());
item.ReStock();
Console.WriteLine(item.GetDescriptrion());

ConsoleView console = new ConsoleView();
console.ShowItem(item2);
console.ShowItem(item);
List <MenuItem> list = new();
list.Add(item);
list.Add(item2);
list.Add(item3);
list.Add(item4);
list.Add(item5);
console.ShowItems(list);
console.ShowMessage(MenuItem.Count.ToString());

