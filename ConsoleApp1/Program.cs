using System;

Console.Write("Hello, please enter your name: ");

string name = Console.ReadLine();
int namelength = name.Length;
char firstletter = name[0];

Console.WriteLine("hello " + name + "!");
Console.WriteLine("Your name has " + namelength + " letters.");
Console.Write("The first letter is " + firstletter + ".");