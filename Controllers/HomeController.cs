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

        //variables for the database
        private IAppointmentRepo _repoA;
        private AppointmentContext _context { get; set; }


        // setting up database repos
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
        //The Post action for when the group information is submitted. 
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
            //creating the results object which should show all scheduled appointments
            var results = (from app in _context.Appointments
                           join gr in _context.Groups //because of the inner join only appointments that have a group will be included in the data.
                           on app.AppointmentID equals gr.AppointmentID //joining the two database objects together to get all information for a booked appointment
                           select new CombinedViewModel() //assigning the values from the joined databases to the new variables in the new ViewModel
                           {
                               Day = app.Day,
                               Hour = app.Hour,
                               AmPm = app.AmPm,
                               Available = app.Available,
                               Name = gr.Name,
                               Size = gr.Size,
                               Email = gr.Email
                           }).ToList(); //sending the results to a list so that it can be pushed the the ViewBag

            ViewBag.results = results; 

            return View();
        }
      
        public IActionResult SignUp(string day)
        {
            return View(new AppointmentsListViewModel
            {
                //adds a filter so you can narrow it down by day.
                appointments = _repoA.appointments
                .Where(p => day == null || p.Day == day)
                .OrderBy(p => p.AppointmentID)
                ,
                CurrentDay = day
            }); 
        }
        //the Post action for when signup form is submitted.
        [HttpPost]
        public IActionResult Form(int AppointmentID)
        {
            //pulls the appointment information to then display duing the group form
            var app = (from appo in _repoA.appointments
                       where appo.AppointmentID == AppointmentID
                       select new Appointment()
                       {
                           Day = appo.Day,
                           Hour = appo.Hour,
                           AmPm = appo.AmPm,
                           AppointmentID = appo.AppointmentID
                       }).ToList();

            ViewBag.App = app;

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
