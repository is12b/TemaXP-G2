namespace WCFBusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Datacontractsconstraints : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lots", "ArtPiece_ArtPieceId", "dbo.ArtPieces");
            DropForeignKey("dbo.Bids", "Bidder_MemberId", "dbo.Members");
            DropIndex("dbo.Lots", new[] { "ArtPiece_ArtPieceId" });
            DropIndex("dbo.Bids", new[] { "Bidder_MemberId" });
            AddColumn("dbo.Auctions", "AuctionName", c => c.String(nullable: false));
            AddColumn("dbo.Auctions", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ArtPieces", "Name", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.ArtPieces", "Description", c => c.String(maxLength: 80));
            AlterColumn("dbo.ArtPieces", "Artist", c => c.String(maxLength: 40));
            AlterColumn("dbo.Lots", "ArtPiece_ArtPieceId", c => c.Int(nullable: false));
            AlterColumn("dbo.Bids", "Bidder_MemberId", c => c.Int(nullable: false));
            CreateIndex("dbo.Lots", "ArtPiece_ArtPieceId");
            CreateIndex("dbo.Bids", "Bidder_MemberId");
            AddForeignKey("dbo.Lots", "ArtPiece_ArtPieceId", "dbo.ArtPieces", "ArtPieceId", cascadeDelete: true);
            AddForeignKey("dbo.Bids", "Bidder_MemberId", "dbo.Members", "MemberId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bids", "Bidder_MemberId", "dbo.Members");
            DropForeignKey("dbo.Lots", "ArtPiece_ArtPieceId", "dbo.ArtPieces");
            DropIndex("dbo.Bids", new[] { "Bidder_MemberId" });
            DropIndex("dbo.Lots", new[] { "ArtPiece_ArtPieceId" });
            AlterColumn("dbo.Bids", "Bidder_MemberId", c => c.Int());
            AlterColumn("dbo.Lots", "ArtPiece_ArtPieceId", c => c.Int());
            AlterColumn("dbo.ArtPieces", "Artist", c => c.String());
            AlterColumn("dbo.ArtPieces", "Description", c => c.String());
            AlterColumn("dbo.ArtPieces", "Name", c => c.String());
            DropColumn("dbo.Auctions", "CreationDate");
            DropColumn("dbo.Auctions", "AuctionName");
            CreateIndex("dbo.Bids", "Bidder_MemberId");
            CreateIndex("dbo.Lots", "ArtPiece_ArtPieceId");
            AddForeignKey("dbo.Bids", "Bidder_MemberId", "dbo.Members", "MemberId");
            AddForeignKey("dbo.Lots", "ArtPiece_ArtPieceId", "dbo.ArtPieces", "ArtPieceId");
        }
    }
}
