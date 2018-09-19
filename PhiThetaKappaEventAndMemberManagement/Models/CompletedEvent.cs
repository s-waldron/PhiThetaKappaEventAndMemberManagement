using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public class CompletedEvent
    {
        //[Key]
        public int COMPLETEDEVENTID { get; set; }
        //[ForeignKey("Event")]
        public int EVENTID { get; set; }
        //[Required]
        public Boolean CompletedEventComplete { get; set; }
        //[Required]
        public int CompletedEventNumberOfMembers { get; set; }
        //[Required]
        [DataType(DataType.Date)]
        public DateTime CompletedEventData { get; set; }
    }
}
