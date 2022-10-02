
namespace _09_Metodos_Extensores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)	Escriba un método extensor que extienda la clase String y que permite poner en mayúsculas
            //la primera letra de cada palabra de una cadena cualquiera, por ejemplo “Bienvenidos A El Curso De Dotnet”.

            Console.WriteLine("bienvenidos a el curso de dotnet".primerLetraMayuscula());

            //2)	Escriba un método extensor que permita calcular los días que ha vivido una persona a
            //partir de su fecha de nacimiento, el método debe recibir como parámetro la clase persona.
            Persona persona = new Persona();
            persona.FechaNacimiento = new DateTime(2000, 1, 1);
            Console.WriteLine($"Dias Vididos al 2020 {new DateTime(2020,12,31).diasVividos(persona)}");

            Console.WriteLine($"Dias Vididos al dia de Hoy {DateTime.Today.diasVividos(persona)}");

            //3)	Escriba un método extensor que devuelva una palabra invertida, por ejemplo, si el método recibe la cadena
            //“hoy es lunes” deberá devolver “senul se yoh”.
            Console.WriteLine("hoy es lunes".oracionInvertida());

        }
    }

    public static class stringExtension
    {
        public static string? primerLetraMayuscula(this string str)
        {
            string cadena="";
            var vector=str.ToArray();
            if (vector.Length > 0)
            {
                cadena = vector[0].ToString().ToUpper();
                for (int i=1; i<vector.Length;i++)
                     cadena += (vector[i - 1] == ' ')? vector[i].ToString().ToUpper(): vector[i].ToString();

                return cadena;
            }
            return null;
            
        }

        public static string oracionInvertida(this string str)
        {
            string cadena = "";
            var vector = str.ToCharArray();
            if (vector.Length > 0)
            {
                Array.Reverse(vector);
                return new string(vector);
            }
            return null;

        }
    }

    public static class DateTimeExtension
    {
        public static int diasVividos(this DateTime date, Persona persona)
        {
           return ((TimeSpan)(date - persona.FechaNacimiento)).Days;

        }
    }

    public class Persona
    {
        public DateTime FechaNacimiento { get; set; }
    }

}