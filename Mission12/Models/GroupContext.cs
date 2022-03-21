using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Mission12.Models
{
    public class GroupContext : DbContext
    {
        public GroupContext(DbContextOptions<GroupContext> options) : base(options)
        {
        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Group>().HasData(
                new Group { GroupId = 1, GroupName = "Carlock", GroupSize = 2, Email = "codytest@gmail.com", Phone = "253-555-5555" },
                new Group { GroupId = 2, GroupName = "Provo 6", GroupSize = 15, Email = "provotest@gmail.com", Phone = "801-555-5555" },
                new Group { GroupId = 3, GroupName = "YSA 128", GroupSize = 3, Email = "ysatest@gmail.com", Phone = "911-555-5555" }
            );
            mb.Entity<Appointment>().HasData(
                new Appointment
                {
                    AppointmentId = 1,
                    Description = "Morning",
                    StartDate = DateTime.ParseExact("03/05/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 08:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false,
                    GroupId = 0,
                },
                new Appointment
                {
                    AppointmentId = 2,
                    Description = "Mid Morning",
                    StartDate = DateTime.ParseExact("03/05/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 09:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false,
                    GroupId = 0,
                },
                new Appointment
                {
                    AppointmentId = 3,
                    Description = "Late Morning",
                    StartDate = DateTime.ParseExact("03/05/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 10:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false,
                    GroupId = 0,
                },
                new Appointment
                {
                    AppointmentId = 4,
                    Description = "Afternoon",
                    StartDate = DateTime.ParseExact("03/05/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 12:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false,
                    GroupId = 0,
                },
                new Appointment
                {
                    AppointmentId = 5,
                    Description = "Mid Afternoon",
                    StartDate = DateTime.ParseExact("03/05/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false,
                    GroupId = 0,
                },
                new Appointment
                {
                    AppointmentId = 6,
                    Description = "Late Afternoon",
                    StartDate = DateTime.ParseExact("03/05/2022 14:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 14:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false,
                    GroupId = 0,
                },
                new Appointment
                {
                    AppointmentId = 7,
                    Description = "Evening",
                    StartDate = DateTime.ParseExact("03/05/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 17:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false,
                    GroupId = 0,
                },
                new Appointment
                {
                    AppointmentId = 8,
                    Description = "Mid Evening",
                    StartDate = DateTime.ParseExact("03/05/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 18:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false,
                    GroupId = 0,
                },
                new Appointment
                {
                    AppointmentId = 9,
                    Description = "Late Evening",
                    StartDate = DateTime.ParseExact("03/05/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 19:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false,
                    GroupId = 0,
                });
        }
    }
}
