﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private IAuctionDb _ctr = new AuctionDb();

        public void AddAuction(Auction auction) {
            //String regName = "^[a - zA - Z0 - 9]{ 4,10}$";

            //if (Regex.IsMatch(auction.AuctionName, regName) || auction.AuctionName.Length > 1)
            //    throw new ArgumentException();
            //if(auction.LotDuration.TotalSeconds > 0)
            //    throw new ArgumentException();
            //if (auction.Lots.Count < 0)
            //    throw new ArgumentException();
            //if (auction.LotDuration.TotalMinutes > 120)
            //    throw new ArgumentException();

            _ctr.Add(auction);
        }

        public void UpdateAuction(Auction auction) {
            String regName = "^[a - zA - Z0 - 9]{ 4,10}$";
            if (Regex.IsMatch(auction.AuctionName, regName) || auction.AuctionName.Length < 1)
                throw new ArgumentException();
            
            _ctr.Update(auction);
        }

        public List<Auction> GetAllAuctions() {
            return _ctr.GetAll();
        }

        public void DeleteAuction(int id) {
            _ctr.Delete(id);
        }

        public Auction GetAuctionById(int id) {
            return _ctr.GetById(id);
        }

        public void StartLot(int time, Lot lot) {
            //throw new NotImplementedException();
        }


        public List<Auction> GetAllReady() {
            return _ctr.GetAllReady();
        }
    }

    
}
