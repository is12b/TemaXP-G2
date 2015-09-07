namespace WCFBusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberAddPoint : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "Points", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "Points");
        }
    }
}
