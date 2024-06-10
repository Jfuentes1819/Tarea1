
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


//Declare e inicialice un arreglo de enteros con las edades de 5 personas.
//Declare e inicialice un arreglo de cadenas con los nombres de 5 personas.
//Itere sobre los arreglos e imprima cada nombre junto con su edad.
//Defina una función que tome un nombre y una edad como parámetros, y devuelva un saludo personalizado.
//Llame a esta función para cada par de nombre y edad en los arreglos e imprima el resultado.