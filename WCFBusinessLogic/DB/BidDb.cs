using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.Model;

namespace WCFBusinessLogic.DB {
    public class BidDb : IBidDb {

        private AuctionContext _ac;
        public BidDb(AuctionContext ac) {
            _ac = ac;
        }

        public BidDb() {
            _ac = new AuctionContext();
        }

        public void Add(Model.Bid bid) {
            _ac.Bids.Add(bid);
            _ac.SaveChanges();
        }

        public List<Model.Bid> GetAllByLot(Lot lot) {
            var list = _ac.Bids.Where(b => b.LotId == lot.LotId).ToList();
            return list;
        }
    }
}
