using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WCFBusinessLogic.Model;

namespace WCFBusinessLogic.Controller {
    public class AuctionController {

        private AuctionContext _ac;

        public AuctionController(AuctionContext context) {
            _ac = context;
        }

        public AuctionController() {
            _ac = new AuctionContext();
        }

        public void Add(Auction ac) {
            if (ac.Lots.Count <= 0) {
                throw new Exception("You failed");
            }

            _ac.Auctions.Add(ac);
            _ac.SaveChanges();
        }

        public List<Auction> GetAll() {
            var list = _ac.Auctions.ToList();
            return list;
        }

        public void Update(Auction auc) {
            if (auc.Lots.Count <= 0) {
                throw new Exception("You failed");
            }
            try {
                //_ac.Auctions.Attach(auc);
                _ac.Entry(auc).State = EntityState.Modified;
                _ac.SaveChanges();
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            
        }
    }
}