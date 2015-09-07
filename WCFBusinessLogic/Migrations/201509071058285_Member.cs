namespace WCFBusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Member : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "Name", c => c.String());
            AddColumn("dbo.Members", "Department", c => c.String());
            AddColumn("dbo.Members", "Cpr", c => c.String());
            AddColumn("dbo.Members", "Address", c => c.String());
            AddColumn("dbo.Members", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "Email");
            DropColumn("dbo.Members", "Address");
            DropColumn("dbo.Members", "Cpr");
            DropColumn("dbo.Members", "Department");
            DropColumn("dbo.Members", "Name");
        }
    }
}
