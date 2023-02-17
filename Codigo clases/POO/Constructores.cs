// Constructores

Persona alumno1 = new Persona("Nicolas", "Fumo");

alumno1.telefono = "91269381";


class Persona
{
    public Persona(string nombrePersona, string apellidoPersona)
    {
        nombre = nombrePersona;
        apellido = apellidoPersona;
    }

    public string nombre;
    public string apellido;
    public string telefono;
}
