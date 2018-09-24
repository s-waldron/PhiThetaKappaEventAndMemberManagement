using System;

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