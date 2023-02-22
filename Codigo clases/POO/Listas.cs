Persona p1 = new Persona();
p1.Nombre = "Carlos";
p1.Apellido = "Zanabria";
p1.Edad = 28;

Persona p2 = new Persona();
p2.Nombre = "Maria";
p2.Apellido = "Centeno";
p2.Edad = 25;

Persona p3 = new Persona();
p3.Nombre = "Maria";
p3.Apellido = "Altamirano";
p3.Edad = 14;

#endregion
List<Persona> Personas = new List<Persona>();

Personas.Add(p1);
Personas.Add(p2);
Personas.Add(p3);

//Persona PersonaBusqueda = Personas.FindLast(x => x.Nombre == "Maria");

List<Persona> PersonaBusqueda = Personas.FindAll(x => x.Nombre == "Maria" && x.Apellido == "Centeno");

foreach (var item in PersonaBusqueda)
{
    Console.WriteLine(item.Apellido);
}




class Persona
{
    public string Nombre;
    public string Apellido;
    public int Edad;
}
