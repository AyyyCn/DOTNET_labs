using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var movies = _db.movies.ToList();
            return View(movies);
        }

       
        [HttpGet("Movie/Details/{id}")]
        public IActionResult Details(int? id)
        {
            if (id == null) return Content("id not found");
            var testDetails = _db.movies.ToList().FirstOrDefault(c => c.Id == id);
            return View(testDetails);

        }
        

        public IActionResult Create()

        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            _db.movies.Add(movie);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var movie = _db.movies.ToList().FirstOrDefault(c => c.Id == id);
            _db.movies.Remove(movie);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var movie = _db.movies.ToList().FirstOrDefault(c => c.Id == id);
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Movie movie)
        {
            _db.movies.Update(movie);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



    }
}
