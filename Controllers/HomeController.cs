using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_1.Models;
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
        //private databaseRepo _repo;
        //public int PageSize = 5;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // this is for later when we get the database up
        //public HomeController(ILogger<HomeController> logger, datebaseRepo repo)
        //{
        //    _logger = logger;
        //    _repo = repo;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAppointments()
        {
            return View();
        }

        // New ViewAppointments Action for when we get that working
        //public IActionResult ViewAppointments(DateTime timeslot, int pageNum = 1)
        //{
        //    return View(new AppointmentsListViewModel
        //    {
        //        Appointments = _repo.appointments
        //            .Where(p => timeslot == null || p.timeslsot == timeslot)
        //            .OrderBy(p => p.AppointmentID)
        //            .Skip((pageNum - 1) * PageSize)
        //            .Take(PageSize)
        //        ,
        //        PagingInfo = new PagingInfo
        //        {
        //            CurrentPage = pageNum,
        //            ItemsPerPage = PageSize,
        //            TotalNumItems = timeslot == null ? _repo.appointments.Count() :
        //                _repo.appointments.Where(x => x.timeslot == timeslot).Count()
        //        },
        //        CurrentDateTime = timeslot
        //    });
        //}
        public IActionResult SignUp()
        {
            return View();
        }

        //new SignUp action for when we get that working
        //public IActionResult SignUp()
        //{
        //    return View(new AppointmentsListViewModel
        //    {
        //        Appointments = _repo.appointments,
        //        PagingInfo = null,
        //        CurrentDate = null
        //    }) ;
        //}

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
