namespace OrderManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeOrderAndCustomerIDNullable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 100),
                        Budget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerType = c.String(maxLength: 50),
                        TotalSpent = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTime(nullable: false),
                        PriortyScore = c.Double(nullable: false),
                        OrderStatus = c.String(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        LogID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(),
                        OrderID = c.Int(),
                        LogDate = c.DateTime(nullable: false),
                        LogType = c.String(),
                        LogDetails = c.String(),
                    })
                .PrimaryKey(t => t.LogID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .Index(t => t.CustomerID)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 100),
                        Stock = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductID);

            AlterColumn("dbo.Logs", "OrderID", c => c.Int());
            AlterColumn("dbo.Logs", "CustomerID", c => c.Int());

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Logs", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Logs", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Logs", new[] { "OrderID" });
            DropIndex("dbo.Logs", new[] { "CustomerID" });
            DropIndex("dbo.Orders", new[] { "ProductID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropTable("dbo.Products");
            DropTable("dbo.Logs");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");

            AlterColumn("dbo.Logs", "OrderID", c => c.Int(nullable: false));
            AlterColumn("dbo.Logs", "CustomerID", c => c.Int(nullable: false));
        }
    }
}
