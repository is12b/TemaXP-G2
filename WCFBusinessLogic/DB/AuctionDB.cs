﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WCFBusinessLogic.Model;

namespace WCFBusinessLogic.DB {
    public class AuctionDb : IAuctionDb {

        private AuctionContext _ac;

        public AuctionDb(AuctionContext context) {
            _ac = context;
        }

        public AuctionDb() {
            _ac = new AuctionContext();
        }

        public void Add(Auction ac) {
            if (ac.Lots.Count <= 0) {
                throw new Exception("You failed");
            }

            ac.CreationDate = DateTime.Now;

            foreach (var lot in ac.Lots) {
                _ac.Entry(lot.ArtPiece).State = EntityState.Modified;
            }

            _ac.Auctions.Add(ac);
            _ac.DebugSaveChanges();

            foreach (var lot in ac.Lots) {
                lot.ArtPiece.LotId = lot.LotId;
                _ac.Entry(lot.ArtPiece).State = EntityState.Modified;
            }

            _ac.DebugSaveChanges();

        }

        public List<Auction> GetAll() {
            var list = _ac.Auctions.Include(a => a.Lots).Include(a => a.Lots.Select(l => l.ArtPiece)).ToList();
            return list;
        }

        public List<Auction> GetAllReady() {
            var list = _ac.Auctions.Where(x => x.Status == Status.Ready).Include(x => x.Lots).Include(x => x.Lots.Select(l => l.ArtPiece)).ToList();
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
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }

        }

        public void Delete(int id) {
            var auction = GetById(id);

            List<Lot> lotList = auction.Lots.Where(l => l.Bids.Count == 0).ToList();
            List<Lot> completedLots = auction.Lots.Where(l => l.Bids.Count > 0).ToList();
            if (lotList.Count > 0) {
                _ac.Lots.RemoveRange(lotList);
            }

            if (completedLots.Count > 0) {
                auction.Status = Status.Complete;
            } else {
                _ac.Auctions.Remove(auction);
            }

            _ac.SaveChanges();

        }

        public Auction GetById(int id) {
            var auction = _ac.Auctions.Where(a => a.AuctionId == id).Include(a => a.Lots).Include(a => a.Lots.Select(l => l.ArtPiece)).SingleOrDefault();

            if (auction == null) {
                throw new NullReferenceException();
            }

            return auction;

        }
    }
}