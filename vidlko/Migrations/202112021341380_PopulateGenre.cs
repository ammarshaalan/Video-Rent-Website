namespace vidlko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id, Name) Values(1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) Values(2, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) Values(3, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) Values(4, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) Values(5, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) Values(6, 'Family')");
        }
        
        public override void Down()
        {
        }
    }
}
