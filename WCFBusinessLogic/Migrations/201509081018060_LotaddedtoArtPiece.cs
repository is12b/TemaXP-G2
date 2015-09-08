namespace WCFBusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LotaddedtoArtPiece : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Lots", name: "ArtPiece_ArtPieceId", newName: "ArtPieceId");
            RenameIndex(table: "dbo.Lots", name: "IX_ArtPiece_ArtPieceId", newName: "IX_ArtPieceId");
            AddColumn("dbo.ArtPieces", "LotId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ArtPieces", "LotId");
            RenameIndex(table: "dbo.Lots", name: "IX_ArtPieceId", newName: "IX_ArtPiece_ArtPieceId");
            RenameColumn(table: "dbo.Lots", name: "ArtPieceId", newName: "ArtPiece_ArtPieceId");
        }
    }
}
