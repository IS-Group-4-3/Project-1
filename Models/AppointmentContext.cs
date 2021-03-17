using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project_1.Models
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base (options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; } //sets up a table for appointments and groups in the database 
        public DbSet<Group> Groups { get; set; }
    }
}
