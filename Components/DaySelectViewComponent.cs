using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_1.Models;

namespace Project_1.Components
{
    public class DaySelectViewComponent : ViewComponent
    {
        private IAppointmentRepo _repo;

        public DaySelectViewComponent (IAppointmentRepo r)
        {
            _repo = r;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedDay = RouteData?.Values["day"];

            return View(_repo.appointments
                .Select(x => x.Day)
                .Distinct());
        }
    }
}
