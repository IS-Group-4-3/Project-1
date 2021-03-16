using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int AppointmentID { get; set; } //appointment id

        [Required]
        public DateTime Timeslot { get; set; } //timeslot for temple visit 

        [Required]
        public bool Available { get; set; } //whether the appointment is available or not

    }

}
