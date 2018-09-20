using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhiThetaKappaEventAndMemberManagement.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhiThetaKappaEventAndMemberManagement.Controllers
{
    public class EventsController : Controller
    {
        public List<Events> EventsList = new List<Events>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            EventsList.Add(new Events
            {
                EventName = "Something",
                EventLocationName = "Some Place",
                EventAddress = "321 N SomePlace Dr",
                EventCity = "Palatka",
                EventState = "Florida",
                EventZipCode = 32146
            });
            return View(EventsList);
        }// end Index method


    }// end EventsController class
}// end PhiThetaKappaEventAndMemberManagement.Controllers namespace