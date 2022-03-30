namespace vidlko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNumberAvailable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MOVIES SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
