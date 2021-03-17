using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public class Group 
    {
        [Key]
        [Required]
        public int GroupID { get; set; } //group id

        [Required]
        public string Name { get; set; } //group name

        [Required]
        public int Size { get; set; } //group size 

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; } //email address

        [Required]
        public int AppointmentID { get; set; } //appointment that the group signs up for

        [Phone]
        public int Phone { get; set; } //phone number (optional)

        
    }
}
