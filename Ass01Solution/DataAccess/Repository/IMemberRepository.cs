using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public IEnumerable<Member> GetMembers();

        public void AddMember(Member member);

        public void DeleteMember(int id);

        public void UpdateMember(Member member);
        public Member check(Member member);

        public Member GetMemberByID(int id);
    }
}
