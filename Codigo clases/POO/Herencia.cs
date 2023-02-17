// Herencia - de clases
Alumno alumno1 = new Alumno();

alumno1.nombre = "asdasd";
alumno1.apellido = "asdas";
alumno1.telefono = "91269381";



class Persona
{
    public string nombre;
    public string apellido;
    public string telefono;
}

class Alumno : Persona
{
    public string curso;
}

class Profesor : Persona
{
    public string cursoACargo;
    public int sueldo;
}

class Secretario : Persona
{
    public string Cargo;
}
