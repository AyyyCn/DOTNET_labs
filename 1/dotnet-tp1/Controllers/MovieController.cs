using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            List<Movie> movies = new List<Movie>()
            {
                new Movie{Name="The Shawshank Redemption"},
                new Movie{Name="Inception"}, // Best Movie ever
                new Movie{Name="Forrest Gump"}
            };

            return View(movies);
        }
        public IActionResult Edit(int id)
        {
            return Content("Test Id" + id);
        }
        
        
        public IActionResult ByRelease(int year ,int month)
        {
            return Content("Month :"+month+", Year :"+year);
        }
    }
}
