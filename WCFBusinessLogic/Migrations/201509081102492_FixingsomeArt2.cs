namespace WCFBusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingsomeArt2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lots", "ArtPieceId", "dbo.ArtPieces");
            DropForeignKey("dbo.Bids", "LotId", "dbo.Lots");
            DropIndex("dbo.Bids", new[] { "LotId" });
            DropPrimaryKey("dbo.Lots");
            AddColumn("dbo.ArtPieces", "LotId", c => c.Int(nullable: false));
            AddColumn("dbo.Bids", "Lot_ArtPieceId", c => c.Int());
            AddPrimaryKey("dbo.Lots", "ArtPieceId");
            CreateIndex("dbo.Bids", "Lot_ArtPieceId");
            AddForeignKey("dbo.Lots", "ArtPieceId", "dbo.ArtPieces", "ArtPieceId");
            AddForeignKey("dbo.Bids", "Lot_ArtPieceId", "dbo.Lots", "ArtPieceId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bids", "Lot_ArtPieceId", "dbo.Lots");
            DropForeignKey("dbo.Lots", "ArtPieceId", "dbo.ArtPieces");
            DropIndex("dbo.Bids", new[] { "Lot_ArtPieceId" });
            DropPrimaryKey("dbo.Lots");
            DropColumn("dbo.Bids", "Lot_ArtPieceId");
            DropColumn("dbo.ArtPieces", "LotId");
            AddPrimaryKey("dbo.Lots", "LotId");
            CreateIndex("dbo.Bids", "LotId");
            AddForeignKey("dbo.Bids", "LotId", "dbo.Lots", "LotId", cascadeDelete: true);
            AddForeignKey("dbo.Lots", "ArtPieceId", "dbo.ArtPieces", "ArtPieceId", cascadeDelete: true);
        }
    }
}
