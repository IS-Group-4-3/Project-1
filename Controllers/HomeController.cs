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
        private IAppointmentRepo _repoA;
        public int PageSize = 5;
        private AppointmentContext _context { get; set; }


        // this is for later when we get the database up
        public HomeController(ILogger<HomeController> logger, IAppointmentRepo repoA, AppointmentContext con)
        {
            _logger = logger;
            _repoA = repoA;
            _context = con;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Group g)
        {
            _context.Groups.Add(g);
            _context.Appointments.FirstOrDefault(p => p.AppointmentID == g.AppointmentID).Available = false;
            _context.SaveChanges();

            return View();
        }
        public IActionResult ViewAppointments()
        {
            
            var results = (from app in _context.Appointments
                           join gr in _context.Groups
                           on app.AppointmentID equals gr.AppointmentID
                           select new CombinedViewModel()
                           {
                               Day = app.Day,
                               Hour = app.Hour,
                               AmPm = app.AmPm,
                               Available = app.Available,
                               Name = gr.Name,
                               Size = gr.Size,
                               Email = gr.Email
                           }).ToList();

            ViewBag.results = results;

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

        
        //new SignUp action for when we get that working
        public IActionResult SignUp()
        {
            return View(new AppointmentsListViewModel
            {
                appointments = _repoA.appointments
                .OrderBy(p => p.AppointmentID)
            }); 
        }

        [HttpPost]
        public IActionResult Form(int AppointmentID)
        {
            ViewBag.AppID = AppointmentID;

            return View();
        }
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
