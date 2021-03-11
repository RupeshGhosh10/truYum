namespace TruYumMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCartTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MenuItemCarts",
                c => new
                    {
                        MenuItem_Id = c.Int(nullable: false),
                        Cart_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MenuItem_Id, t.Cart_Id })
                .ForeignKey("dbo.MenuItems", t => t.MenuItem_Id, cascadeDelete: true)
                .ForeignKey("dbo.Carts", t => t.Cart_Id, cascadeDelete: true)
                .Index(t => t.MenuItem_Id)
                .Index(t => t.Cart_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuItemCarts", "Cart_Id", "dbo.Carts");
            DropForeignKey("dbo.MenuItemCarts", "MenuItem_Id", "dbo.MenuItems");
            DropIndex("dbo.MenuItemCarts", new[] { "Cart_Id" });
            DropIndex("dbo.MenuItemCarts", new[] { "MenuItem_Id" });
            DropTable("dbo.MenuItemCarts");
            DropTable("dbo.Carts");
        }
    }
}
