using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public class Group : Appointment //group class inherits from appointment class 
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

        [Phone]
        public int Phone { get; set; } //phone number (optional)

        
    }
}
