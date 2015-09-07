namespace WCFBusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bidchanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bids", "Lot_LotId", "dbo.Lots");
            DropIndex("dbo.Bids", new[] { "Lot_LotId" });
            RenameColumn(table: "dbo.Bids", name: "Lot_LotId", newName: "LotId");
            AlterColumn("dbo.Bids", "LotId", c => c.Int(nullable: false));
            CreateIndex("dbo.Bids", "LotId");
            AddForeignKey("dbo.Bids", "LotId", "dbo.Lots", "LotId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bids", "LotId", "dbo.Lots");
            DropIndex("dbo.Bids", new[] { "LotId" });
            AlterColumn("dbo.Bids", "LotId", c => c.Int());
            RenameColumn(table: "dbo.Bids", name: "LotId", newName: "Lot_LotId");
            CreateIndex("dbo.Bids", "Lot_LotId");
            AddForeignKey("dbo.Bids", "Lot_LotId", "dbo.Lots", "LotId");
        }
    }
}
