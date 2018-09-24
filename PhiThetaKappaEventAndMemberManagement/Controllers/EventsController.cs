using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PhiThetaKappaEventAndMemberManagement.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhiThetaKappaEventAndMemberManagement.Controllers
{
    public class EventsController : Controller
    {
        public List<Events> EventsList = new List<Events>();
        ApplicationDbContext context;

        public EventsController(ApplicationDbContext ctx)
        {
            context = ctx;
        }// end EventsController constructor

        // GET: /<controller>/
        public IActionResult Index()
        {
            DateTime startTime = new DateTime(2018, 10, 05, 13, 00, 00);
            DateTime endTime = new DateTime(2018, 10, 05, 15, 00, 00);
            EventsList.Add(new Events
            {
                EventName = "Something",
                EventLocationName = "Some Place",
                EventAddress = "321 N SomePlace Dr",
                EventCity = "Palatka",
                EventState = "Florida",
                EventZipCode = 32146,
                EventStartDateAndTime = startTime,
                EventEndDateAndTime = endTime,
                EventDescription = "We are going some place to do something of interest."
            });
            return View(EventsList);
        }// end Index method

        public IActionResult Create()
        {
            return View(new Events());
        }// end CreateEvents method

        public IActionResult UpdateEvent(int EVENTID)
        {
            Events events = context.Events
                .FirstOrDefault(eve => eve.EVENTID == EVENTID);
            if(events != null)
            {
                return View(events);
            }// end if(events != null) check
            else
            {
                return RedirectToAction("Index");
            }// end else statement
        }// end UpdateEvent method
    }// end EventsController class
}// end PhiThetaKappaEventAndMemberManagement.Controllers namespace