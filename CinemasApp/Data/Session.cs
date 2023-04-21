namespace CinemasApp.Data
{
    public class Session
    {
        public long Id { get; set; }
        public long CinemaId { get; set; }
        public long MovieId { get; set; }
        public long Hall { get; set; }
        public string DataTime { get; set; }
        public long Price { get; set; }
        public string Info { get; set; }
    }

}