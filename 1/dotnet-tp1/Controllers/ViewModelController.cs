using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ViewModelController : Controller
    {
        public IActionResult Index()
        {   Movie movie = new Movie() { Name = "Inception" };
            List<Customer> customers = new List<Customer>()
            { new Customer{Name="Adam"} 
            , new Customer{Name="Adam2"}
            , new Customer{Name="Adam3"}
            };
            ViewModel viewModel = new ViewModel() { Movie=movie , Customers=customers};
            return View(viewModel);
        }

        public IActionResult Client(int id)
        {
            Movie movie = new Movie() { Name = "Inception" };
            List<Customer> customers = new List<Customer>()
            { new Customer{Name="Adam"}
            , new Customer{Name="Adam2"}
            , new Customer{Name="Adam3"}
            };
            ViewModel viewModel = new ViewModel() { Movie = movie, Customers = customers };

            Customer customer1=null;
            foreach(var customer in viewModel.Customers )
            {
                if(customer.Id == id)
                {
                    customer1 = customer;
                    break;

                }
            }
            if(customer1==null)
            {
                return Content("Error 404 : not found");
            }
            return View(customer1);
        }
    }
}
