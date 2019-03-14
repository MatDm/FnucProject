namespace Fnuc.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AzureIsAboutToExplode : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShoppingProducts", "ShoppingCart_id", "dbo.ShoppingCarts");
            DropIndex("dbo.ShoppingProducts", new[] { "ShoppingCart_id" });
            RenameColumn(table: "dbo.ShoppingProducts", name: "ShoppingCart_id", newName: "ShoppingCartId");
            AlterColumn("dbo.ShoppingProducts", "ShoppingCartId", c => c.Int(nullable: false));
            CreateIndex("dbo.ShoppingProducts", "ShoppingCartId");
            AddForeignKey("dbo.ShoppingProducts", "ShoppingCartId", "dbo.ShoppingCarts", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingProducts", "ShoppingCartId", "dbo.ShoppingCarts");
            DropIndex("dbo.ShoppingProducts", new[] { "ShoppingCartId" });
            AlterColumn("dbo.ShoppingProducts", "ShoppingCartId", c => c.Int());
            RenameColumn(table: "dbo.ShoppingProducts", name: "ShoppingCartId", newName: "ShoppingCart_id");
            CreateIndex("dbo.ShoppingProducts", "ShoppingCart_id");
            AddForeignKey("dbo.ShoppingProducts", "ShoppingCart_id", "dbo.ShoppingCarts", "id");
        }
    }
}
