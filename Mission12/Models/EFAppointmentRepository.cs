using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class EFAppointmentRepository : IAppointmentRepository
    {
        public GroupContext context;

        public EFAppointmentRepository(GroupContext temp)
        {
            context = temp;
        }

        public IQueryable<Appointment> Appointments => context.Appointments;


        public void SaveAppointment(Appointment appointment)
        {
            var app = context.Appointments.First(a => a.AppointmentId == appointment.AppointmentId);
            app.Booked = true;
            context.SaveChanges();
        }
        public void DeleteAppointment(Appointment appointment)
        {
            var app = context.Appointments.First(a => a.AppointmentId == appointment.AppointmentId);
            app.Booked = false;
            app.GroupId = null;
            context.SaveChanges();
        }
    }
}
