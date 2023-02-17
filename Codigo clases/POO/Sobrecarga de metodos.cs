// Sobrecarga de metodos

Persona alumno1 = new Persona("Nicolas", "Fumo");

alumno1.telefono = "91269381";

Persona alumno2 = new Persona();


class Persona
{
    public Persona(string nombrePersona, string apellidoPersona)
    {
        nombre = nombrePersona;
        apellido = apellidoPersona;
    }

    public Persona()
    {

    }

    public string nombre;
    public string apellido;
    public string telefono;
}
