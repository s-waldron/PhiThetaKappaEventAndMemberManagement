using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public class Events
    {
        //[Key]
        public int EVENTID { get; set; }
        //[Required]
        public String EventName { get; set; }
        //[Required]
        public String EventLocationName { get; set; }
        //[Required]
        public String EventAddress { get; set; }
        //[Required]
        public String EventCity { get; set; }
        //[Required]
        public String EventState { get; set; }
        //[Required]
        public int EventZipCode { get; set; }
        //[Required]
        public DateTime EventStartDateAndTime { get; set; }
        //[Required]
        public DateTime EventEndDateAndTime { get; set; }
    }
}
