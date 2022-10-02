using Inicializadores.clases;

Persona persona = new Persona();
persona.Id = 1;
persona.Nombre = "Juan";
persona.Edad = 17;

Persona persona2 = new Persona
{
    Id = 2,
    Nombre = "Sergio",
    Edad = 27
};

int[] vectorEntero = new int[]
{
    1,
    2,
    3,
    4
};

Console.WriteLine("Mostrando las Personas creadas de la forma tradicional y usando inicializadores");
Console.WriteLine(persona);
Console.WriteLine(persona2);
Console.WriteLine();

Console.WriteLine("Mostrando Array de Enteros usando inicializadores se convirtio en lista para mostrarlo con menos lineas");
vectorEntero.ToList().ForEach(x => Console.WriteLine(x));