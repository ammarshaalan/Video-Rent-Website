namespace vidlko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ems7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            DropColumn("dbo.Customers", "Brithdate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Brithdate", c => c.DateTime());
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
