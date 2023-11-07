using BusinessObject;
using System.Data;
using BusinessObject.Models;
namespace DataAccess
{
    public class MemberDAO
    {
        private FStoreDBContext FStoreDBContext { get; set; }
        private static MemberDAO instance;
        private static readonly object locked = new object();
        private MemberDAO()
        {
            FStoreDBContext = new FStoreDBContext();
        }
        public static MemberDAO Instance
        {
            get
            {
                lock (locked)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }


        public Member SignIn(string email, string password)
        {
            return FStoreDBContext.Members.
            FirstOrDefault(member => member.Email.Equals(email)
                            && member.Password.Equals(password));
        }

        public List<Member> GetMembers()
        {
            return FStoreDBContext.Members.ToList();
        }

        public void AddMember(Member member)
        {
            Member mem = GetMemberbyId(member.MemberId);
            if (mem == null)
            {
                FStoreDBContext.Members.Add(member);
                FStoreDBContext.SaveChanges();
            }
            else
            {

            }
        }

        public Member GetLast()
        {
            return GetMembers().Last();
        }

        public Member GetMemberbyId(int memberID)
        {
            return GetMembers().SingleOrDefault(mb => mb.MemberId == memberID);
        }

        public Member GetMemberbyEmail(string memberEmail)
        {
            return GetMembers().SingleOrDefault(mb => mb.Email == memberEmail);
        }

        public void RemoveMember(int memberID)
        {
            Member member = GetMemberbyId(memberID);
            if (member != null)
            {
                FStoreDBContext.Members.Attach(member);
                FStoreDBContext.Members.Remove(member);
                FStoreDBContext.SaveChanges();
            }
            else
            {
                throw new Exception("Not Exist");
            }
        }

        public void UpdateMember(Member member)
        {
            var m = GetMembers().Single(c => c.MemberId == member.MemberId);
            if (m != null)
            {
                Member oldMember = GetMemberbyId(member.MemberId);
                if (member != null)
                {
                    oldMember.CompanyName = member.CompanyName;
                    oldMember.Email = member.Email;
                    oldMember.City = member.City;
                    oldMember.Country = member.Country;
                    oldMember.Password = member.Password;
                    FStoreDBContext.SaveChanges();
                }
            }
            else
            {
                //throw new Exception("Member does not already exists.");
            }
        }

        public List<Member> Search(int id, string Email)
        {
            List<Member> members = GetMembers().Where(m =>
            m.Email.Contains(Email, StringComparison.OrdinalIgnoreCase)
            || m.MemberId == id).ToList();
            return members;
        }

        public List<Member> Filter(string city, string country)
        {
            List<Member> members = GetMembers().Where(m => m.City.Equals(city) && m.Country.Equals(country)).ToList();
            return members;
        }

    }
}
