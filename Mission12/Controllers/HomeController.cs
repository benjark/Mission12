using System.Dynamic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission12.Models;

namespace Mission12.Controllers
{
    public class HomeController : Controller
    {

        private IGroupRepository repo;
        private IAppointmentRepository apprepo;
       

        public HomeController(IGroupRepository temp, IAppointmentRepository temp2)
        {
            repo = temp;
            apprepo = temp2;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form(Group g)
        {
            return View(g);
        }
        [HttpPost]
        public IActionResult Form(int appointmentId, Group g)
        {
            repo.CreateGroup(g);
            var app = apprepo.Appointments.FirstOrDefault(x => x.AppointmentId == appointmentId);
            app.Group = repo.Groups.FirstOrDefault(x => x.GroupId == g.GroupId);
            apprepo.SaveAppointment(app);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ViewAppointments(Appointment a)
        {
            var appointments = apprepo.Appointments;
            
            return View(appointments);
        }

        [HttpGet]
        public IActionResult Edit(int appointmentId)
        {
            ViewBag.Cat = apprepo.Appointments.ToList();
            var appt = apprepo.Appointments.Single(x => x.AppointmentId == appointmentId);
            return View("AddAppt", appt);
        }

        [HttpPost]
        public IActionResult Edit(Appointment a)
        {
        
            apprepo.SaveAppointment(a);
            return RedirectToAction("ViewAppointments");
        }

        [HttpGet]
        public IActionResult SignUp(Appointment a)
        {
            var appointments = apprepo.Appointments;

            {
                appointments = apprepo.Appointments
                .Where(a => a.Booked == false);

            };
            return View(appointments);
        }
        [HttpGet]
        public IActionResult Delete(int appointmentId)
        {
            Appointment appt = apprepo.Appointments.Single(x => x.AppointmentId == appointmentId);
                apprepo.DeleteAppointment(appt);
            return RedirectToAction("ViewAppointment");
        }

    }
}
