// Calcular el promedio 3 notas (Funciones)

int totalNotas = 0;
int promedio;
int notaMayor = 0;
int cantidadNotas;

cantidadNotas = PedirNumero("Cuantas notas va a ingresar? ");

for (int i = 0; i < cantidadNotas; i++)
{
    int notaIndividual;

    notaIndividual = PedirNumero("Ingrese la calificacion: ");

    notaMayor = DevuelveMayor(notaIndividual, notaMayor);

    totalNotas += notaIndividual;
}

promedio = CalcularPromedio(totalNotas, cantidadNotas);

Console.WriteLine($"El promedio es: {promedio}");
Console.WriteLine($"La nota mayor es: {notaMayor}");



int CalcularPromedio(int sumatoria, int cantidad)
{
    int resultadoPromedio;

    resultadoPromedio = sumatoria / cantidad;

    return resultadoPromedio;
}


int PedirNumero(string mensaje)
{
    Console.Write(mensaje);
    return int.Parse(Console.ReadLine());
}

int DevuelveMayor(int nro1, int nro2)
{
    if (nro1 > nro2)
    {
        return nro1;
    }
    else
    {
        return nro2;
    }
}
