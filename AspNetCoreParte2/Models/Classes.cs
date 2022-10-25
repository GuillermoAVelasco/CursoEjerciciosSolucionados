namespace AspNetCoreParte2.Models
{
    public class Blog
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }

    public interface IPersona
    {
        public string getDatos();
    }

    public class Maestro: IPersona
    {
        public string Name { get; set; }
        public int Edad { get; set; }
        public string Materia { get; set; }

        public string getDatos()
        {
            return $"{Name} : {Edad} > Materia que dicta: {Materia}";
        }
    }


    //---


    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class GlossDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class Root
    {
        public Glossary glossary { get; set; }
    }
}
