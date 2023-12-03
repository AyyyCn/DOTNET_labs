using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP3.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public DateTime MovieAdded { get; set; }

        public Guid? GenreId { get; set; }

        [ForeignKey(nameof(GenreId))]

        public virtual Genre? Genre { get; set; }
    }
}
