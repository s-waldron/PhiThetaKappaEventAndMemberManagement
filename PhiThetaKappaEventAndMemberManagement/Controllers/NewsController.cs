using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhiThetaKappaEventAndMemberManagement.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhiThetaKappaEventAndMemberManagement.Controllers
{
    public class NewsController : Controller
    {
        private ApplicationDbContext context;
        private INewsRepository repository;

        public NewsController(ApplicationDbContext ctx, INewsRepository repo)
        {
            context = ctx;
            repository = repo;
        }// end NewsController constructor
        // GET: /<controller>/
        public IActionResult Index() => View(repository.News);


    }// end NewsController class
}// end PhiThetaKappaEventAndMemberManagement.Controllers namespace
