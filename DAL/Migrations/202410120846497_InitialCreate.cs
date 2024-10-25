namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CarId);
            
            CreateTable(
                "dbo.SalesInvoice",
                c => new
                    {
                        SalesInvoiceId = c.Int(nullable: false, identity: true),
                        DateOfSale = c.DateTime(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerId = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SalesInvoiceId)
                .ForeignKey("dbo.Car", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.CarId);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesInvoice", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.SalesInvoice", "CarId", "dbo.Car");
            DropIndex("dbo.SalesInvoice", new[] { "CarId" });
            DropIndex("dbo.SalesInvoice", new[] { "CustomerId" });
            DropTable("dbo.Customer");
            DropTable("dbo.SalesInvoice");
            DropTable("dbo.Car");
        }
    }
}
