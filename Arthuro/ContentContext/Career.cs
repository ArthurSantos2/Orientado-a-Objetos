namespace Arthuro.ContentContext
{
    public class Career : Content
    {
        //método construtor
        public Career(string title, string url)
            :base(title, url)
        {
            Itemns = new List<CareerItem>();
        }
        public IList<CareerItem> Itemns {get; set;}
        //expression body, quando há apenas uma linha de get e não há set, logo pode utilizar da função => para dar o retorno
        public int TotalCourses => Itemns.Count;

        
    }
    
}