using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Genericos.clases
{
    public class PersonaRepository : IPersonaRepository<Persona>
    {
        List<Persona> _personaList= new List<Persona>();

        public void Delete(int persona)
        {
            var recuperado = GetId(persona);
            _personaList.Remove(recuperado);
        }

        public IEnumerable<Persona> GetAll()
        {
            return _personaList;
        }

        public Persona GetId(int personaId)
        {
            Persona per = _personaList.Where(x => x.Id == personaId).ToList().First();
            return per;
        }

        public void Insert(Persona persona)
        {
            _personaList.Add(persona);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Persona persona)
        {
            var recuperado = GetId(persona.Id);
            recuperado.Id = persona.Id;
            recuperado.Nombre = persona.Nombre;
            recuperado.Edad = persona.Edad;
        }

    }
}
