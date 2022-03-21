using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public interface IAppointmentRepository
    {
        public IQueryable<Appointment> Appointments { get; }

        public void SaveAppointment(Appointment appointment);

        public void DeleteAppointment(Appointment appointment);
    }
}
