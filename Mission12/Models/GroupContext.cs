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
        { }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Group>().HasData(
                new Group { GroupId = 1, GroupName = "Carlock",GroupSize=2,Email="codytest@gmail.com",Phone="253-555-5555"},
                new Group { GroupId = 2, GroupName = "Provo 6", GroupSize = 15, Email = "provotest@gmail.com", Phone = "801-555-5555" },
                new Group { GroupId = 3, GroupName = "YSA 128", GroupSize = 3, Email = "ysatest@gmail.com", Phone = "911-555-5555" }
            );

            mb.Entity<Appointment>().HasData(
                //day 1
                new Appointment
                {
                    AppointmentId = 1,
                    Description = "Morning",
                    StartDate = DateTime.ParseExact("03/05/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 08:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = true,
                    GroupId = 1
                     
                },
                new Appointment
                {
                    AppointmentId = 2,
                    Description = "Mid Morning",
                    StartDate = DateTime.ParseExact("03/05/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 09:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = true,
                    GroupId = 2
                     
                },
                new Appointment
                {
                    AppointmentId = 3,
                    Description = "Late Morning",
                    StartDate = DateTime.ParseExact("03/05/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 10:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = true,
                    GroupId = 3
                     
                },
                new Appointment
                {
                    AppointmentId = 4,
                    Description = "Afternoon",
                    StartDate = DateTime.ParseExact("03/05/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 12:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 5,
                    Description = "Mid Afternoon",
                    StartDate = DateTime.ParseExact("03/05/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 6,
                    Description = "Late Afternoon",
                    StartDate = DateTime.ParseExact("03/05/2022 14:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 14:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 7,
                    Description = "Evening",
                    StartDate = DateTime.ParseExact("03/05/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 17:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 8,
                    Description = "Mid Evening",
                    StartDate = DateTime.ParseExact("03/05/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 18:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 9,
                    Description = "Late Evening",
                    StartDate = DateTime.ParseExact("03/05/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("03/05/2022 19:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                //day two
                new Appointment
                {
                    AppointmentId = 10,
                    Description = "Morning",
                    StartDate = DateTime.ParseExact("04/05/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("04/05/2022 08:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     


                },
                new Appointment
                {
                    AppointmentId = 11,
                    Description = "Mid Morning",
                    StartDate = DateTime.ParseExact("04/05/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("04/05/2022 09:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 12,
                    Description = "Late Morning",
                    StartDate = DateTime.ParseExact("04/05/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("04/05/2022 10:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 13,
                    Description = "Afternoon",
                    StartDate = DateTime.ParseExact("04/05/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("04/05/2022 12:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
        
                },
                new Appointment
                {
                    AppointmentId = 14,
                    Description = "Mid Afternoon",
                    StartDate = DateTime.ParseExact("04/05/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("04/05/2022 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 15,
                    Description = "Late Afternoon",
                    StartDate = DateTime.ParseExact("04/05/2022 14:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("04/05/2022 14:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 16,
                    Description = "Evening",
                    StartDate = DateTime.ParseExact("04/05/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("04/05/2022 17:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 17,
                    Description = "Mid Evening",
                    StartDate = DateTime.ParseExact("04/05/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("04/05/2022 18:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 18,
                    Description = "Late Evening",
                    StartDate = DateTime.ParseExact("04/05/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("04/05/2022 19:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                //day 3
                new Appointment
                {
                    AppointmentId = 19,
                    Description = "Morning",
                    StartDate = DateTime.ParseExact("05/05/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("05/05/2022 08:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 20,
                    Description = "Mid Morning",
                    StartDate = DateTime.ParseExact("05/05/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("05/05/2022 09:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 21,
                    Description = "Late Morning",
                    StartDate = DateTime.ParseExact("05/05/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("05/05/2022 10:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 22,
                    Description = "Afternoon",
                    StartDate = DateTime.ParseExact("05/05/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("05/05/2022 12:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 23,
                    Description = "Mid Afternoon",
                    StartDate = DateTime.ParseExact("05/05/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("05/05/2022 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 24,
                    Description = "Late Afternoon",
                    StartDate = DateTime.ParseExact("05/05/2022 14:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("05/05/2022 14:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 25,
                    Description = "Evening",
                    StartDate = DateTime.ParseExact("05/05/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("05/05/2022 17:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 26,
                    Description = "Mid Evening",
                    StartDate = DateTime.ParseExact("05/05/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("05/05/2022 18:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 27,
                    Description = "Late Evening",
                    StartDate = DateTime.ParseExact("05/05/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("05/05/2022 19:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                //day 4
                new Appointment
                {
                    AppointmentId = 28,
                    Description = "Morning",
                    StartDate = DateTime.ParseExact("06/05/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("06/05/2022 08:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     


                },
                new Appointment
                {
                    AppointmentId = 29,
                    Description = "Mid Morning",
                    StartDate = DateTime.ParseExact("06/05/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("06/05/2022 09:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 30,
                    Description = "Late Morning",
                    StartDate = DateTime.ParseExact("06/05/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("06/05/2022 10:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 31,
                    Description = "Afternoon",
                    StartDate = DateTime.ParseExact("06/05/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("06/05/2022 12:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 32,
                    Description = "Mid Afternoon",
                    StartDate = DateTime.ParseExact("06/05/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("06/05/2022 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 33,
                    Description = "Late Afternoon",
                    StartDate = DateTime.ParseExact("06/05/2022 14:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("06/05/2022 14:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 34,
                    Description = "Evening",
                    StartDate = DateTime.ParseExact("06/05/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("06/05/2022 17:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 35,
                    Description = "Mid Evening",
                    StartDate = DateTime.ParseExact("06/05/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("06/05/2022 18:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 36,
                    Description = "Late Evening",
                    StartDate = DateTime.ParseExact("06/05/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("06/05/2022 19:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                //day 5
                new Appointment
                {
                    AppointmentId = 37,
                    Description = "Morning",
                    StartDate = DateTime.ParseExact("07/05/2022 08:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("07/05/2022 08:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 38,
                    Description = "Mid Morning",
                    StartDate = DateTime.ParseExact("07/05/2022 09:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("07/05/2022 09:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 39,
                    Description = "Late Morning",
                    StartDate = DateTime.ParseExact("07/05/2022 10:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("07/05/2022 10:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 40,
                    Description = "Afternoon",
                    StartDate = DateTime.ParseExact("07/05/2022 12:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("07/05/2022 12:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 41,
                    Description = "Mid Afternoon",
                    StartDate = DateTime.ParseExact("07/05/2022 13:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("07/05/2022 13:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 42,
                    Description = "Late Afternoon",
                    StartDate = DateTime.ParseExact("07/05/2022 14:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("07/05/2022 14:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 43,
                    Description = "Evening",
                    StartDate = DateTime.ParseExact("07/05/2022 17:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("07/05/2022 17:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 44,
                    Description = "Mid Evening",
                    StartDate = DateTime.ParseExact("07/05/2022 18:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("07/05/2022 18:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                },
                new Appointment
                {
                    AppointmentId = 45,
                    Description = "Late Evening",
                    StartDate = DateTime.ParseExact("07/05/2022 19:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    EndDate = DateTime.ParseExact("07/05/2022 19:45:00", "dd/MM/yyyy HH:mm:ss", null),
                    Booked = false
                     
                }
                );
        }

    }



}
