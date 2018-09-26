using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PhiThetaKappaEventAndMemberManagement.Models;
using PhiThetaKappaEventAndMemberManagement.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhiThetaKappaEventAndMemberManagement.Controllers
{
    public class HomeController : Controller
    {
        public List<Events> EventsList = new List<Events>();
        private ApplicationDbContext context;
        private INewsRepository newsRepository;
        private IEventsRepository eventsRepository;

        public HomeController(ApplicationDbContext ctx, INewsRepository newsRepo, IEventsRepository eventsRepo)
        {
            context = ctx;
            newsRepository = newsRepo;
            eventsRepository = eventsRepo;
        }// end HomeController constructor
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View(new HomeViewModel { Events = eventsRepository.Events,
            News = newsRepository.News});
        }// end Index method
    }// end HomeController class
}// end PhiThetaKappaEventAndMemberManagement.Controllers namespace
