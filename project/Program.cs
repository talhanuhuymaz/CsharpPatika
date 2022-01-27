// See https://aka.ms/new-console-template for more information

string? name; 
string? surname;


Console.WriteLine("What is your name?");
name = Console.ReadLine();

Console.Write("What is your surname?");
surname = Console.ReadLine();

Console.WriteLine("Merhaba " + name + " " + surname);