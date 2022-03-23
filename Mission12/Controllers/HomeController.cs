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
        public IActionResult Form()
        {
            return View();
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
            var appointments = apprepo.Appointments
                .Where(a => a.Booked == true);

            return View(appointments);
        }
        [HttpGet]
        public IActionResult Edit(int appointmentId)
        {
            int? g = apprepo.Appointments.SingleOrDefault(x => x.AppointmentId == appointmentId).GroupId;
            Group group = repo.Groups.SingleOrDefault(x => x.GroupId == g);
            return View("Form", group);
        }

        [HttpPost]
        public IActionResult Edit(int appointmentId, Group g)
        {
            Appointment a = apprepo.Appointments.FirstOrDefault(x => x.AppointmentId == appointmentId);
            a.Group = g;
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
            return RedirectToAction("Index");

        }

    }
}
