// See https://aka.ms/new-console-template for more information

// PART1                 ***CTRL+K+C satırı veya komple yorum satırı yapıyor (ctrl+k+u tam tersini)
// Console.WriteLine("What is your name?");
// var name = Console.ReadLine();

// Console.WriteLine("What is your surname?");
// var surname = Console.ReadLine();

// Console.WriteLine("Merhaba " + name + " " + surname);





// PART2
// var a = "How old are you";

// Console.WriteLine(a);

// var age = Console.ReadLine();

// var last = Convert.ToInt32(age);

// if (last>= 18 && last !=0 )
// {
// Console.WriteLine("You can join the party :) ");
// }

// if (last < 18)
// {
// Console.WriteLine("Sorry you can not join :( ");
// }



// PART3

Console.WriteLine("how many times have you had covid ? ");
var number = Console.ReadLine();

var intnumber = Convert.ToInt32(number);

if ( intnumber<3 && intnumber!=0)
{
    Console.WriteLine("How do you feel ? ");
    var feel = Console.ReadLine();
    Console.WriteLine("Great! ");
}
else
{
Console.WriteLine("You have to go to the hospital! ");
}



