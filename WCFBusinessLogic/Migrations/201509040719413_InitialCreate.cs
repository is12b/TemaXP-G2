namespace WCFBusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArtPieces",
                c => new
                    {
                        ArtPieceId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Artist = c.String(),
                        PictureUrl = c.String(),
                        PurchasePrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArtPieceId);
            
            CreateTable(
                "dbo.Auctions",
                c => new
                    {
                        AuctionId = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        Multiplier = c.Int(nullable: false),
                        LotDuration = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.AuctionId);
            
            CreateTable(
                "dbo.Lots",
                c => new
                    {
                        LotId = c.Int(nullable: false, identity: true),
                        MinBid = c.Int(nullable: false),
                        Position = c.Int(nullable: false),
                        ArtPiece_ArtPieceId = c.Int(),
                        Auction_AuctionId = c.Int(),
                    })
                .PrimaryKey(t => t.LotId)
                .ForeignKey("dbo.ArtPieces", t => t.ArtPiece_ArtPieceId)
                .ForeignKey("dbo.Auctions", t => t.Auction_AuctionId)
                .Index(t => t.ArtPiece_ArtPieceId)
                .Index(t => t.Auction_AuctionId);
            
            CreateTable(
                "dbo.Bids",
                c => new
                    {
                        BidId = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Bidder_MemberId = c.Int(),
                    })
                .PrimaryKey(t => t.BidId)
                .ForeignKey("dbo.Members", t => t.Bidder_MemberId)
                .Index(t => t.Bidder_MemberId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bids", "Bidder_MemberId", "dbo.Members");
            DropForeignKey("dbo.Lots", "Auction_AuctionId", "dbo.Auctions");
            DropForeignKey("dbo.Lots", "ArtPiece_ArtPieceId", "dbo.ArtPieces");
            DropIndex("dbo.Bids", new[] { "Bidder_MemberId" });
            DropIndex("dbo.Lots", new[] { "Auction_AuctionId" });
            DropIndex("dbo.Lots", new[] { "ArtPiece_ArtPieceId" });
            DropTable("dbo.Members");
            DropTable("dbo.Bids");
            DropTable("dbo.Lots");
            DropTable("dbo.Auctions");
            DropTable("dbo.ArtPieces");
        }
    }
}
