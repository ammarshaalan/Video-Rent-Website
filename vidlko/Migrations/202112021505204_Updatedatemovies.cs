namespace vidlko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatedatemovies : DbMigration
    {
        public override void Up()
        {
            
            Sql("UPDATE movies SET DateAdded = CAST('2005-5-10' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
