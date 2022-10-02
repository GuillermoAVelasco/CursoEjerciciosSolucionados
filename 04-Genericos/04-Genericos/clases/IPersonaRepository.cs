using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4)	Dada la siguiente clase convertir la misma a Genéricas, escriba el/las constraints que crea necesarias

namespace _04_Genericos.clases
{
    internal interface IPersonaRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Persona GetId(int personaId);
        void Insert(T persona);
        void Update(T persona); 
        void Delete(int persona);
        void Save();
    }
}
