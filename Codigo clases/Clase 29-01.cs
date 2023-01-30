int Numero1;
int Numero2;
int Resultado;
string Operacion;

Console.Write("Ingrese el primer numero:");
Numero1 = int.Parse(Console.ReadLine());

// pregunto si quiero sumar o restar
Console.Write("Desea sumar o restar? (+ o -): ");
Operacion = Console.ReadLine();

Console.Write("Ingrese el segundo numero:");
Numero2 = int.Parse(Console.ReadLine());

if ( Operacion == "+" )
{
    Resultado = Numero1 + Numero2;
}
else
{
    Resultado = Numero1 - Numero2;
}

Console.WriteLine($"{Numero1} {Operacion} {Numero2} = {Resultado}");




// condicional
int numero;

numero = 7;

if ( numero == 7 )
{
    Console.WriteLine("Verdadero");
}
else
{
    Console.WriteLine("Falso");
}

// Pedir dos numeros y mostrar el mayor en pantalla
int nro1;
int nro2;

Console.Write("Ingrese el primer numero: ");
nro1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
nro2 = int.Parse(Console.ReadLine());

if (nro1 > nro2)
{
    Console.WriteLine($"El numero mayor es {nro1}");
}
else
{
    Console.WriteLine($"El numero mayor es {nro2}");
}

// con 3 posibilidades
if (nro1 == nro2)
{
    Console.WriteLine("Los dos numeros son iguales");
}
else
{
    if (nro1 > nro2)
    {
        Console.WriteLine($"El numero mayor es {nro1}");
    }
    else
    {
        Console.WriteLine($"El numero mayor es {nro2}");
    }
}

string nombrePersona;

Console.Write("Ingrese su nombre: ");
nombrePersona = Console.ReadLine();


if (nombrePersona == "Pedro")
{
    Console.WriteLine("Hola pedro!");
}
else
{
    Console.WriteLine("No sos pedro");
}



// Switch (switch - case)

int Numero1;
int Numero2;
int Resultado = 0;
string Operacion;

Console.Write("Ingrese el primer numero:");
Numero1 = int.Parse(Console.ReadLine());

// pregunto si quiero sumar o restar
Console.Write("Desea sumar o restar? (+ o -): ");
Operacion = Console.ReadLine();

Console.Write("Ingrese el segundo numero:");
Numero2 = int.Parse(Console.ReadLine());

switch (Operacion)
{
    case "+": // {
        Resultado = Numero1 + Numero2;
        break; // }
    case "-":
        Resultado = Numero1 - Numero2;
        break;
    case "*":
        Resultado = Numero1 * Numero2;
        break;
    case "/":
        Resultado = Numero1 / Numero2;
        break;

    default:
        Console.WriteLine("La operacion no era valida");
        break;
}

// Operadores logicos
// && (ampersand) -> "y"
// || (pleca) -> "o"

if ( Operacion == "+" || Operacion == "-" || 
     Operacion == "*" || Operacion == "/")
{
    Console.WriteLine($"{Numero1} {Operacion} {Numero2} = {Resultado}");
}
