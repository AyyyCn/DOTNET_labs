using Microsoft.AspNetCore.Mvc;
using TP4.Services.Services;

namespace TP4.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieService _movieService;

        public MovieController(MovieService movieService)
        {
            _movieService = movieService ?? throw new ArgumentNullException(nameof(movieService));
        }
        public IActionResult Index()
        {   var movies = _movieService._repository.GetAllMovies();
            return View(movies);
        }
        
    }
}
