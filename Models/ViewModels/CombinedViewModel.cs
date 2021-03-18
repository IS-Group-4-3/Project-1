using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1.Models.ViewModels
{
    public class CombinedViewModel
    {
        public string Day { get; set; } //day of week for temple visit
        public int Hour { get; set; } //hour of day
        public string AmPm { get; set; } //whether it is morning or afternoon (AM or PM) 
        public bool Available { get; set; } = true; //whether the appointment is available or not
        public string Name { get; set; } //group name
        public int Size { get; set; } //group size 
        public string Email { get; set; } //email address
    }
}
