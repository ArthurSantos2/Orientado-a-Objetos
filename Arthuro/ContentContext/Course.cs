using Arthuro.ContentContext.Enums;

namespace Arthuro.ContentContext
{
    public class Course : Content
    {
        //Método construtor CTOR
        public Course(string title, string url)
            :base(title, url)
        {
            //inicializarr evita erro de referência nula
            Modules = new List<Module>();
        }
        //Propriedades PROP
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }   
}