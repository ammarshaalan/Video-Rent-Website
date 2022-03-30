namespace vidlko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteEntireCustomerTable : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Customers");
        }
        
        public override void Down()
        {
        }
    }
}
