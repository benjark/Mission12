using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Mission12.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Booked { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}