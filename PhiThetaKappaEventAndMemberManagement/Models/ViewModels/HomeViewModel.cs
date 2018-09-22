using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhiThetaKappaEventAndMemberManagement.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Events> Events { get; set; }

        public IEnumerable<News> News { get; set; }
    }// end HomeViewModel class
}// end PhiThetaKappaEventAndMemberManagement.Models.ViewModels namespace