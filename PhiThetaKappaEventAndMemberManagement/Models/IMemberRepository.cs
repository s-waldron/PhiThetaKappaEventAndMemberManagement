using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    interface IMemberRepository
    {
        IEnumerable<Member> Member { get; }

        void SaveMember(Member member);
    }
}
