namespace ThundraLoggingExample
{
    public class Album
    {
        public string Name { get; set; }
        public string Band { get; set; }
        public int Year { get; set; }

        public Album(string Name, string Band, int Year)
        {
            this.Name = Name;
            this.Band = Band;
            this.Year = Year;
        }
    }
}