using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PhiThetaKappaEventAndMemberManagement.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhiThetaKappaEventAndMemberManagement.Controllers
{
    public class EventsController : Controller
    {
        private IEventsRepository repository;

        public EventsController(IEventsRepository repo)
        {
            repository = repo;
        }// end EventsController constructor

        // GET: /<controller>/
        public IActionResult Index() => View(repository.Events);

        public IActionResult EventsForm() => View(new Events());

        public IActionResult UpdateEvents(int EventID) => View("EventsForm", repository.Events
            .FirstOrDefault(eve => eve.EVENTID == EventID));

        [HttpPost]
        public IActionResult EventsForm(Events events)
        {
            if (ModelState.IsValid)
            {
                repository.SaveEvents(events);
                return RedirectToAction("Index");
            }// end if(ModelState.IsValid) check
            else
            {
                return View(events);
            }// end else statement
        }// end EventForm method
    }// end EventsController class
}// end PhiThetaKappaEventAndMemberManagement.Controllers namespace