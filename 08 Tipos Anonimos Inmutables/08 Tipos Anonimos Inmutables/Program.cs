namespace _08_Tipos_Anonimos_Inmutables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)	Escriba dos ejemplos de tipos anónimos inmutable, uno de ellos debe ser el resultado de una consulta con Linq.
            var anonimoInmutable = new
            {
                nombre = "Pedro",
                edad = 17
            };

            Console.WriteLine($" Objeto inmutable Nombre: { anonimoInmutable.nombre} Edad: {anonimoInmutable.edad}");
            Console.WriteLine();

            //resulstado de operacion linq
            var listNombres = new List<Persona>()
            {
                new Persona{ Nombre="Juan", Edad= 17 },
                new Persona{ Nombre="Pedro", Edad= 20 },
                new Persona{ Nombre="Marcelo", Edad= 7 },
            };

           var listadoSoloNombres = listNombres.Select(x => new { nombre=x.Nombre }).ToList();

            Console.WriteLine("Mostrando resultados de lista luego de una operacion con linq con objetos inmutables");
            listadoSoloNombres.ForEach(x => Console.WriteLine(x.nombre));
            Console.WriteLine();

            var listadoSoloNombres2 = listNombres.Where(x=> x.Edad>10).Select(x => new { nombre = x.Nombre }).ToList();

            Console.WriteLine("Mostrando resultados de aquellas personas con edad mayor a 10");
            listadoSoloNombres2.ForEach(x => Console.WriteLine(x.nombre));


        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}