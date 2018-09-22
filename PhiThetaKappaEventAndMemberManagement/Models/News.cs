using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public class News
    {
        //[Key]
        public int NEWSID { get; set; }
        //[Required]
        public String NewsArticleTitle { get; set; }
        //[Required]
        public String NewsArticle { get; set; }
    }// end News class
}// end PhiThetaKappaEventAndMemberManagement.Models namespace