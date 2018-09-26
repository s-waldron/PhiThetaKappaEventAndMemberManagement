using System.Collections.Generic;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public interface IEventsRepository
    {
        IEnumerable<Events> Events { get; }

        void SaveEvents(Events events);
    }
}
