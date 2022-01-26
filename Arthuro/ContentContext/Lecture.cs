using Arthuro.ContentContext.Enums;
using Arthuro.SharedContext;

namespace Arthuro.ContentContext
{
      public class Lecture : Base
    {
        public int ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}