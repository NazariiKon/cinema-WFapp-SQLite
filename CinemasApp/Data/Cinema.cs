namespace CinemasApp.Data
{
    public class Cinema
    {
        public Cinema()
        {

        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string Street { get; set; }
        public long CategoryId { get; set; }
        public long Capacity { get; set; }
        public long NumberHalls { get; set; }
    }

}