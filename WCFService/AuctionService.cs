using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using WCFBusinessLogic.DB;
using WCFBusinessLogic.Model;


namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuctionService" in both code and config file together.
    public class AuctionService : IAuctionService {
        private AuctionDb _ctr = new AuctionDb();

        public void Add(Auction auction) {
            String regName = "^[a - zA - Z0 - 9]{ 4,10}$";

            if (Regex.IsMatch(auction.AuctionName, regName) || auction.AuctionName.Length > 1)
                throw new ArgumentException();
            if(auction.LotDuration.TotalSeconds > 0 || auction.LotDuration.TotalMinutes > 120 || auction.Lots.Count > 0)
                throw new ArgumentException();

            _ctr.Add(auction);
        }

        public void Update(Auction auction) {
            String regName = "^[a - zA - Z0 - 9]{ 4,10}$";
            if (Regex.IsMatch(auction.AuctionName, regName) || auction.AuctionName.Length > 1)
                throw new ArgumentException();
            if (auction.LotDuration.TotalSeconds > 0 || auction.LotDuration.TotalMinutes > 120 || auction.Lots.Count > 0)
                throw new ArgumentException();

            _ctr.Update(auction);
        }

        public List<Auction> GetAll() {
            return _ctr.GetAll();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public Auction GetById(int id) {
            throw new NotImplementedException();
        }
    }

    
}
