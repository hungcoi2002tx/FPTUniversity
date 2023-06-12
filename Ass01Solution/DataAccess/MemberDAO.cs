using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class MemberDAO
    {
        private static List<Member> members = new List<Member>()
        {
            new Member() {Id =  1, Name ="hung",City="ha noi",Country = "Viet Nam",Email="hackinghungtx@gmail.com",Pass="Hungdeptrai"},
            new Member() {Id = 2,Name="hai",City= "thach that",Country="USA",Email="lionhtinh@gmail.com",Pass="aaaa"}
        };
        private IMemberRepository memberRepository = new MemberRepository();    

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Member> GetMembers => members;

        public void Add(Member member) => members.Add(member);

        public Member GetByMember(int id)
        {
            Member member = members.SingleOrDefault(member => member.Id == id);
            return member;
        }
        public void Update(Member member)
        {
            Member member1 = GetByMember(member.Id);
            
            if(member1 != null)
            {
                var c = members.IndexOf(member1);
                members[c] = member;
            }
            else
            {
                throw new Exception("Member is not already exists.");
            }
        }

        public void Delete(int id)
        {
            Member member = members.SingleOrDefault(m => m.Id == id);
            if(member != null)
            {
                var c = members.IndexOf(member);
                members.Remove(member);
            }
            else
            {
                throw new Exception("Member does not already exists");
            }
        }

        public Member Check(Member member)
        {
            Member member1 = members.SingleOrDefault(m => m.Email == member.Email && m.Pass == member.Pass);
            return member;
        }
    }
}
