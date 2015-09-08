using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WCFBusinessLogic.Model;

namespace WCFBusinessLogic.DB {
    public class ArtPieceDb : IArtPieceDb {

        private AuctionContext _ac;

        public ArtPieceDb(AuctionContext context) {
            _ac = context;
        }

        public ArtPieceDb() {
            _ac = new AuctionContext();
        }

        public void Add(ArtPiece art) {
            _ac.ArtPieces.Add(art);
            _ac.SaveChanges();
        }

        public List<ArtPiece> GetAll() {
            var list = _ac.ArtPieces.ToList();
            return list;
        }

        public void Update(ArtPiece art) {
            try {
                //_ac.Auctions.Attach(auc);
                _ac.Entry(art).State = EntityState.Modified;
                _ac.SaveChanges();
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        public void Delete(int id) {
            _ac.ArtPieces.Remove(new ArtPiece() {
                ArtPieceId = id
            });
            _ac.SaveChanges();
        }

        public ArtPiece GetById(int id) {
            var art = _ac.ArtPieces.SingleOrDefault(a => a.ArtPieceId == id);
            return art;
        }


        public List<ArtPiece> GetAllAvilableArtPieces() {
            var art = _ac.ArtPieces.Where(a => a.LotId == 0).ToList();

            return art;
        }
    }
}