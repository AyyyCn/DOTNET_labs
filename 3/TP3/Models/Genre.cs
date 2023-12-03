using System.ComponentModel.DataAnnotations;

namespace TP3.Models
{
    public class Genre
    {
      public Guid Id { get; set; }
        [Required]
        public string GenreName { get; set; }
      
      public virtual ICollection<Movie>? Movies { get; set; }
    }
}
