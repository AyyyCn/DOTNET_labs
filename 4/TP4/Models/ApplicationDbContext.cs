using Microsoft.EntityFrameworkCore;

namespace TP4.Models
{
    public class ApplicationDbContext : DbContext
    {   
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public ApplicationDbContext(DbContextOptions options)
:       base(options)
        {
        }
    }
}
