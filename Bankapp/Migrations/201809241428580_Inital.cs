namespace Bankapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "BankApp.Credits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GivenDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("BankApp.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "BankApp.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        PassportNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.PassportNumber, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("BankApp.Credits", "CustomerId", "BankApp.Customers");
            DropIndex("BankApp.Customers", new[] { "PassportNumber" });
            DropIndex("BankApp.Credits", new[] { "CustomerId" });
            DropTable("BankApp.Customers");
            DropTable("BankApp.Credits");
        }
    }
}
