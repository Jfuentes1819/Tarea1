
using System.Reflection.Metadata;
    
Console.WriteLine("Hello!");

int[] ages = { 15, 25, 46, 37, 50 };
string[] names = { "Jorge", "Julian", "Anthony", "Gildo", "Adrien" };

for (int i = 0; i < ages.Length; i++)
{
    Console.WriteLine(ages[i]);
}

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("Aqui esta: " + names[i] + " Edad: " + ages[i]);
}

static void SpecificGreeting(int ages, string names)
{
    Console.WriteLine($"Hola!: " + names + " Tu tienes: " + ages);
}

for (int i = 0; i < ages.Length; i++)
{
    SpecificGreeting(ages[i], names[i]);
}


Console.ReadKey();

