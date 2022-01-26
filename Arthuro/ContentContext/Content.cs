using Arthuro.SharedContext;

namespace Arthuro.ContentContext
{
    //é uma classe abstrata, que não tem sentido ser instanciada
    public abstract class Content : Base
    {
        //Método construtor CTOR
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
        
        public string Title { get; set; }
        public string Url { get; set; }
    }

    
}