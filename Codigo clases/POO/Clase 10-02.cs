Persona profe = new Persona();
Persona alumno = new Persona(); // instanciar una clase (crear el objeto)

profe.Cargar();
alumno.Cargar();

profe.Mostrar();
alumno.Mostrar();

class Persona
{
    public string nombre;
    public string apellido;
    public int edad;

    public void Mostrar()
    {
        Console.WriteLine($"Mi nombre es {nombre}");
    }

    public void Cargar()
    {
        Console.Write("Ingresa mi nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingresa mi apellido: ");
        apellido = Console.ReadLine();
    }

    public void Llamar()
    {

    }
}
