namespace WCFBusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lotchanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lots", "Auction_AuctionId", "dbo.Auctions");
            DropIndex("dbo.Lots", new[] { "Auction_AuctionId" });
            RenameColumn(table: "dbo.Lots", name: "Auction_AuctionId", newName: "AuctionId");
            AddColumn("dbo.Bids", "Lot_LotId", c => c.Int());
            AlterColumn("dbo.Lots", "AuctionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Lots", "AuctionId");
            CreateIndex("dbo.Bids", "Lot_LotId");
            AddForeignKey("dbo.Bids", "Lot_LotId", "dbo.Lots", "LotId");
            AddForeignKey("dbo.Lots", "AuctionId", "dbo.Auctions", "AuctionId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lots", "AuctionId", "dbo.Auctions");
            DropForeignKey("dbo.Bids", "Lot_LotId", "dbo.Lots");
            DropIndex("dbo.Bids", new[] { "Lot_LotId" });
            DropIndex("dbo.Lots", new[] { "AuctionId" });
            AlterColumn("dbo.Lots", "AuctionId", c => c.Int());
            DropColumn("dbo.Bids", "Lot_LotId");
            RenameColumn(table: "dbo.Lots", name: "AuctionId", newName: "Auction_AuctionId");
            CreateIndex("dbo.Lots", "Auction_AuctionId");
            AddForeignKey("dbo.Lots", "Auction_AuctionId", "dbo.Auctions", "AuctionId");
        }
    }
}
