string name;
Console.WriteLine("What is your name?");
try 
{ 
    name = Console.ReadLine();
    Console.WriteLine($"Hey {name}! Welcome to the .NET 6 World!");
}
catch(Exception ex) { Console.WriteLine("Eroare"); }

