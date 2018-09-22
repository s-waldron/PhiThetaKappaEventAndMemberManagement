using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public class EFMemberRepository : IMemberRepository
    {
        private ApplicationDbContext context;

        public EFMemberRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }// end EFMemberRepository constructor

        public IEnumerable<Member> Member => context.Member;

        public void SaveMember(Member member)
        {
            if(member.MEMBERID == 0)
            {
                context.Member.Add(member);
            }// end if(member.MEMBERID == 0) check
            else
            {
                Member dbEntry = context.Member
                    .FirstOrDefault(mem => mem.MEMBERID == member.MEMBERID);
                if(dbEntry != null)
                {
                    dbEntry.MemberFirstName = member.MemberFirstName;
                    dbEntry.MemberLastName = member.MemberLastName;
                    dbEntry.MemberEmailAddress = member.MemberEmailAddress;
                }// end if(dbEntry != null) check
            }// end else statement
            context.SaveChanges();
        }// end SaveMember method
    }// end EFMemberRepository class
}// end PhiThetaKappaEventAndMemberManagement.Models namespace