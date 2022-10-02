using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Inicializadores.clases
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }


        public override string ToString()
        {
            return Nombre + ' ' + Edad;
        }

        public void mismoTipoparaOperar<Clase>(Clase clase) where Clase : class
        {
            Console.WriteLine((this.GetType()==clase.GetType())?"Son del mismo Tipo":"No lo son");
        }

        public static string Serializar<Clase>(Clase obj) where Clase : class
        {
            var serializador = new XmlSerializer(typeof(Persona));
            var stringWriter = new StringWriter();
            var escritor = XmlWriter.Create(stringWriter);
            serializador.Serialize(escritor, obj);


            return stringWriter.ToString();
        }


    }
}
