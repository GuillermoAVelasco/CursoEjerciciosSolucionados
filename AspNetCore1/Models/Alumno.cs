namespace AspNetCore1.Models
{
    public class Alumno : IPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Alumno(string nombre = "XXXX", string apellido = "YYYY")
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + " Apellido: " + Apellido;
        }
    }
}
