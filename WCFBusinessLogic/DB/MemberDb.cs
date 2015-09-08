using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.Model;

namespace WCFBusinessLogic.DB {
    public class MemberDb : IMemberDb {

        private AuctionContext _ac;

        public MemberDb(AuctionContext context) {
            _ac = context;
        }

        public MemberDb() {
            _ac = new AuctionContext();
        }

        public List<Member> GetAll() {
            return _ac.Members.ToList();
        }

        public Member GetById(int id) {
            var mem = _ac.Members.SingleOrDefault(m => m.MemberId == id);

            if (mem == null) {
                throw new NullReferenceException();
            }

            return mem;
        }
    }
}
