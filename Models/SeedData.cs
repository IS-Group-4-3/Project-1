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
                    },
                    new Appointment
                    {
                        Day = "Tuesday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Tuesday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Tuesday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Tuesday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Tuesday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Tuesday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Tuesday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Tuesday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Tuesday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Tuesday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Tuesday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Tuesday",
                        Hour = 8,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Wednesday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Wednesday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Wednesday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Wednesday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Wednesday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Wednesday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Wednesday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Wednesday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Wednesday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Wednesday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Wednesday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Wednesday",
                        Hour = 8,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Thursday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Thursday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Thursday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Thursday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Thursday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Thursday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Thursday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Thursday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Thursday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Thursday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Thursday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Thursday",
                        Hour = 8,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Friday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Friday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Friday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Friday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Friday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Friday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Friday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Friday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Friday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Friday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Friday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Friday",
                        Hour = 8,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Saturday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Saturday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Saturday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Saturday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Saturday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Saturday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Saturday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Saturday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Saturday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Saturday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Saturday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Saturday",
                        Hour = 8,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Sunday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Sunday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Sunday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Sunday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Sunday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Sunday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Sunday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Sunday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Sunday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Sunday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Sunday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        Day = "Sunday",
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

