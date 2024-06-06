

//Decidir si una persona puede votar basándose en su edad. if
// Asignar una letra de calificación (A, B, C, D, F) basada en una puntuación numérica. Switch
//Determinar el descuento aplicable según el tipo de cliente (Regular, Miembro, VIP). else if



Console.WriteLine("Porfavor ingrese su edad.");
decimal age = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Porfavor ingrese su altura en centimetros.");
float height = Console.Read();

if (age <= 17 && height <= 1.50)
{
    Console.WriteLine("Usted no es eligible para unirte al equipo de baseball.");

}
else
{
    Console.WriteLine("Usted es elegible para unirte al equipo de baseball");
}

Console.WriteLine("\nIngrese un numero del 1-7 ");
decimal caseNumber = Convert.ToInt32(Console.ReadLine());


switch (caseNumber)
{
    case 1:
        Console.WriteLine("El dia de hoy es Lunes.");
        break;
    case 2:
        Console.WriteLine("El día de hoy es Martes");
        break;
    case 3:
        Console.WriteLine("El día de hoy es Miercoles");
        break;
    case 4:
        Console.WriteLine("El día de hoy es Jueves");
        break;
    case 5:
        Console.WriteLine("El día de hoy es Viernes");
        break;
    case 6:
        Console.WriteLine("El día de hoy es Sabado");
        break;
    case 7:
        Console.WriteLine("El día de hoy es Domingo");
        break;

    default:
        break;
}

Console.WriteLine("\nIngresa su calificación numérica.");
decimal calificacion = Convert.ToDecimal(Console.ReadLine());

if (calificacion >= 90)
{
    Console.WriteLine("\nSu nota es A.");
}
else if (calificacion <=89 && calificacion >= 80)
{
    Console.WriteLine("\nSu nota es B.");
}
else if (calificacion <= 79 && calificacion >= 70)
{
    Console.WriteLine("\nSu nota es C.");
}
else if (calificacion <= 69 && calificacion >= 60)
{
    Console.WriteLine("\nSu nota es D.");
}
else if (calificacion <= 59 )
{
    Console.WriteLine("\nSu nota es F.");
}
    Console.ReadKey();



