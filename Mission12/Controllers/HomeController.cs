using Microsoft.AspNetCore.Mvc;
using Mission12.Models;
using System.Linq;

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

        [HttpGet]
        public IActionResult Edit(int appointmentId)
        {
            ViewBag.Cat = context.Something.ToList();
            var appt = context.Responses.Single(x => x.AppointmentId == appointmentId);
            return View("AddAppt", appt);
        }

        [HttpPost]
        public IActionResult Edit(Appointment a)
        {
            context.Update(a);
            context.SaveChanges();
            return RedirectToAction("ViewAppointment");
        }

        [HttpGet]
        public IActionResult Delete(int appointmentId)
        {
            Appointment appt = context.Responses.Single(x => x.AppointmentId == appointmentId);
            context.Responses.Remove(appt);
            context.SaveChanges();
            return RedirectToAction("ViewAppointment");
        }

    }
}
