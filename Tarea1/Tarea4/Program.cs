//Sentencias de control avanzado iterativas

//while
//do while = hazme pero primero pregunta(casi nunca se usa)
//for
//foreach


using System.Runtime.Intrinsics.X86;

int index = 0;
int[] numbers = { 13, 15, 48, 50, 62, 15, 19, 4, 69, 50 };


int sum = 0;


while(index < numbers.Length) //names.Count())
{
    Console.WriteLine(numbers[index]);
    index++;
}


for (int i =1; i <=5; i ++)
{
    Console.WriteLine(index);
    index++;

}



foreach (int item in numbers)//se puede usar var pero trata de usar el tipo de dato correcto
{
    Console.WriteLine(item);
}

foreach (int item in numbers)//se puede usar var pero trata de usar el tipo de dato correcto
{

    sum += item;
    Console.WriteLine(item);
}









 