using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_1.Models;
using Project_1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //variables for the database and the pagesize
        private IAppointmentRepo _repo;
        public int PageSize = 5;

        // this is for later when we get the database up
        public HomeController(ILogger<HomeController> logger, IAppointmentRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAppointments()
        {
            return View();
        }

        // New ViewAppointments Action for when we get that working
        //public IActionResult ViewAppointments(string day, int pageNum = 1)
        //{
        //    return View(new AppointmentsListViewModel
        //    {
        //        Appointments = _repo.appointments
        //            .Where(p => day == null || p.day == day)
        //            .OrderBy(p => p.AppointmentID)
        //            .Skip((pageNum - 1) * PageSize)
        //            .Take(PageSize)
        //        ,
        //        PagingInfo = new PagingInfo
        //        {
        //            CurrentPage = pageNum,
        //            ItemsPerPage = PageSize,
        //            TotalNumItems = day == null ? _repo.appointments.Count() :
        //                _repo.appointments.Where(x => x.day == day).Count()
        //        },
        //        CurrentDay = day
        //    });
        //}
        //public IActionResult SignUp()
        //{
        //    return View();
        //}

        //new SignUp action for when we get that working
        public IActionResult SignUp()
        {
            return View(new AppointmentsListViewModel
            {
                appointments = _repo.appointments
                .OrderBy(p => p.AppointmentID)
                //PagingInfo = null,
                //CurrentDate = null
            }); ;
        }

        //public IActionResult Form(int AppointmentID)
        //{
        //    return View();
        //}
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
