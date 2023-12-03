using Microsoft.EntityFrameworkCore;

namespace TP3.Models
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
            
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            string GenreJSon = System.IO.File.ReadAllText("Genres.Json");
            List<Genre>? genres = System.Text.Json.
            JsonSerializer.Deserialize<List<Genre>>(GenreJSon);
            //Seed to categorie
            foreach (Genre c in genres)
                model.Entity<Genre>()
                .HasData(c);

            string MembershipTypeJSon = System.IO.File.ReadAllText("MembershipTypes.Json");
            List<MembershipType>? membership = System.Text.Json.
            JsonSerializer.Deserialize<List<MembershipType>>(MembershipTypeJSon);
            //Seed to categorie
            foreach (MembershipType m in membership)
                model.Entity<MembershipType>()
                .HasData(m);
        }


    }
}
