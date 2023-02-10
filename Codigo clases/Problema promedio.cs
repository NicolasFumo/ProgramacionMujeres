// Calcular el promedio 3 notas (bucles)

int totalNotas = 0;
int promedio;
int notaMayor = 0;
int cantidadNotas;

Console.Write("Cuantas notas va a ingresar? ");
cantidadNotas = int.Parse(Console.ReadLine());

for (int i = 0; i < cantidadNotas; i++)
{
    int notaIndividual;

    Console.Write("Ingrese la calificacion: ");
    notaIndividual = int.Parse(Console.ReadLine());

    if(notaIndividual > notaMayor)
    {
        notaMayor = notaIndividual;
    }

    totalNotas += notaIndividual;
}

promedio = totalNotas / cantidadNotas;

Console.WriteLine($"El promedio es: {promedio}");
Console.WriteLine($"La nota mayor es: {notaMayor}");
