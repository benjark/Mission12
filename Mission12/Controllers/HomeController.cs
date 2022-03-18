using Microsoft.AspNetCore.Mvc;
using Mission12.Models;

namespace Mission12.Controllers
{
    public class HomeController : Controller
    {

        private AppointmentContext context { get; set; }
       

        public HomeController(AppointmentContext temp)
        {
            context = temp;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Appointment a)
        {
            context.Add(a);
            context.SaveChanges();

            return View();
        }
    }
}
