using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TP3.Models;

namespace TP3.Controllers
{
    public class CustomerController : Controller
    {   private readonly ApplicationDbContext _db;
        public CustomerController(ApplicationDbContext _db)
        {
            this._db = _db; 
        }
        public IActionResult Index()
        {
            var customers = _db.Customers.ToList();
            return View(customers);
        }
        public IActionResult Create()
        {
            var members = _db.MembershipTypes.ToList();
            ViewBag.member = members.Select(members => new SelectListItem()
            {
                Text = members.Id.ToString(),
                Value = members.Id.ToString()
            });
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer c)
        {
            ViewBag.Errors = ModelState.Values
            .SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            if (!ModelState.IsValid)
            {
                var members = _db.MembershipTypes.ToList();
                ViewBag.member = members.Select(members => new SelectListItem()
                {
                    Text = members.Id.ToString(),
                    Value = members.Id.ToString()
                });
                return View();
            }
            c.Id = new Guid();
            _db.Customers.Add(c);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
