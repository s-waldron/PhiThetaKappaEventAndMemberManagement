using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    interface IEventsRepository
    {
        IEnumerable<Events> Events { get; }

        void SaveEvents(Events events);
    }
}
