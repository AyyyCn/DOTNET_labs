namespace WebApplication1.Models
{
    public class Movie
    {
        private static int nextId = 1; 

        public int Id { get; private set; }
        public string Name { get; set; }

        public Movie()
        {
            Id = nextId++;
            Name = "Default";
        } 
    }
}
