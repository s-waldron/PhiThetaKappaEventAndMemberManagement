using System.Collections.Generic;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public interface IMemberRepository
    {
        IEnumerable<Member> Member { get; }

        void SaveMember(Member member);
    }
}
