using System.Collections.Generic;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    interface IMemberRepository
    {
        IEnumerable<Member> Member { get; }

        void SaveMember(Member member);
    }
}
