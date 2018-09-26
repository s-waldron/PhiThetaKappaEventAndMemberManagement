using System;
using System.ComponentModel.DataAnnotations;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public class Member
    {
        [Key]
        public int MEMBERID { get; set; }
        [Required]
        public String MemberFirstName { get; set; }
        [Required]
        public String MemberLastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime MemberJoinDate { get; set; }
        [Required]
        public String MemberEmailAddress { get; set; }
        [Required]
        public Boolean MemberAlumnus { get; set; }
    }// end Member class
}// end PhiThetaKappaEventAndMemberManagement.Models namespace
