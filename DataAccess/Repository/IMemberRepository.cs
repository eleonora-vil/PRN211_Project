using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public Member SignIn(string email, string password);
        IEnumerable<Member> GetMembers();
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberID);
        Member GetLast();
        Member GetMemberbyID(int memberID);
        Member GetMemberbyEmail(string memberEmail);
        IEnumerable<Member> SearchMembers(int id, string name);
        IEnumerable<Member> FilterMember(string city, string country);
    }
}
