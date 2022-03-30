namespace vidlko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteEntireCustomerTable2 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Customers");
            Sql("DBCC CHECKIDENT ('Customers', RESEED, 0)");

            
        }
        
        public override void Down()
        {
        }
    }
}
