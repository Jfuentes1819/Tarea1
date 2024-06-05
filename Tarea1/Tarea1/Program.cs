
using System.Reflection.PortableExecutable;

Console.WriteLine("Hello, World!");

int edad1 = 28;
decimal estaturaMetros = 1.75m;
string nombreCompleto = "Juan Perez";
char inicialApellido = 'J';
string sexo = "masculino";
double pesoKilogramos = 68.5;
bool estudiante = true;
decimal estaturaCentimetros = estaturaMetros * 100;
string edad2 = Convert.ToString(edad1);
double pesoLibras = pesoKilogramos * 2.2;

Console.WriteLine(@"Información del estudiante:
Edad: " + edad1 + 
"\nEstatura: " + estaturaMetros +
"\nNombre Completo: " + nombreCompleto + 
"\nInicial del Apellido: " + inicialApellido + 
"\nSexo: " + sexo + 
"\nPeso: " + pesoKilogramos + 
"\nStatus Estudiantil: " + estudiante);

Console.WriteLine("El peso del estudiante en libras es: " + pesoLibras);
Console.WriteLine("La estatura del estudiante en centimetros es: " + estaturaCentimetros);





Console.ReadKey();