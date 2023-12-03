using TP4.Models;

namespace TP4.Repositories
{
    public class MovieRepository
    {
        public readonly ApplicationDbContext _db;
        public MovieRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Movie GetMovieById(int id)
        {
            return _db.Movies.SingleOrDefault(x => x.Id == id);
        }
        public Movie GetMovieByName(string name)
        {
            return _db.Movies.SingleOrDefault(y => y.Name == name);
        }

        public List<Movie> GetAllMovies() {
            return (_db.Movies).ToList();
        }

        public List<Movie> GetMoviesByGenre(int genre)
        {
            return (_db.Movies.Where(item => item.GenreId == genre).ToList());
        }
        public void DeleteMovieById(int id)
        {
            Movie movie=this.GetMovieById(id);
            _db.Movies.Remove(movie);
            _db.SaveChanges();
        }

        public void AddMovie(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
        }
    }
}
