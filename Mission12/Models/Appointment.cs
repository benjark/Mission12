using System;
using System.ComponentModel.DataAnnotations;

namespace Mission12.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int AppointmentId { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public string GroupSize { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
