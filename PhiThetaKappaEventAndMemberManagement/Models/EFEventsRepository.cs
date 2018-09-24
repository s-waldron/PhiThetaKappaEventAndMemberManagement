using System.Collections.Generic;
using System.Linq;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public class EFEventsRepository : IEventsRepository
    {
        private ApplicationDbContext context;

        public EFEventsRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }// end EFEventsRepository constructor

        public IEnumerable<Events> Events => context.Events;

        public void SaveEvents(Events events)
        {
            if(events.EVENTID == 0)
            {
                context.Events.Add(events);
            }// end if(events.EVENTID == 0) check
            else
            {
                Events dbEntry = context.Events
                    .FirstOrDefault(ene => ene.EVENTID == events.EVENTID);
                if(dbEntry != null)
                {
                    dbEntry.EventName = events.EventName;
                    dbEntry.EventLocationName = events.EventLocationName;
                    dbEntry.EventAddress = events.EventAddress;
                    dbEntry.EventCity = events.EventCity;
                    dbEntry.EventState = events.EventState;
                    dbEntry.EventZipCode = events.EventZipCode;
                    dbEntry.EventStartDateAndTime = events.EventStartDateAndTime;
                    dbEntry.EventEndDateAndTime = events.EventEndDateAndTime;
                    dbEntry.EventDescription = events.EventDescription;
                    dbEntry.EventCompletedEvent = events.EventCompletedEvent;
                }// end if(dbEntry != null) check
            }// end else statement
            context.SaveChanges();
        }// end SaveEvents method
    }// end EFEventsRepository class
}// end PhiThetaKappaEventAndMemberManagement.Models namespace
