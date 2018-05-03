namespace ApplicationCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "lastName", c => c.String(maxLength: 100, unicode: false));
            AddColumn("dbo.Transactions", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Users", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "name", c => c.String(maxLength: 100, unicode: false));
            DropColumn("dbo.Transactions", "Discriminator");
            DropColumn("dbo.Users", "lastName");
        }
    }
}
