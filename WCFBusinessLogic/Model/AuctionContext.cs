using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFBusinessLogic.Model {
    public class AuctionContext : DbContext {
        public virtual DbSet<ArtPiece> ArtPieces { get; set; }
        public virtual DbSet<Auction> Auctions { get; set; }
        public virtual DbSet<Lot> Lots { get; set; }
        public virtual DbSet<Bid> Bids { get; set; }
        public virtual DbSet<Member> Members { get; set; }
    }
}
