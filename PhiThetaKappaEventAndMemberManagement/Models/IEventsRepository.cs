using System.Collections.Generic;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    interface IEventsRepository
    {
        IEnumerable<Events> Events { get; }

        void SaveEvents(Events events);
    }
}
