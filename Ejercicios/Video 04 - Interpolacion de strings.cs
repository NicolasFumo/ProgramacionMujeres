
/* VIDEO 4 - INTERPOLACION DE STRINGS
  1- Que es la interpolacion y por qué usarla
  2- Como realizarla en el código */


int Numero1;
int Numero2;
int Resultado;

Console.WriteLine("Ingrese el primer numero:");
Numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero:");
Numero2 = int.Parse(Console.ReadLine());

Resultado = Numero1 + Numero2;

Console.WriteLine($"El resultado de sumar {Numero1} y {Numero2} da como resultado {Resultado}");
