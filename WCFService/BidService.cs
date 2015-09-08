using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.DB;
using WCFBusinessLogic.Model;

namespace WCFService {
    public class BidService : IBidService {
        private IBidDb _bidDb = new BidDb();
        public void AddBid(Bid bid) {
            _bidDb.Add(bid);
        }

        public List<Bid> GetAllBidsByLot(Lot lot) {
            return _bidDb.GetAllByLot(lot);
        }
    }
}
