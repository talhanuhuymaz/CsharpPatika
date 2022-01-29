// See https://aka.ms/new-console-template for more information

// Console.WriteLine("What is your name?");
// var name = Console.ReadLine();

// Console.WriteLine("What is your surname?");
// var surname = Console.ReadLine();

// Console.WriteLine("Merhaba " + name + " " + surname);


var a = "How old are you";

Console.WriteLine(a);

var age = Console.ReadLine();

var last = Convert.ToInt32(age);

if (last>= 18 && last !=0 )
{
Console.WriteLine("You can join the party :) ");
}

if (last < 18)
{
Console.WriteLine("Sorry you can not join :( ");
}

