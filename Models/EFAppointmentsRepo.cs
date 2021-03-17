using System.Linq;

namespace Project_1.Models
{
    public class EFAppointmentsRepo : IAppointmentRepo
    {
        private AppointmentContext _context;

        public EFAppointmentsRepo(AppointmentContext context)
        {
            _context = context;
        }

        public IQueryable<Appointment> appointments => _context.Appointments;

    }
}
