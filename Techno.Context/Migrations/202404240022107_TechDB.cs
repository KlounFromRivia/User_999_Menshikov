namespace Techno.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TechDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(nullable: false),
                        MasterId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.MasterId, cascadeDelete: true)
                .Index(t => t.MasterId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        IdUser = c.Int(nullable: false, identity: true),
                        UserFIO = c.String(nullable: false),
                        UserPhone = c.String(nullable: false),
                        UserLogin = c.String(nullable: false),
                        UserPassword = c.String(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        IdOrder = c.Int(nullable: false, identity: true),
                        CreateOrder = c.DateTime(nullable: false),
                        CompleteOrder = c.DateTime(nullable: false),
                        ModelEquipment = c.String(nullable: false),
                        DescriptionDefect = c.String(nullable: false),
                        TypeEquipmentId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        MasterId = c.Int(),
                        Zapchasty = c.String(),
                    })
                .PrimaryKey(t => t.IdOrder)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.TypeEquipments", t => t.TypeEquipmentId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.ClientId)
                .ForeignKey("dbo.Users", t => t.MasterId)
                .Index(t => t.TypeEquipmentId)
                .Index(t => t.StatusId)
                .Index(t => t.ClientId)
                .Index(t => t.MasterId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        IdStatus = c.Int(nullable: false, identity: true),
                        StatusTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdStatus);
            
            CreateTable(
                "dbo.TypeEquipments",
                c => new
                    {
                        IdTypeEquipment = c.Int(nullable: false, identity: true),
                        TypeEquipmentTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdTypeEquipment);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        IdRole = c.Int(nullable: false, identity: true),
                        RoleTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdRole);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "MasterId", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Orders", "MasterId", "dbo.Users");
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Users");
            DropForeignKey("dbo.Orders", "TypeEquipmentId", "dbo.TypeEquipments");
            DropForeignKey("dbo.Orders", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Comments", "OrderId", "dbo.Orders");
            DropIndex("dbo.Orders", new[] { "MasterId" });
            DropIndex("dbo.Orders", new[] { "ClientId" });
            DropIndex("dbo.Orders", new[] { "StatusId" });
            DropIndex("dbo.Orders", new[] { "TypeEquipmentId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Comments", new[] { "OrderId" });
            DropIndex("dbo.Comments", new[] { "MasterId" });
            DropTable("dbo.Roles");
            DropTable("dbo.TypeEquipments");
            DropTable("dbo.Status");
            DropTable("dbo.Orders");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
        }
    }
}
