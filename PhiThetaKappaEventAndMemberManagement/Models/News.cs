using System;
using System.ComponentModel.DataAnnotations;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public class News
    {
        [Key]
        public int NEWSID { get; set; }
        [Required]
        public String NewsArticleTitle { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime NewsCreatedDate { get; set; }
        [Required]
        public String NewsArticle { get; set; }
    }// end News class
}// end PhiThetaKappaEventAndMemberManagement.Models namespace