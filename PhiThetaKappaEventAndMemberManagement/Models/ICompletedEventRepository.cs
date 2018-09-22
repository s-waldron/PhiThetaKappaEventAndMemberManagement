using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    interface ICompletedEventRepository
    {
        IEnumerable<CompletedEvent> CompletedEvent { get; }

        void SaveCompletedEvent(CompletedEvent completedEvent);
    }// end ICompletedEventRepository interface
}// end PhiThetaKappaEventAndMemberManagement.Models namespace