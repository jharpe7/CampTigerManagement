using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampTiger.Data;
using CampTiger.Models;

namespace CampTiger.Models{
    public class MemberService{
        ApplicationDbContext _context;
        public MemberService(ApplicationDbContext context){
            _context = context;
        }
        public async Task<List<Member>> GetMembersAsync() {
            return await _context.Members.ToListAsync();
        }
        public async Task<Member> GetMembersByIdAsync(int id) {
            return await _context.Members.FindAsync(id);
        }
        public async Task<Member> InsertMemberAsync(Member member) {
            _context.Members.Add(member);
            await _context.SaveChangesAsync();
            return member;
        }
        public async Task<Member> UpdateMemberAsync(int id, Member m){
            var member = await _context.Members.FindAsync(id);

            if(member == null)
                return null;
            
            member.MemberId = m.MemberId;
            member.FirstName = m.FirstName;
            member.LastName = m.LastName;
            member.Password = m.Password;
            member.DOB = m.DOB;
            member.Address = m.Address;
            member.City = m.City;
            member.State = m.State;

            _context.Members.Update(member);
            await _context.SaveChangesAsync();

            return member;
        }
        public async Task <Member> DeleteMemberAsync(int id){
            var member = await _context.Members.FindAsync(id);
            if (member == null)
                return null;
            _context.Members.Remove(member);
            await _context.SaveChangesAsync();

            return member;
        }
        private bool MemberExists(int id) {
            return _context.Members.Any(e => e.MemberId == id);
        }
    }
}