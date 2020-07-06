namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Username", c => c.String(maxLength: 150));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 150));
            AlterColumn("dbo.Products", "ProductName", c => c.String(maxLength: 150));
            AlterColumn("dbo.Products", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "CreatedBy", c => c.String(maxLength: 150));
            AlterColumn("dbo.Products", "ModifiedBy", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ModifiedBy", c => c.String());
            AlterColumn("dbo.Products", "CreatedBy", c => c.String());
            AlterColumn("dbo.Products", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "ProductName", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String());
        }
    }
}
