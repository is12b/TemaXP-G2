namespace WCFBusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingsomeArt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ArtPieces", "LotId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ArtPieces", "LotId", c => c.Int());
        }
    }
}
