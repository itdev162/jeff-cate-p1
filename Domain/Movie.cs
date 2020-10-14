using System;

namespace Domain
{
    public class Movie
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Synopsis { get; set; }
    }
}