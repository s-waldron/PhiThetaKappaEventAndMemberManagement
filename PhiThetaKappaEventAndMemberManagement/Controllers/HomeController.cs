using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PhiThetaKappaEventAndMemberManagement.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhiThetaKappaEventAndMemberManagement.Controllers
{
    public class HomeController : Controller
    {
        public List<Events> EventsList = new List<Events>();
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            DateTime startTime = new DateTime(2018, 10, 05, 13, 00, 00);
            DateTime endTime = new DateTime(2018, 10, 05, 15, 00, 00);
            EventsList.Add(new Events {
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
    }// end HomeController class
}// end PhiThetaKappaEventAndMemberManagement.Controllers namespace
