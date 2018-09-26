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
            DateTime theDate = new DateTime();
            theDate = DateTime.Now;
            IEnumerable<Events> theEvents = eventsRepository.Events;
            IEnumerable<News> theNews = newsRepository.News;
            List<Events> events = new List<Events>();
            HomeViewModel homeViewModel = new HomeViewModel();
            foreach(Events ev in theEvents)
            {
                if(ev.EventStartDateAndTime > theDate)
                {
                    events.Add(ev);
                }// end if(ev.EventStartDateAndTime > theDate) check
            }// end foreach loop
            List<News> news = new List<News>();
            int size = 0;
            foreach(News ne in theNews)
            {
                size++;
            }// end foreach loop
            homeViewModel.Events = events;
            return View(homeViewModel);
        }// end Index method
    }// end HomeController class
}// end PhiThetaKappaEventAndMemberManagement.Controllers namespace
