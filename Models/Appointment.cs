using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public class Appointment
    {
        [Required]
        public int AppointmentID { get; set; } //appointment id

        [Required]
        public string Day { get; set; } //day of week for temple visit

        [Required]
        public int Hour { get; set; } //hour of day

        [Required]
        public string AmPm { get; set; } //whether it is morning or afternoon (AM or PM) 

        [Required]
        public bool Available { get; set; } = true; //whether the appointment is available or not

    }

}
