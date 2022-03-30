namespace vidlko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT movies ON INSERT INTO movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) Values(1, 'Hangover', 1, 13/06/2018, 6/11/2009, 8  )");
        }
        
        public override void Down()
        {
        }
    }
}
