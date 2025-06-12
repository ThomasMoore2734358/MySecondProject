// This is an independent project of an individual developer. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com


Console.WriteLine("Hello, World!");

// Welcome user to app

Console.WriteLine("Welcome to the Greeting App!");
Console.WriteLine();
Console.WriteLine("----------------------------");
Console.WriteLine();


// Ask for user name

Console.Write("What is your name? Type here: ");

string firstName;
firstName = Console.ReadLine();

Console.WriteLine();
// Greet user by name
Console.WriteLine("Hello, " + firstName + "!");

Console.WriteLine();
Console.WriteLine("Thank you " + firstName + " for using my app!");
Console.ReadLine();