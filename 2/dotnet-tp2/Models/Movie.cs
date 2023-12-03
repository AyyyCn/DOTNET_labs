using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Name { get; set; }

      
        public Movie()
        {
        }
    }
}
