namespace AspNetCore1.Models
{
    public class Profesor : IPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; } 
        public string Materia { get; set; }

        public Profesor(string nombre="XXXX",string apellido="YYYY",string materia="ZZZZ")
        {
            Nombre = nombre;
            Apellido = apellido;
            Materia = materia;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + " Apellido: " + Apellido + " Materia: " + Materia;
        }
    }
}
