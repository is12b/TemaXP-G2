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
        public void Add(Bid bid) {
            if(bid.Amount <= 0)
                throw new ArgumentException();
        }

        public List<Bid> GetAllByLot(Lot lot) {
            if (lot.Position == 0 || lot.MinBid <= 0)
                throw new ArgumentException();
            else
                return _bidDb.GetAllByLot(lot);
        }
    }
}
