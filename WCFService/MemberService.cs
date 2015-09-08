using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.DB;
using WCFBusinessLogic.Model;

namespace WCFService {
    public class MemberService : IMemberService {
        private IMemberDb _memberDb = new MemberDb();

        public List<Member> GetAllMembers() {
            return _memberDb.GetAll();
        }

        public Member GetMemberById(int id) {
            return _memberDb.GetById(id);
        }
    }
}
