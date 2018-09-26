using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PhiThetaKappaEventAndMemberManagement.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhiThetaKappaEventAndMemberManagement.Controllers
{
    public class NewsController : Controller
    {
        private INewsRepository repository;

        public NewsController(INewsRepository repo)
        {
            repository = repo;
        }// end NewsController constructor

        public IActionResult Index() => View(repository.News);

        public IActionResult NewsForm() => View(new News());

        public IActionResult UpdateNews(int NewsID) => View(repository.News
            .FirstOrDefault(ne => ne.NEWSID == NewsID));

        [HttpPost]
        public IActionResult NewsForm(News news)
        {
            if (ModelState.IsValid)
            {
                repository.SaveNews(news);
                return RedirectToAction("Index");
            }// end if(ModelState.IsValid) check
            else
            {
                return View(news);
            }// end else statement
        }// end NewsForm method
    }// end NewsController class
}// end PhiThetaKappaEventAndMemberManagement.Controllers namespace
