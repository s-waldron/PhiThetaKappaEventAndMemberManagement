using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
        public String MemberEmailAddress { get; set; }
    }
}
