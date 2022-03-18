using System;
using Microsoft.EntityFrameworkCore;

namespace Mission12.Models
{
    public class AppointmentContext : DbContext
    {
        // Setting up the standard options for DbContext
        public AppointmentContext (DbContextOptions<AppointmentContext> options) : base (options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
