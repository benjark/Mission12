using Microsoft.AspNetCore.Mvc;
using Mission12.Models;

namespace Mission12.Controllers
{
    public class HomeController : Controller
    {

        private GroupContext context { get; set; }
       

        public HomeController(GroupContext temp)
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
        public IActionResult Form(Group g)
        {
            context.Add(g);
            context.SaveChanges();

            return View();
        }
        [HttpGet]
        public IActionResult ViewAppointments(Appointment a)
        {
            //var appointments = AppointmentContext.Appointments
                
            //    .OrderBy(a => a.AppointmentId)
            //    .ToList();

            return View();

        }
    }
}
