namespace _05_Nulleables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.1)	Definir un entero nulleables
            Nullable<int> entero = null;
            int? entero2 = 2;

            //1.2)  y escribir un ejemplo de cada uno de los métodos y propiedades que ofrece la clase genérica Nullable<T>

            //•	HasValue
            Console.WriteLine("Primer Ejemplo entero null");
            if (entero.HasValue)    Console.WriteLine(entero.Value); //•	Value
            else Console.WriteLine("Valor por Defecto"+entero.GetValueOrDefault()); //•	GetValueOrDefault
            Console.WriteLine();

            Console.WriteLine("Segunfo Ejemplo entero no null");
            //•	HasValue
            if (entero2.HasValue) Console.WriteLine(entero2.Value); //•	Value
            else Console.WriteLine("Valor por Defecto" + entero2.GetValueOrDefault()); //•	GetValueOrDefault
            Console.WriteLine();

            Console.WriteLine("Primer Ejemplo datetime null");
            //2)Repetir los pasos del ejercicio 1 pero con un DateTime.
            Nullable<DateTime> fecha = null;
            DateTime? fecha2 = new DateTime();

            //•	HasValue
            if (fecha.HasValue) Console.WriteLine(fecha.Value); //•	Value
            else Console.WriteLine("Valor por Defecto" + fecha.GetValueOrDefault()); //•	GetValueOrDefault
            Console.WriteLine();

            Console.WriteLine("segundo Ejemplo datetime no null");
            //•	HasValue
            if (fecha2.HasValue) Console.WriteLine(fecha2.Value); //•	Value
            else Console.WriteLine("Valor por Defecto" + fecha2.GetValueOrDefault()); //•	GetValueOrDefault

        }
    }
}