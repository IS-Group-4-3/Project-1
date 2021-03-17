using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

//SeedData.cs provides the logic for populating the database initially, if needed. 


namespace Project_1.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            AppointmentContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<AppointmentContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Appointments.Any())
            {
                context.Appointments.AddRange(

                    new Appointment
                    {
                        Day = "Monday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Monday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Monday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Monday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Monday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Monday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Monday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Monday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Monday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Monday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Monday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Monday",
                        Hour = 8,
                        AmPm = "PM",
                        Available = true
                    }

                );

                context.SaveChanges();
            }
        }
    }
}

