using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1.Models.ViewModels
{
    public class AppointmentsListViewModel
    {
        public IEnumerable<Appointment> appointments { get; set; }
        //public PagingInfo PagingInfo { get; set; }

        //Added a currentcategory variable
        //public string CurrentDay { get; set; }
    }
}
