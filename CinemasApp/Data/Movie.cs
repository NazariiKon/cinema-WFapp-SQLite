namespace CinemasApp.Data
{
    public class Movie
    {
        public Movie()
        {
            
        }

        public long Id { get; set; }
        public string Director { get; set; }
        public string Operator { get; set; }
        public string Actors { get; set; }
        public long GenreId { get; set; }
        public string Poster { get; set; }
        public string Awards { get; set; }
        public string Duration { get; set; }
        public string Name { get; set; }
    }

}