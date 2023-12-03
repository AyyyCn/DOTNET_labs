using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TP3.Models;

namespace TP3.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MovieController(ApplicationDbContext db)
        {
            this._db = db;
        }


        public IActionResult Index()
        {
            var movies = this._db.Movies.ToList();
            return View(movies);
        }

        public IActionResult Create() { return (View()); }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
            return (RedirectToAction(nameof(Index)));
               
        }

        [HttpGet("/Movie/Edit/{MovieId}")]
        public IActionResult Edit(String MovieId)
        {
            var movie= _db.Movies.ToList().SingleOrDefault(c=>c.Id.ToString()==MovieId);
            if(movie==null)
            {
                return (Content("Error 404 : Movie "+ MovieId +" not found"));
            }
            return (View(movie)); 
        }

        [HttpPost]

        public IActionResult Edit(Movie movie)
        {
            _db.Movies.Update(movie);
            _db.SaveChanges();
            return(RedirectToAction(nameof(Index)));
        }

        public IActionResult Delete(Movie movie)
        {
            if(movie!=null) {
                _db.Movies.Remove(movie);
                _db.SaveChanges();
            }
            return(RedirectToAction(nameof(Index)));

        }

        [HttpGet("/Movie/Details/{MovieId}")]
        public IActionResult Details(String MovieId)
        {
            var movie = _db.Movies.ToList().SingleOrDefault(c => c.Id.ToString() == MovieId);
            if (movie == null)
            {
                return (Content("Error 404 : Movie " + MovieId + " not found"));
            }
            return (View(movie));
        }
    }
}
