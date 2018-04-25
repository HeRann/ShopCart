namespace ApplicationCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        cartItemId = c.Int(nullable: false, identity: true),
                        productId = c.Int(nullable: false),
                        unitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        cartId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cartItemId)
                .ForeignKey("dbo.Carts", t => t.cartId)
                .ForeignKey("dbo.Products", t => t.productId)
                .Index(t => t.productId)
                .Index(t => t.cartId);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        cartId = c.Int(nullable: false, identity: true),
                        grandTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        userId = c.Int(nullable: false),
                        payableAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        createdDate = c.DateTime(nullable: false),
                        updatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.cartId)
                .ForeignKey("dbo.Users", t => t.userId)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        userName = c.String(nullable: false, maxLength: 50, unicode: false),
                        password = c.String(nullable: false, maxLength: 50, unicode: false),
                        firstName = c.String(maxLength: 100, unicode: false),
                        middleName = c.String(maxLength: 50, unicode: false),
                        name = c.String(maxLength: 100, unicode: false),
                        addressLine1 = c.String(maxLength: 500, unicode: false),
                        addressLine2 = c.String(maxLength: 500, unicode: false),
                        addressLine3 = c.String(maxLength: 500, unicode: false),
                        city = c.String(maxLength: 200, unicode: false),
                        state = c.String(maxLength: 200, unicode: false),
                        country = c.String(maxLength: 200, unicode: false),
                        contactNumber = c.String(maxLength: 20, unicode: false),
                        createdDate = c.DateTime(nullable: false),
                        updatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.userId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        orderId = c.Int(nullable: false, identity: true),
                        customerName = c.String(nullable: false, maxLength: 250, unicode: false),
                        shippingAddress = c.String(nullable: false, maxLength: 500, unicode: false),
                        cartId = c.Int(nullable: false),
                        userId = c.Int(nullable: false),
                        status = c.String(maxLength: 25, unicode: false),
                        grandTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        payableAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        createdDate = c.DateTime(nullable: false),
                        updatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.orderId)
                .ForeignKey("dbo.Carts", t => t.cartId)
                .ForeignKey("dbo.Users", t => t.userId)
                .Index(t => t.cartId)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        orderItemId = c.Int(nullable: false, identity: true),
                        productId = c.Int(nullable: false),
                        unitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        orderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.orderItemId)
                .ForeignKey("dbo.Orders", t => t.orderId)
                .Index(t => t.orderId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        roleId = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 100),
                        description = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.roleId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        productName = c.String(nullable: false, maxLength: 100, unicode: false),
                        unitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        description = c.String(nullable: false, maxLength: 800, unicode: false),
                        imageName = c.String(nullable: false, maxLength: 260, unicode: false),
                        imagePath = c.String(nullable: false, maxLength: 1000, unicode: false),
                        categoryId = c.Int(nullable: false),
                        createdDate = c.DateTime(),
                        updatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.productId)
                .ForeignKey("dbo.Categories", t => t.categoryId)
                .Index(t => t.categoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        categoryName = c.String(nullable: false, maxLength: 100),
                        createdDate = c.DateTime(nullable: false),
                        updatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.categoryId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        transactionId = c.Int(nullable: false, identity: true),
                        status = c.String(maxLength: 100, unicode: false),
                        userId = c.Int(nullable: false),
                        cartId = c.Int(nullable: false),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        createdDate = c.DateTime(),
                        updatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.transactionId)
                .ForeignKey("dbo.Carts", t => t.cartId)
                .ForeignKey("dbo.Users", t => t.userId)
                .Index(t => t.userId)
                .Index(t => t.cartId);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "userId", "dbo.Users");
            DropForeignKey("dbo.Transactions", "cartId", "dbo.Carts");
            DropForeignKey("dbo.CartItems", "productId", "dbo.Products");
            DropForeignKey("dbo.Products", "categoryId", "dbo.Categories");
            DropForeignKey("dbo.CartItems", "cartId", "dbo.Carts");
            DropForeignKey("dbo.Carts", "userId", "dbo.Users");
            DropForeignKey("dbo.UserRole", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserRole", "UserId", "dbo.Users");
            DropForeignKey("dbo.Orders", "userId", "dbo.Users");
            DropForeignKey("dbo.OrderItems", "orderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "cartId", "dbo.Carts");
            DropIndex("dbo.UserRole", new[] { "RoleId" });
            DropIndex("dbo.UserRole", new[] { "UserId" });
            DropIndex("dbo.Transactions", new[] { "cartId" });
            DropIndex("dbo.Transactions", new[] { "userId" });
            DropIndex("dbo.Products", new[] { "categoryId" });
            DropIndex("dbo.OrderItems", new[] { "orderId" });
            DropIndex("dbo.Orders", new[] { "userId" });
            DropIndex("dbo.Orders", new[] { "cartId" });
            DropIndex("dbo.Carts", new[] { "userId" });
            DropIndex("dbo.CartItems", new[] { "cartId" });
            DropIndex("dbo.CartItems", new[] { "productId" });
            DropTable("dbo.UserRole");
            DropTable("dbo.Transactions");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Roles");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
            DropTable("dbo.Users");
            DropTable("dbo.Carts");
            DropTable("dbo.CartItems");
        }
    }
}
