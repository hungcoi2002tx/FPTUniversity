using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        
        public void AddMember(Member member) => MemberDAO.Instance.Add(member);

        public Member check(Member member) => MemberDAO.Instance.Check(member);

        public void DeleteMember(int id) => MemberDAO.Instance.Delete(id);

        public Member GetMemberByID(int id) => MemberDAO.Instance.GetByMember(id);  

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMembers;

        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);
    }
}
