namespace ApplicationCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BeforeCompile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "paymentType", c => c.String(maxLength: 30, unicode: false));
            DropColumn("dbo.Transactions", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Transactions", "paymentType");
        }
    }
}
