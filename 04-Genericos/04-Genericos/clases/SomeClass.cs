using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Genericos.clases
{
    public class SomeClass<T> where T : class 
    {
        public SomeClass(T algo)
        {
            Console.WriteLine("Se creo con algo");
        }

    }
}
