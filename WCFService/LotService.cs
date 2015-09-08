﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFBusinessLogic.DB;
using WCFBusinessLogic.Model;

namespace WCFService {
    public class LotService : ILotService {
        private ILotDb _lotDb = new LotDb();


        public void Add(Lot lot) {
            if(lot.Position <= 0 || lot.MinBid <= 0)
                throw new ArgumentException();
            _lotDb.Add(lot);
        }

        public void Delete(int id) {
            _lotDb.Delete(id);
        }

        public List<Lot> GetAllByAuction(Auction auction) {
            return _lotDb.GetAllByAuction(auction);
        }

        public Lot GetById(int id) {
            return _lotDb.GetById(id);
        }

        public void Update(Lot lot) {
            if(lot.Position <= 0 || lot.MinBid <= 0)
                throw new ArgumentException();
            _lotDb.Update(lot);
        }
    }
}
