using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public class EFCompletedEventRepository : ICompletedEventRepository
    {
        private ApplicationDbContext context;

        public EFCompletedEventRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }// end EFCompletedEventRepository constructor

        public IEnumerable<CompletedEvent> CompletedEvent => context.CompletedEvents;

        public void SaveCompletedEvent(CompletedEvent completedEvent)
        {
            if(completedEvent.COMPLETEDEVENTID == 0)
            {
                context.CompletedEvents.Add(completedEvent);
            }// end SaveCompletedEvent method
            else
            {
                CompletedEvent dbEntry = context.CompletedEvents
                    .FirstOrDefault(cen => cen.COMPLETEDEVENTID == completedEvent.COMPLETEDEVENTID);
                if(dbEntry != null)
                {
                    dbEntry.EVENTID = completedEvent.EVENTID;
                    dbEntry.CompletedEventDate = completedEvent.CompletedEventDate;
                    dbEntry.CompletedEventNumberOfMembers = completedEvent.CompletedEventNumberOfMembers;
                }// end if(dbEntry != null) check
            }// end else statement
        }// end SaveCompletedEvent method
    }// end EFCompletedEventRepository class
}// end PhiThetaKappaEventAndMemberManagement.Models namespace