using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhiThetaKappaEventAndMemberManagement.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhiThetaKappaEventAndMemberManagement.Controllers
{
    public class MemberController : Controller
    {
        public List<Member> MembersList = new List<Member>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            MembersList.Add(new Member
            {
                MemberFirstName = "Sally",
                MemberLastName = "Hally",
                MemberEmailAddress = "shally@sjrstate.edu"
            });
            return View();
        }// end Index method

        public IActionResult CreateMember ()
        {
            return View(new Member);
        }// end CreateMember method
    }// end MemberController class
}// end PhiThetaKappaEventAndMemberManagement.Controllers namespace