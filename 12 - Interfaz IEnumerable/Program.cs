namespace _12___Interfaz_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
             1) Enumere cuales son las propiedades y métodos de la interfaz IEnumerator
                propiedades:Current
                metodos:
                        MoveNext
                        Reset                        
             */

            //2) Cree una lista de enteros List<T> y recorra la misma sin utilizar foreach ni for
            IEnumerator<int> lista = (new List<int> { 1, 2, 3 }).GetEnumerator();
            lista.Reset();
            while (lista.MoveNext())
            {
                Console.WriteLine("elemento:"+lista.Current+" - "+ lista.GetHashCode());
            }

            
        }
    }
}