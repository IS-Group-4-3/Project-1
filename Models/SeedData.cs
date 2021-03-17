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
                        AppointmentID = 1,
                        Day = "Monday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 2,
                        Day = "Monday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 3,
                        Day = "Monday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 4,
                        Day = "Monday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 5,
                        Day = "Monday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 6,
                        Day = "Monday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 7,
                        Day = "Monday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 8,
                        Day = "Monday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 9,
                        Day = "Monday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 10,
                        Day = "Monday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 11,
                        Day = "Monday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 12,
                        Day = "Monday",
                        Hour = 8,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 13,
                        Day = "Tuesday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 14,
                        Day = "Tuesday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 15, 
                        Day = "Tuesday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 16, 
                        Day = "Tuesday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 17, 
                        Day = "Tuesday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 18, 
                        Day = "Tuesday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 19, 
                        Day = "Tuesday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 20,
                        Day = "Tuesday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 21,
                        Day = "Tuesday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 22,
                        Day = "Tuesday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 23,
                        Day = "Tuesday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 24, 
                        Day = "Tuesday",
                        Hour = 8,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 25,
                        Day = "Wednesday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 26, 
                        Day = "Wednesday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 27, 
                        Day = "Wednesday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 28, 
                        Day = "Wednesday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 29, 
                        Day = "Wednesday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 30,
                        Day = "Wednesday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 31,
                        Day = "Wednesday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 32,
                        Day = "Wednesday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 33,
                        Day = "Wednesday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 34,
                        Day = "Wednesday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 35,
                        Day = "Wednesday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 36, 
                        Day = "Wednesday",
                        Hour = 8,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 37, 
                        Day = "Thursday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 38,
                        Day = "Thursday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 39
                        Day = "Thursday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 40
                        Day = "Thursday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 41,
                        Day = "Thursday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 42,
                        Day = "Thursday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 43,
                        Day = "Thursday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 44,
                        Day = "Thursday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 45,
                        Day = "Thursday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 46,
                        Day = "Thursday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 47,
                        Day = "Thursday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 48,
                        Day = "Thursday",
                        Hour = 8,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 49,
                        Day = "Friday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 50,
                        Day = "Friday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 51,
                        Day = "Friday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 52,
                        Day = "Friday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 53,
                        Day = "Friday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 54,
                        Day = "Friday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 55,
                        Day = "Friday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 56,
                        Day = "Friday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 57,
                        Day = "Friday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 58,
                        Day = "Friday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 59,
                        Day = "Friday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 60,
                        Day = "Friday",
                        Hour = 8,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 61,
                        Day = "Saturday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 62,
                        Day = "Saturday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 63,
                        Day = "Saturday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 64,
                        Day = "Saturday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 65,
                        Day = "Saturday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 66,
                        Day = "Saturday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 67,
                        Day = "Saturday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 68,
                        Day = "Saturday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 69,
                        Day = "Saturday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 70,
                        Day = "Saturday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 71, 
                        Day = "Saturday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 72,
                        Day = "Saturday",
                        Hour = 8,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 73,
                        Day = "Sunday",
                        Hour = 8,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 74,
                        Day = "Sunday",
                        Hour = 9,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 75,
                        Day = "Sunday",
                        Hour = 10,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 76,
                        Day = "Sunday",
                        Hour = 11,
                        AmPm = "AM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 77,
                        Day = "Sunday",
                        Hour = 12,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 78,
                        Day = "Sunday",
                        Hour = 1,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 79,
                        Day = "Sunday",
                        Hour = 2,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 80,
                        Day = "Sunday",
                        Hour = 3,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 81, 
                        Day = "Sunday",
                        Hour = 4,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 82, 
                        Day = "Sunday",
                        Hour = 5,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 83, 
                        Day = "Sunday",
                        Hour = 7,
                        AmPm = "PM",
                        Available = true
                    },
                    new Appointment
                    {
                        AppointmentID = 84,
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

