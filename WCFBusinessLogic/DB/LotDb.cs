using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.Model;

namespace WCFBusinessLogic.DB {
    public class LotDb : ILotDb {

        private AuctionContext _ac;

        public LotDb(AuctionContext context) {
            _ac = context;
        }

        public LotDb() {
            _ac = new AuctionContext();
        }
        public void Add(Model.Lot lot) {
            _ac.Lots.Add(lot);
            _ac.SaveChanges();
        }

        public List<Model.Lot> GetAllByAuction(Model.Auction ac) {
            var list = _ac.Lots.Where(l => l.AuctionId == ac.AuctionId).ToList();
            if (list.Count == 0) {
                throw new NullReferenceException();
            }
            return list;
        }

        public void Update(Model.Lot lot) {
            try {
                //_ac.Auctions.Attach(auc);
                _ac.Entry(lot).State = EntityState.Modified;
                _ac.SaveChanges();
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        public void Delete(int id) {
            _ac.Lots.Remove(new Lot() {
                LotId = id
            });
            _ac.SaveChanges();

        }

        public Model.Lot GetById(int id) {

            var lot = _ac.Lots.SingleOrDefault(l => l.LotId == id);

            return lot;
        }
    }
}
