namespace Fnuc.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CartsAndProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ShoppingProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        PricePerUnit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ShoppingCart_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShoppingCarts", t => t.ShoppingCart_id)
                .Index(t => t.ShoppingCart_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingProducts", "ShoppingCart_id", "dbo.ShoppingCarts");
            DropIndex("dbo.ShoppingProducts", new[] { "ShoppingCart_id" });
            DropTable("dbo.ShoppingProducts");
            DropTable("dbo.ShoppingCarts");
        }
    }
}
