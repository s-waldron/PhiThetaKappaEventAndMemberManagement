using System.Collections.Generic;

namespace PhiThetaKappaEventAndMemberManagement.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Events> Events { get; set; }

        public IEnumerable<News> News { get; set; }
    }// end HomeViewModel class
}// end PhiThetaKappaEventAndMemberManagement.Models.ViewModels namespace