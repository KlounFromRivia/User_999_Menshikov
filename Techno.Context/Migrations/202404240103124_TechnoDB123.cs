namespace Techno.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TechnoDB123 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "CompleteOrder", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "CompleteOrder", c => c.DateTime(nullable: false));
        }
    }
}
