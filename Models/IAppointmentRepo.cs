using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public interface IAppointmentRepo
    {
        IQueryable<Appointment> appointments { get; }
    }
}
