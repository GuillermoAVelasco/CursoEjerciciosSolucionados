using _04_Genericos.clases;

//1) método genérico que reciba 2 parametros uno por valor y otro por referencia
Console.WriteLine("Método genérico que reciba 2 parametros uno por valor y otro por referencia");

//Tipo Primitivo y String (Clase)
comparadorTiposDatos(1, "hola");
StructPersona spersona = new StructPersona();

//Struct Persona y Clase Persona
Persona persona = new Persona();
persona.Nombre = "Pedro";
persona.Edad = 18;
comparadorTiposDatos(spersona, persona);


//2) Serializado
Console.WriteLine("2) Serializado");
Console.WriteLine(Persona.Serializar(persona));
Console.WriteLine();

//3)	Escribir una clase genérica SomeClass 
Console.WriteLine("3 Escribir una clase generica SomeClass se uso tambien el Adicional ");
SomeClass<Persona> someClass = new SomeClass<Persona>(persona);
persona.mismoTipoparaOperar(someClass);
Console.WriteLine();

//adicional ejemplo de uso T:class
Console.WriteLine("Adicional ejemplo de uso T:class");
Console.WriteLine("** Son dos Objetos del Mismo Tipo **");

var persona2 = new Persona();
persona.mismoTipoparaOperar(persona2);
Console.WriteLine();

Console.WriteLine("** Son dos Objetos del Mismo Tipo **");
string cadena = "algo va aqui";
persona.mismoTipoparaOperar(cadena);
Console.WriteLine();


//4)	Dada la siguiente clase convertir la misma a Genéricas, escriba el/las constraints que crea necesarias
Console.WriteLine("4) Dada la siguiente clase convertir la misma a Genéricas, escriba el / las constraints que crea necesarias");
var lpersona = new PersonaRepository();

Console.WriteLine("Insercion"); 
lpersona.Insert(persona);
lpersona.Insert(new Persona { Id = 2, Edad = 1, Nombre = "Juan" });

Console.WriteLine("Update"); 
lpersona.Update(new Persona { Id = 2, Edad = 18, Nombre = "Juan" });

Console.WriteLine("Listado");
string cad = "";
lpersona.GetAll().ToList<Persona>().ForEach(per => cad += per);
Console.WriteLine(cad);

Console.WriteLine("Delete");
lpersona.Delete(2);

Console.WriteLine("Listado");
cad = "";
lpersona.GetAll().ToList<Persona>().ForEach(per => cad += per);
Console.WriteLine(cad);

//1) método genérico que reciba 2 parametros uno por valor y otro por referencia
void comparadorTiposDatos<Valor, Referencia>(Valor obj1, Referencia obj2)
where Valor : struct
where Referencia : class
{
    Console.WriteLine("----------- Tipo x Valor ----------");
    Console.WriteLine("> Tipo de Datos: "+obj1.GetType()+" > Valor: "+obj1);
    Console.WriteLine();
    Console.WriteLine("--------- Tipo x Referencia --------");
    Console.WriteLine("> Tipo de Datos: " + obj2.GetType() + " > Valor: " + obj2);
    Console.WriteLine();
}

struct StructPersona
{
    public string nombre;
    public string apellido;
}