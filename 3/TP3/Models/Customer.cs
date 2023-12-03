using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP3.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Guid? MembershipTypeId { get; set; }
        [ForeignKey(nameof(MembershipTypeId))]
        public virtual MembershipType? MembershipType { get; set; }
        public virtual ICollection<Movie>? Movies { get; set; }
    }
}
