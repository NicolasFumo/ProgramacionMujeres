Persona profe = new Persona();
Persona alumno = new Persona(); // instanciar una clase (crear el objeto)

string nombreProfe;


nombreProfe = profe.ObtenerNombre();
profe.CrearNombre("Nicolas");

profe.Cargar();
alumno.Cargar();

profe.Mostrar();
alumno.Mostrar();

class Persona
{
    // modificador de acceso
    private string nombre;
    private string apellido;
    private int edad;

    public string ObtenerNombre()
    {
        return $"{nombre} {apellido}";
    }

    public void CrearNombre(string nuevoNombre)
    {
        nombre = nuevoNombre;
    }

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
